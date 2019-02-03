﻿using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ModernMayinTarlasi.Properties;
using System.Reflection;

namespace WindowsFormsApp
{
    internal class TarladakiButonlar
    {
        private Dictionary<Point, GameMineButton> butonListesi;
        private GameMineButton  _btn;
        private MatrisField2D   _matrisDizi;

        // Game field
        private ushort yatayButonSayisi;
        private ushort dikeyButonSayisi;
        private ushort mayinliButonSayisi;


        // Game Button Color property
        private Color btnGameStep_BackColor     = Color.FromArgb(242, 242, 242);
        private Color btnGameMine_BackColor     = Color.FromArgb(242, 242, 242);
        private Color btnGameClean_BackColor    = Color.FromArgb(191, 191, 191); 
        private Color btnGameClean_BorderColor  = Color.FromArgb(191, 191, 191); 
        private Color btnGameNum_BackColor      = Color.FromArgb(64, 64, 64);     
        private Color btnGameNum_ForeColor      = Color.FromArgb(165, 219, 0); 
        private Color btnGameNum_BorderColor    = Color.FromArgb(164,164, 164);
        private Color btnGameDefault_BackColor  = Color.FromArgb(72, 72, 72);
        private Color btnGameDefault_BorderColor = Color.FromArgb(72, 72, 72);

         
        private Size    _btnSize   = new Size(25, 25);
        private Image   _btnGameMineImg  = Resources.mine;
        private Image   _btnGameStepImg = Resources.tedbir;
        private Font    _btnFont = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Pixel); //("Let's go Digital", 12f);
        private Point   _Point     = new Point(0, 0); 
        private Padding  _btnMargin  = new Padding(2);
        private Padding  _btnPadding = new Padding(0);

        // Game Button Event 
        private MouseEventHandler   btnSagClickHandler;
        private EventHandler        btnClickHandler;
        
        // Game win lose property 
        public int  AcilmamisMayinsizButon  = 0;
        public int  skor        = 0;
        public bool kaybetme    = false;
        ///////////////////////////////////////////////////////////////////
        
        /// Constructor
        public TarladakiButonlar(ushort yatayButonSayisi, ushort dikeyButonSayisi, ushort mayinliButonSayisi)
        {
            
            
            this.yatayButonSayisi   = yatayButonSayisi;
            this.dikeyButonSayisi   = dikeyButonSayisi;
            this.mayinliButonSayisi = mayinliButonSayisi;
            AcilmamisMayinsizButon = this.yatayButonSayisi * this.dikeyButonSayisi - this.mayinliButonSayisi;

            btnClickHandler         = new EventHandler(BtnSolTik);
            btnSagClickHandler      = new MouseEventHandler(BtnSagTik);

            CreateGameButton();
        }
        ///////////////////////////////////////////////////////////////////

        //
        public void MatristekiVeriyiButonlaraCevirListeYap(ref Panel pnlPlatform)
        {
            kaybetme     = false;
            _matrisDizi   = new MatrisField2D(this.yatayButonSayisi, this.dikeyButonSayisi, this.mayinliButonSayisi);
            butonListesi = new Dictionary<Point, GameMineButton>();

            pnlPlatform.Width   = this.yatayButonSayisi * _btnSize.Width + this.yatayButonSayisi * 2;
            pnlPlatform.Height  = this.dikeyButonSayisi * _btnSize.Height + this.dikeyButonSayisi * 2;

            for (int satir = 0; satir < this.yatayButonSayisi; satir++)
            {
                for (int sutun = 0; sutun < this.dikeyButonSayisi; sutun++)
                {
                    _Point.X = satir;
                    _Point.Y = sutun;
                    butonListesi.Add(_Point, DinamikButonOlustur(_matrisDizi._2DArray, satir, sutun, ref pnlPlatform));
                }
            }
        }
        ///////////////////////////////////////////////////////////////////


        // Ramde bir adet buton heap kısmına uluşturulur 
        // GameMineButton sınıfı Prototype desenini üzerinde taşır
        // Daha sonra oluşturulcak butonlar bu butondan deep copy yöntemiyle oluşturulur.
        private void CreateGameButton()
        {
            _btn   = new GameMineButton();
            _btn.Font    = _btnFont;
            _btn.Size    = _btnSize;
            _btn.Margin  = _btnMargin;
            _btn.Padding = _btnPadding;
            _btn.TabStop = false;
            _btn.TabIndex   = 10;
            _btn.Enabled    = true;
            _btn.FlatStyle  = FlatStyle.Flat;
            _btn.BackColor  = btnGameDefault_BackColor;
            _btn.FlatAppearance.BorderColor = btnGameDefault_BorderColor;
            _btn.BackgroundImageLayout = ImageLayout.Stretch;
        }
        ///////////////////////////////////////////////////////////////////

        /// <summary>
        /// ikili dizi ile bir matris oluşturup kordinatları verildiğinde,
        /// buton bilgileri işlenir ve ilgili kordinata panel içinde konumlandırılır.
        /// Prototype Tasarım Deseni kullanılarak, butonlar "new" ile değil "deep copy" yöntemiyle üretilir.
        /// </summary>
        /// <param name="matrisMap">MatrisField sınıfında oluşturulan diziyi alır</param>
        /// <param name="cord_X">Dizinin x indisi arr[x,y]</param>
        /// <param name="cord_Y">Dizinin y indisi arr[x,y]</param>
        /// <param name="pnlPlatform">AnaForm'da oluşturulan panelin referansı</param>
        /// <returns>Dictonary listesine eklemek için Buton nesnesi geri döndürür</returns>
        private GameMineButton DinamikButonOlustur(int[,] matrisMap, int cord_X, int cord_Y, ref Panel pnlPlatform)
        {
            GameMineButton btn = (GameMineButton)_btn.Clone();

            btn.Tag = matrisMap[cord_X, cord_Y];
            btn.Name = $"{cord_X},{cord_Y}"; // Kordinatlar isimlerden yakalanıyor
            
            _Point.X = (cord_X * (btn.Height + 2));
            _Point.Y = (cord_Y * (btn.Width + 2));
            btn.Location    = _Point;
            
            btn.Click      += btnClickHandler;
            btn.MouseUp    += btnSagClickHandler;
            btn.FlatAppearance.BorderColor = btnGameDefault_BorderColor;

            pnlPlatform.Controls.Add(btn);
            return btn;
        }
        ///////////////////////////////////////////////////////////////////

        // Sağ tıklama uyarı işaret koymak için
        private void BtnSagTik(object sender, MouseEventArgs e)
        {
            GameMineButton btn = (GameMineButton)sender;

            if (btn.Text != "") return;

            if (e.Button == MouseButtons.Right)
            {
                if (btn.BackgroundImage == null)
                {
                    btn.BackgroundImage = _btnGameStepImg;
                    btn.BackColor = btnGameStep_BackColor;
                    btn.FlatAppearance.BorderColor = btnGameNum_BorderColor;
                }
                else    {
                    btn.BackgroundImage = null;
                    btn.BackColor = btnGameDefault_BackColor;
                    btn.FlatAppearance.BorderColor = btnGameDefault_BorderColor;
                }
            }
        }
        ///////////////////////////////////////////////////////////////////

        private void BtnSolTik(object sender, EventArgs e)
        {

            GameMineButton btn = (GameMineButton)sender;

            // Buton sağ tık ile kilitlendiyse sol tıklanamasın.
            if (btn.Enabled == false || btn.BackgroundImage != null)
                return;
            //Bombaya tıklanınca 
            if (btn.Tag.ToString() == "9")
            {
                BtnMayinliHepsiniAc();
                //MessageBox.Show("Oyunu kaybettin!");
                return;
            }
            // Boş butonları ve çevre rakamları açıyor
            else if (btn.Tag.ToString() == "0")
            {
                btn.Enabled = false;
                int[] cord = btn.Name.Split(',').Select(Int32.Parse).ToArray();
                int cord1 = cord[0];
                int cord2 = cord[1];
                btn.FlatAppearance.BorderColor = btnGameClean_BorderColor;
                btn.BackColor = btnGameClean_BackColor;
                this.AcilmamisMayinsizButon--;

                // Boşları aç
                BtnBosDegerAc(cord1 + 1, cord2);
                BtnBosDegerAc(cord1 - 1, cord2);
                BtnBosDegerAc(cord1, cord2 + 1);
                BtnBosDegerAc(cord1, cord2 - 1);
                // Boşların çevresindeki rakamları aç
                BtnBosCevresindekiRakamlariAc(cord1 + 1, cord2 + 1);
                BtnBosCevresindekiRakamlariAc(cord1 - 1, cord2 - 1);
                BtnBosCevresindekiRakamlariAc(cord1 + 1, cord2 - 1);
                BtnBosCevresindekiRakamlariAc(cord1 - 1, cord2 + 1);

                BtnBosCevresindekiRakamlariAc(cord1 + 1, cord2);
                BtnBosCevresindekiRakamlariAc(cord1 - 1, cord2);
                BtnBosCevresindekiRakamlariAc(cord1, cord2 - 1);
                BtnBosCevresindekiRakamlariAc(cord1, cord2 + 1);
                return;
            }
            // Numaralı butonları açıyor
            else if (btn.Tag.ToString() != "0" && btn.Tag.ToString() != "9")
            {

                btn.Text    = btn.Tag.ToString();
                btn.Enabled = false;
                btn.BackColor = btnGameNum_BackColor;
                btn.ForeColor = btnGameNum_ForeColor;
                btn.FlatAppearance.BorderColor = btnGameNum_BorderColor;
                // Skor puanlama
                skor += (int)btn.Tag + 2;
                this.AcilmamisMayinsizButon--;
            }
        }
        ///////////////////////////////////////////////////////////////////

        
        private void BtnBosDegerAc(int kordinat_X, int kordinat_Y)
        {
            GameMineButton kntrlBtn;
            if (kordinat_X < 0 || kordinat_Y < 0)
                return;

            if (kordinat_X >= yatayButonSayisi ||
                kordinat_Y >= dikeyButonSayisi)
                return;

            if (_matrisDizi._2DArray[kordinat_X, kordinat_Y] != 0)
                return;
            _Point.X = kordinat_X;
            _Point.Y = kordinat_Y;
            butonListesi.TryGetValue(_Point, out kntrlBtn);

            if (kntrlBtn.Enabled == false)
                return;

            // Skor puanlama
            skor += 2;
            kntrlBtn.PerformClick();
            return;
        }
        ///////////////////////////////////////////////////////////////////

        // Dictionary yapısı içindeki bütün 9 Tagını bulunduran butonları açıyor.
        public void BtnMayinliHepsiniAc()
        {
            foreach (var btn in butonListesi)
            {
                if (btn.Value.Tag.ToString() == "9")
                {
                    btn.Value.Enabled = false;
                    btn.Value.BackgroundImage = _btnGameMineImg;
                    btn.Value.BackColor = btnGameMine_BackColor;
                }
            }
            kaybetme = true;
        }
        ///////////////////////////////////////////////////////////////////

        private void BtnBosCevresindekiRakamlariAc(int cord_X, int cord_Y)
        {
            GameMineButton kntrlBtn;

            if (cord_X < 0 || cord_Y < 0)
                return;
            if (cord_X >= yatayButonSayisi ||
                cord_Y >= dikeyButonSayisi)
                return;
            _Point.X = cord_X;
            _Point.Y = cord_Y;
            butonListesi.TryGetValue(_Point, out kntrlBtn);

            if (kntrlBtn.Enabled == false)
                return;

            if ((int)kntrlBtn.Tag == 1 || (int)kntrlBtn.Tag == 2 ||
                (int)kntrlBtn.Tag == 3 || (int)kntrlBtn.Tag == 4 ||
                (int)kntrlBtn.Tag == 5 || (int)kntrlBtn.Tag == 6 ||
                (int)kntrlBtn.Tag == 7 || (int)kntrlBtn.Tag == 8
                )
            {
                kntrlBtn.BackgroundImage = null;
                kntrlBtn.Text       = kntrlBtn.Tag.ToString();
                kntrlBtn.BackColor  = btnGameNum_BackColor;
                kntrlBtn.ForeColor  = btnGameNum_ForeColor;
                kntrlBtn.FlatAppearance.BorderColor = btnGameNum_BorderColor;


                kntrlBtn.Enabled    = false;

                // Skor puanlama
                skor += (int)kntrlBtn.Tag + 2;
                this.AcilmamisMayinsizButon--;
            }
        }

        
        #region Konsol Metodları

       
        public void MayinlariKilitle()
        {
            foreach (var btn in butonListesi)
            {
                if (btn.Value.Tag.ToString() == "9")
                {
                    btn.Value.BackgroundImage = _btnGameStepImg;
                    btn.Value.BackColor = btnGameMine_BackColor;
                }
            }
        }

        public void MayinlarinKilidiniKaldir()
        {
            foreach (var btn in butonListesi)
            {
                if (btn.Value.Tag.ToString() == "9")
                {
                    btn.Value.BackgroundImage = null;
                    btn.Value.BackColor = btnGameDefault_BackColor;
                }
            }
        }
        ///////////////////////////////////////////////////////////////////
        /// <summary>
        /// İki boyutlu diziyi sitring olarak yazdır
        /// </summary>
        /// <returns></returns>
        public string MatrisPrint()
        {
            string matris ="";
            for (int i = 0; i < this.dikeyButonSayisi; i++)
            {
                for (int k = 0; k < this.yatayButonSayisi; k++)
                {
                    matris += $" [{_matrisDizi._2DArray[k, i]}]";
                }
                matris += "\n";
            }
            return matris;
        }

        #endregion
        ///////////////////////////////////////////////////////////////////
    }
    //---------------------------------------------------------------------------------

    //prototype patterni kullanırken deep copy olabilecek olan nesnelerimizin türemesi gereken interface
    public interface IPrototype
    {
        IPrototype Clone(object val=null);
    }
    //---------------------------------------------------------------------------------

    [Serializable]
    public class GameMineButton : Button, IPrototype
    {
        public IPrototype Clone(object val = null)
        {
            GameMineButton copyButton = Activator.CreateInstance<GameMineButton>();//önce GameMineButton Bir instance oluşturulur.
            PropertyInfo[] piList = this.GetType()//mevcut içerinde bulunduğumuz sınıfın property leri çekilir.
                .GetProperties();

            //mevcut property' lerden kopyalanmak istenen property ler belirtilir. Ancak bu örnekte hepsine gerek yoktur.
            //çünkü zaten oluşturuduğumuz copy sınıfının default değerleri içerisinde bulunduğumuz sınıf tarafından değiştirilmemektedir.
            //uygulama gereksinimine göre hepsi de kopyalanabilir.

            List<string> lst = new List<string>
            {
                "Font",
                "FlatStyle",
                "Size",
                "BackColor",
                "Margin",
                "BackgroundImage",
                "Padding",
                "Text",
                "TabStop",
                "ForeColor",
                "TabIndex",
                "Paint",
                "Enabled",
                "Tag",
                "BackgroundImageLayout"
            };

            foreach (PropertyInfo pi in piList.Where(i=>lst.Contains(i.Name)))//içerisinde bulunduğumuz sınıfın propertyleri içerisinde dönülmeye başlanır.
            {
                if (pi.GetValue(copyButton, null) != pi.GetValue(this, null))//sırayla yeni copy nesnemize atanır.
                {
                    if (pi.CanWrite)
                    {
                        pi.SetValue(copyButton, pi.GetValue(this, null), null);
                    }
                }
            }

            return copyButton;
        }
        ///////////////////////////////////////////////////////////////////
        

        // Butonun Disabled rengi sistemde gri ve sabit, OnPaint override edilerek yeniden biçimlendiriliyor.
        protected override void OnPaint(PaintEventArgs pe)
        {
            if( base.Enabled )
            {
                base.OnPaint(pe);
            }
            else
            {
                // Calling the base class OnPaint
                base.OnPaint(pe);
                // Setup the Formatting for the text
                StringFormat formatText = new StringFormat(StringFormatFlags.NoClip)
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Center,
                    Trimming = StringTrimming.Character
                };
                // Drawing the button yoursel. The background is color
                // pe.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(51,    55,     69)), pe.ClipRectangle);
                // Draw the line around the button
                // pe.Graphics.DrawRectangle(new Pen(base.FlatAppearance.BorderColor, 1), 0, 0, base.Width - 1, base.Height - 1);
                // Draw the text in the button in color
                pe.Graphics.DrawString(base.Text, base.Font, new SolidBrush(base.ForeColor),
                    new RectangleF(0F, 0F, base.Width, base.Height),  formatText);
            }
        }
    }
    //---------------------------------------------------------------------------------

}
