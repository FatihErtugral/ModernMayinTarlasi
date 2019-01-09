using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp.Properties;

namespace WindowsFormsApp
{
    class TarladakiButonlar
    {
        public Dictionary<Point, Button> butonListesi;
        private MatrisField2D matrisDizi;

        private ushort yatayButonSayisi;
        private ushort dikeyButonSayisi;
        private ushort mayinliButonSayisi;

        private Color mayinliButonRengi;
        private Color bosAlanButonRengi;
        private Color numaraliButonRengi;
        private Color butonNumaraRengi;
        private Color butonAnaRenk;

        private Size    btnSize     = new Size(25, 25);
        private Image   MayinImg    = Resources.dinamit;
        private Image   TedbirImg   = Resources.v_for_vendetta;

        public int  AcilmamisMayinsizButon  = 0;
        public int  skor        = 0;
        public bool kaybetme    = false;

        ///////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////
        public TarladakiButonlar(ushort yatayButonSayisi, ushort dikeyButonSayisi, ushort mayinliButonSayisi)
        {
            this.yatayButonSayisi   = yatayButonSayisi;
            this.dikeyButonSayisi   = dikeyButonSayisi;
            this.mayinliButonSayisi = mayinliButonSayisi;

            mayinliButonRengi   = Color.FromArgb(42, 42, 42);
            bosAlanButonRengi   = Color.FromArgb(242, 235, 199);
            numaraliButonRengi  = Color.FromArgb(51, 55, 69);
            butonNumaraRengi    = Color.FromArgb(246, 247, 146);
            butonAnaRenk        = Color.FromArgb(211, 99, 128);
            AcilmamisMayinsizButon = this.yatayButonSayisi * this.dikeyButonSayisi - this.mayinliButonSayisi;
 
        }
        ///////////////////////////////////////////////////////////////////

        public void MatristekiVeriyiButonlaraCevirListeYap(ref MetroPanel pnlPlatform)
        {
            kaybetme    = false;
            matrisDizi  = new MatrisField2D(this.yatayButonSayisi, this.dikeyButonSayisi, this.mayinliButonSayisi);
            butonListesi = new Dictionary<Point, Button>();

            pnlPlatform.Width   = this.yatayButonSayisi * btnSize.Width + this.yatayButonSayisi * 2;
            pnlPlatform.Height  = this.dikeyButonSayisi * btnSize.Height + this.dikeyButonSayisi * 2;

            for (int satir = 0; satir < this.yatayButonSayisi; satir++)
                for (int sutun = 0; sutun < this.dikeyButonSayisi; sutun++)
                    butonListesi.Add(new Point(satir, sutun), DinamikButonOlustur(matrisDizi._2DArray, satir, sutun, ref pnlPlatform));
        }
        ///////////////////////////////////////////////////////////////////

        // ikili dizi ile bir matris oluşturup kordinatları verildiğinde,
        // buton bilgileri işlenir ve ilgili kordinata panel içinde konumlandırılır
        private Button DinamikButonOlustur(int[,] matrisHarita, int kordinat_X, int kordinat_Y, ref MetroPanel pnlPlatform)
        {
            Button btn = new Button();

            btn.BackgroundImageLayout = ImageLayout.Stretch;

            btn.Tag     = matrisHarita[kordinat_X, kordinat_Y];
            btn.Name    = $"{kordinat_X},{kordinat_Y}"; // Kordinatlar isimlerden yakalanıyor
            btn.Font    = new Font("Let's go Digital", 12f);
            btn.Size    = btnSize;
            btn.Margin  = new Padding(2);
            btn.Padding = new Padding(0);
            btn.TabStop = false;
            btn.TabIndex    = 10;
            btn.Enabled     = true;
            btn.FlatStyle   = FlatStyle.Flat;
            btn.BackColor   = butonAnaRenk;//Color.OliveDrab;
            btn.Location    = new Point { X = kordinat_X * (btn.Height+2), Y = kordinat_Y * (btn.Width+2) };
            btn.Click   += new EventHandler(BtnSolTik);
            btn.MouseUp += new MouseEventHandler(BtnSagTik);


            pnlPlatform.Controls.Add(btn);
            return btn;
        }
        ///////////////////////////////////////////////////////////////////

        // Sistem tarafından butonların disable rengi sabittir, değiştirmek için yeniden çizdirmek gerekiyor
        private void BtnDisableRengi(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;

            TextFormatFlags flags = TextFormatFlags.HorizontalCenter |
                                    TextFormatFlags.VerticalCenter |
                                    TextFormatFlags.WordBreak;   // center the text
            TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, e.ClipRectangle, btn.ForeColor, flags);
        }
        ///////////////////////////////////////////////////////////////////

        // Sağ tıklama uyarı işaret koymak için
        private void BtnSagTik(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text != "") return;

            if (e.Button == MouseButtons.Right)
            {
                if (btn.BackgroundImage == null) { btn.BackgroundImage = TedbirImg; }
                else { btn.BackgroundImage = null; }
            }
        }
        ///////////////////////////////////////////////////////////////////

        private void BtnSolTik(object sender, EventArgs e)
        {

            Button btn = (Button)sender;

            if (btn.Enabled == false || btn.BackgroundImage != null)
                return;

            if (btn.Tag.ToString() == "-1")
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
            else if (btn.Tag.ToString() != "0" && btn.Tag.ToString() != "-1")
            {

                btn.Text    = btn.Tag.ToString();
                btn.Enabled = false;
                btn.BackColor = numaraliButonRengi;
                btn.ForeColor = butonNumaraRengi;
                btn.Paint   += new PaintEventHandler(BtnDisableRengi);

                //////////////////////////
                skor += (int)btn.Tag + 2;
                this.AcilmamisMayinsizButon--;
            }
        }
        ///////////////////////////////////////////////////////////////////


        private void BtnBosDegerAc(int kordinat_X, int kordinat_Y)
        {
            Button kntrlBtn;
            if (kordinat_X < 0 || kordinat_Y < 0)
                return;

            if (kordinat_X >= yatayButonSayisi ||
                kordinat_Y >= dikeyButonSayisi)
                return;

            if (matrisDizi._2DArray[kordinat_X, kordinat_Y] != 0)
                return;

            butonListesi.TryGetValue(new Point(kordinat_X, kordinat_Y), out kntrlBtn);

            if (kntrlBtn.Enabled == false)
                return;

            skor += 2;
            kntrlBtn.PerformClick();
            return;
        }
        ///////////////////////////////////////////////////////////////////

        // Dictionary yapısı içindeki bütün -1 Tagını bulunduran butonları açıyor.
        public void BtnMayinliHepsiniAc()
        {
            foreach (var btn in butonListesi)
            {
                if (btn.Value.Tag.ToString() == "-1")
                {
                    btn.Value.BackgroundImage = MayinImg;
                    btn.Value.Enabled = false;
                    btn.Value.BackColor = mayinliButonRengi;
                }
            }
            kaybetme = true;
        }
        ///////////////////////////////////////////////////////////////////

        private void BtnBosCevresindekiRakamlariAc(int kordinat_X, int kordinat_Y)
        {
            Button kntrlBtn;

            if (kordinat_X < 0 || kordinat_Y < 0)
                return;
            if (kordinat_X >= yatayButonSayisi ||
                kordinat_Y >= dikeyButonSayisi)
                return;

            butonListesi.TryGetValue(new Point(kordinat_X, kordinat_Y), out kntrlBtn);

            if (kntrlBtn.Enabled == false)
                return;

            if ((int)kntrlBtn.Tag == 1 || (int)kntrlBtn.Tag == 2 ||
                (int)kntrlBtn.Tag == 3 || (int)kntrlBtn.Tag == 4 ||
                (int)kntrlBtn.Tag == 5 || (int)kntrlBtn.Tag == 6 ||
                (int)kntrlBtn.Tag == 7 || (int)kntrlBtn.Tag == 8
                )
            {
                kntrlBtn.Text       = kntrlBtn.Tag.ToString();
                kntrlBtn.BackColor  = numaraliButonRengi;
                kntrlBtn.ForeColor  = butonNumaraRengi;
                kntrlBtn.Paint      += new PaintEventHandler(BtnDisableRengi);
                kntrlBtn.Enabled    = false;

                ///////////
                skor += (int)kntrlBtn.Tag + 2;
                this.AcilmamisMayinsizButon--;
            }
        }
    }
}
