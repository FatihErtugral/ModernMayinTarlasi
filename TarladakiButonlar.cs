using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ModernMayinTarlasi.Properties;
using System.Reflection;

namespace WindowsFormsApp
{
    class TarladakiButonlar
    {
        private Dictionary<Point, GameMineButton> butonListesi;
        private GameMineButton  _btn;
        private MatrisField2D   matrisDizi;

        // Game field
        private ushort yatayButonSayisi;
        private ushort dikeyButonSayisi;
        private ushort mayinliButonSayisi;


        // Game Button property
        private Color mayinliButonRengi  = Color.FromArgb(42,    42,     42);
        private Color bosAlanButonRengi  = Color.FromArgb(242,   235,    199); 
        private Color numaraliButonRengi = Color.FromArgb(51,    55,     69);     
        private Color butonNumaraRengi   = Color.FromArgb(246,   247,    146); 
        private Color butonAnaRenk       = Color.FromArgb(211,   99,     128);

         
        private Size    btnSize   = new Size(25, 25);
        private Image   mayinImg  = Resources.mineBomb;
        private Image   tedbirImg = Resources.v_for_vendetta;
        private Font    btnFont   = new Font("Let's go Digital", 12f);
        private Point   _Point    = new Point(0, 0); 
        private Padding  btnMargin  = new Padding(2);
        private Padding  btnPadding = new Padding(0);

        // Game Button Event 
        private MouseEventHandler   btnSagClickHandler;
        private EventHandler        btnClickHandler;
        private PaintEventHandler   btnDisableRenkHandler;
        
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
            btnDisableRenkHandler   = new PaintEventHandler(BtnDisableRengi);

            CreateGameButton();
        }
        ///////////////////////////////////////////////////////////////////

        //
        public void MatristekiVeriyiButonlaraCevirListeYap(ref MetroPanel pnlPlatform)
        {
            kaybetme     = false;
            matrisDizi   = new MatrisField2D(this.yatayButonSayisi, this.dikeyButonSayisi, this.mayinliButonSayisi);
            butonListesi = new Dictionary<Point, GameMineButton>();

            pnlPlatform.Width   = this.yatayButonSayisi * btnSize.Width + this.yatayButonSayisi * 2;
            pnlPlatform.Height  = this.dikeyButonSayisi * btnSize.Height + this.dikeyButonSayisi * 2;

            for (int satir = 0; satir < this.yatayButonSayisi; satir++)
            {
                for (int sutun = 0; sutun < this.dikeyButonSayisi; sutun++)
                {
                    _Point.X = satir;
                    _Point.Y = sutun;
                    butonListesi.Add(_Point, DinamikButonOlustur(matrisDizi._2DArray, satir, sutun, ref pnlPlatform));
                }
            }
        }
        ///////////////////////////////////////////////////////////////////

        #region Konsol Metodları

        
        public void MayinlariKilitle()
        {
            foreach (var btn in butonListesi)
            {
                if (btn.Value.Tag.ToString() == "9")
                {
                    btn.Value.BackgroundImage = tedbirImg;
                    //btn.Value.Enabled = false;
                    //btn.Value.BackColor = mayinliButonRengi;
                }
            }
           // kaybetme = true;
        }
        public void MayinlarinKilidiniKaldir()
        {
            foreach (var btn in butonListesi)
            {
                if (btn.Value.Tag.ToString() == "9")
                {
                    btn.Value.BackgroundImage = null;
                    //btn.Value.Enabled = false;
                    //btn.Value.BackColor = mayinliButonRengi;
                }
            }
           // kaybetme = true;
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
                    matris += $" [{matrisDizi._2DArray[k, i]}]";
                }
                matris += "\n";
            }
            return matris;
        }

        #endregion
        ///////////////////////////////////////////////////////////////////

        // Ramde bir adet buton heap kısmına uluşturulur 
        // GameMineButton sınıfı Prototype desenini üzerinde taşır
        // Daha sonra oluşturulcak butonlar bu butondan deep copy yöntemiyle oluşturulur.
        private void CreateGameButton()
        {
            _btn   = new GameMineButton();

            _btn.Size    = btnSize;
            _btn.Margin  = btnMargin;
            _btn.Padding = btnPadding;
            _btn.TabStop = false;
            _btn.TabIndex   = 10;
            _btn.Enabled    = true;
            _btn.FlatStyle  = FlatStyle.Flat;
            _btn.BackColor  = butonAnaRenk;//Color.OliveDrab;
            
            _btn.BackgroundImageLayout = ImageLayout.Stretch;
            
        }
        ///////////////////////////////////////////////////////////////////

        /// <summary>
        /// ikili dizi ile bir matris oluşturup kordinatları verildiğinde,
        /// buton bilgileri işlenir ve ilgili kordinata panel içinde konumlandırılır.
        /// Prototype Tasarım Deseni kullanılarak, butonlar "new" ile değil "deep copy" yöntemiyle üretilir.
        /// </summary>
        /// <param name="matrisHarita">MatrisField sınıfında oluşturulan diziyi alır</param>
        /// <param name="kordinat_X">Dizinin x indisi arr[x,y]</param>
        /// <param name="kordinat_Y">Dizinin y indisi arr[x,y]</param>
        /// <param name="pnlPlatform">AnaForm'da oluşturulan panelin referansı</param>
        /// <returns>Dictonary listesine eklemek için Buton nesnesi geri döndürür</returns>
        private GameMineButton DinamikButonOlustur(int[,] matrisHarita, int kordinat_X, int kordinat_Y, ref MetroPanel pnlPlatform)
        {
            GameMineButton btn = (GameMineButton)_btn.Clone();

            btn.Tag = matrisHarita[kordinat_X, kordinat_Y];
            btn.Name = $"{kordinat_X},{kordinat_Y}"; // Kordinatlar isimlerden yakalanıyor
            
            _Point.X = (kordinat_X * (btn.Height + 2));
            _Point.Y = (kordinat_Y * (btn.Width + 2));
            btn.Location    = _Point;

            btn.Click      += btnClickHandler;
            btn.MouseUp    += btnSagClickHandler;

            pnlPlatform.Controls.Add(btn);
            return btn;
        }
        ///////////////////////////////////////////////////////////////////
        
        

        // Sistem tarafından butonların disable rengi sabittir, değiştirmek için yeniden çizdirmek gerekiyor
        private void BtnDisableRengi(object sender, PaintEventArgs e)
        {
            GameMineButton btn = (GameMineButton)sender;

            TextFormatFlags flags = TextFormatFlags.HorizontalCenter |
                                    TextFormatFlags.VerticalCenter |
                                    TextFormatFlags.WordBreak;   // center the text
            TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, e.ClipRectangle, btn.ForeColor, flags);
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
                        { btn.BackgroundImage = tedbirImg; }
                else    { btn.BackgroundImage = null; }
            }
        }
        ///////////////////////////////////////////////////////////////////

        private void BtnSolTik(object sender, EventArgs e)
        {

            GameMineButton btn = (GameMineButton)sender;

            if (btn.Enabled == false || btn.BackgroundImage != null)
                return;

            if (btn.Tag.ToString() == "9")
            {
                BtnMayinliHepsiniAc();
                //MessageBox.Show("Oyunu kaybettin!");
                return;
            }
            else if (btn.Tag.ToString() == "0")
            {
                btn.Enabled = false;
                int[] cord = btn.Name.Split(',').Select(Int32.Parse).ToArray();
                int cord1 = cord[0];
                int cord2 = cord[1];
                btn.BackColor = bosAlanButonRengi;
                this.AcilmamisMayinsizButon--;

                // Boşları aç
                BtnBosDegerAc(cord1 + 1, cord2);
                BtnBosDegerAc(cord1 - 1, cord2);
                BtnBosDegerAc(cord1, cord2 + 1);
                BtnBosDegerAc(cord1, cord2 - 1);
                // Boşların çevresindeki rakamları aç
                BtnBosCevresindekiRakamlariAc(cord1 + 1, cord2);
                BtnBosCevresindekiRakamlariAc(cord1 - 1, cord2);
                BtnBosCevresindekiRakamlariAc(cord1, cord2 - 1);
                BtnBosCevresindekiRakamlariAc(cord1, cord2 + 1);
                BtnBosCevresindekiRakamlariAc(cord1 + 1, cord2 + 1);
                BtnBosCevresindekiRakamlariAc(cord1 - 1, cord2 - 1);
                return;
            }
            else if (btn.Tag.ToString() != "0" && btn.Tag.ToString() != "9")
            {

                btn.Text    = btn.Tag.ToString();
                btn.Enabled = false;
                btn.BackColor = numaraliButonRengi;
                btn.ForeColor = butonNumaraRengi;
                btn.Paint   += btnDisableRenkHandler;

                //////////////////////////
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

            if (matrisDizi._2DArray[kordinat_X, kordinat_Y] != 0)
                return;
            _Point.X = kordinat_X;
            _Point.Y = kordinat_Y;
            butonListesi.TryGetValue(_Point, out kntrlBtn);

            if (kntrlBtn.Enabled == false)
                return;

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
                    btn.Value.BackgroundImage = mayinImg;
                    btn.Value.Enabled = false;
                    btn.Value.BackColor = mayinliButonRengi;
                }
            }
            kaybetme = true;
        }
        ///////////////////////////////////////////////////////////////////

        private void BtnBosCevresindekiRakamlariAc(int kordinat_X, int kordinat_Y)
        {
            GameMineButton kntrlBtn;

            if (kordinat_X < 0 || kordinat_Y < 0)
                return;
            if (kordinat_X >= yatayButonSayisi ||
                kordinat_Y >= dikeyButonSayisi)
                return;
            _Point.X = kordinat_X;
            _Point.Y = kordinat_Y;
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
                kntrlBtn.BackColor  = numaraliButonRengi;
                kntrlBtn.ForeColor  = butonNumaraRengi;
                //kntrlBtn.Paint      += btnDisableRenkHandler;
                kntrlBtn.Enabled    = false;

                ///////////
                skor += (int)kntrlBtn.Tag + 2;
                this.AcilmamisMayinsizButon--;
            }
        }
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
           
            List<string> lst=new List<string>();
            lst.Add("Font");                        lst.Add("FlatStyle");
            lst.Add("Size");                        lst.Add("BackColor");
            lst.Add("Margin");                      lst.Add("BackgroundImage");
            lst.Add("Padding");                     lst.Add("Text");
            lst.Add("TabStop");                     lst.Add("ForeColor");
            lst.Add("TabIndex");                    lst.Add("Paint");
            lst.Add("Enabled");                     lst.Add("Tag");
            lst.Add("BackgroundImageLayout");

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
    }
    //---------------------------------------------------------------------------------

}
