
using System;
using System.Drawing;
using System.Windows.Forms;
// MatrisField sınıfında:  İki boyutlu integer bir matriste, mayınlı butonları temsil etmesi için random sayı ile "9" ile kodlanıp matrise yerleştiriliyor
// Aynı zamanda yerleştirilen "9" çevreisindeki hücrelerin(indis) değeri bir arttırıylıyor.(mayın tarlası oyununun kuralları gereği rakamlar, çevresinde bulunan mayın  sayısını vermelidir.)
// Matris oluşturulduktan sonra TarladakiButonlar sınıfında matris referans alınıp butonlar Dictionary yapısı içinde, kordinatları(key) kodlanarak yerleştiriliyor. Bu şekilde tasarlamak, buton boyutlarını rahat ayarlamamızı sağlıyor
namespace WindowsFormsApp
{
    public partial class AnaForm : MetroFramework.Forms.MetroForm
    {
        private TarladakiButonlar   MayinTarlasi;
        private SkorJsonDosyaCikisi SkorTablosu;
        private SlidingPanel        consolePanel;

        private Button  btnCnslOpen;
        private string  takmaIsim;
        private ushort  mayinSayisi;
        private int     saniye = 0;


        public AnaForm()
        {
            InitializeComponent();
            //Konum
            pencereyiKonumlandir();

            //Skor
            SkorTablosu = new SkorJsonDosyaCikisi();
            this.ActiveControl = txtBxTakmaIsim;

            //Konsol
            btnCnslOpen = new Button();
            consolePanel = new SlidingPanel(ref pnlConsole,ref btnCnslOpen, -400,0);
            this.pnlConsole.Width = this.Width;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////////////////////////////////////////////////////
            titleBaslikAltCizgi.Theme = txtBxTakmaIsim.Theme = lblSkor.Theme =
            toggleKolay.Theme   = toggleOrta.Theme      = toggleZor.Theme       = btnMenu.Theme = 
            lblKalansure.Theme  = lblKolay.Theme        = lblMayinSayisi.Theme  = lblOrta.Theme = 
            lblTemizAlan.Theme  = lblTakmaIsım.Theme    = lblTemizAlan.Theme    = lblZor.Theme  = this.Theme;
            /////////////////////////////////////////////////////////////////////////////////////////////////
            titleBaslikAltCizgi.Style = txtBxTakmaIsim.Style = lblSkor.Style =
            toggleKolay.Style   = toggleOrta.Style      = toggleZor.Style       = btnMenu.Style = 
            lblKalansure.Style  = lblKolay.Style        = lblMayinSayisi.Style  = lblOrta.Style = 
            lblTemizAlan.Style  = lblTakmaIsım.Style    = lblTemizAlan.Style    = lblZor.Style  = this.Style;
            /////////////////////////////////////////////////////////////////////////////////////////////////
            this.ForeColor = Color.FromArgb(191, 191, 191);
        }

        private void yeniOyunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pencereyiBaslangicAyarlarinaCek();
        }

        private void txtBxTakmaIsim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnBaslat_Click(this, new EventArgs());
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            pnlGameMap.Hide();
            pnlTakmaIsimBaslat.Visible = flwPnlGameLvl.Visible = false;
           
            #region Oyun zorluk derecesi
           
            if (toggleKolay.CheckState == CheckState.Checked)
            {
                mayinSayisi     = 25;
                saniye          = 100;
                MayinTarlasi    = new TarladakiButonlar(22, 10, mayinSayisi);

            }
            else if (toggleOrta.CheckState == CheckState.Checked)
            {
                mayinSayisi     = 40;
                saniye          = 150;
                MayinTarlasi    = new TarladakiButonlar(22, 15, mayinSayisi);
            }
            else if (toggleZor.CheckState == CheckState.Checked)
            {
                mayinSayisi     = 55;
                saniye          = 200;
                MayinTarlasi    = new TarladakiButonlar(22, 20, mayinSayisi);
            }
            #endregion

            #region Boyutlandırma - Panel gizleyip açma - Pencere konumlandırma
            
            //Butonları oluşturucu fonksiyon
            MayinTarlasi.MatristekiVeriyiButonlaraCevirListeYap(ref pnlGameMap);

            this.Width      = pnlGameMap.Width + 46;
            this.Height     = pnlGameMap.Height + 160;
            this.MinimumSize = new Size(pnlGameMap.Width + 46,pnlGameMap.Height + 160);
            this.MaximumSize = new Size(pnlGameMap.Width + 46,pnlGameMap.Height + 160);
            this.pnlConsole.Width = this.Width;
            
            titleBaslikAltCizgi.Width = pnlGameMap.Width;
            lblMayinSayisiBoard.Text    = mayinSayisi.ToString();
            tableLayoutPanel1.Visible   = true;
            takmaIsim = (txtBxTakmaIsim.Text == "" ) ? "-" : txtBxTakmaIsim.Text;
            titleBaslikAltCizgi.Top  = 130;
            pnlGameMap.Top = 145;
            timer1.Start();
            pencereyiKonumlandir();
            Refresh();
            pnlGameMap.Show();
         
            #endregion
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye--;
            if (saniye == 0) //lost time is over
            {
                SkorTablosu.Ekle(takmaIsim, MayinTarlasi.skor);
                timer1.Stop();
                SkorGoster();
                pencereyiBaslangicAyarlarinaCek();    
                return;
            }

            lblSkorBoard.Text      = MayinTarlasi.skor.ToString();
            lblTemizAlanBoard.Text = MayinTarlasi.AcilmamisMayinsizButon.ToString();
            lblKalanSureBoard.Text = saniye.ToString();

            if (MayinTarlasi.AcilmamisMayinsizButon == 0) // Win
            {
                SkorTablosu.Ekle(takmaIsim, MayinTarlasi.skor + (saniye *2)); // kalan saniye 2 ile çarpılıp skora ekleniyor.
                lblSkorBoard.Text = (MayinTarlasi.skor + (saniye *2)).ToString();
                timer1.Stop();
                SkorGoster();
                pencereyiBaslangicAyarlarinaCek();
                return;
            }
            if (MayinTarlasi.kaybetme) // Game over
            {
                SkorTablosu.Ekle(takmaIsim, MayinTarlasi.skor);
                timer1.Stop();
                SkorGoster();
                pencereyiBaslangicAyarlarinaCek();
                return;
            }
        }

        private void SkorGoster()
        {
            SkorForm skrfrm = new SkorForm
            {
                Owner = this,
                StyleManager = StyleManager,
                Theme = Theme,
                Style = Style
            };
            skrfrm.ShowDialog();
        }

        private void pencereyiKonumlandir()
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                                      (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 4);
        }

        private void pencereyiBaslangicAyarlarinaCek()
        {
            timer1.Stop();
            pnlGameMap.Hide();
            pnlGameMap.Controls.Clear();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            txtBxTakmaIsim.Focus();

            lblSkorBoard.Text      = "0";
            lblTemizAlanBoard.Text = "0";
            lblKalanSureBoard.Text = "0";
            MayinTarlasi                = null;
            tableLayoutPanel1.Visible   = false;
            titleBaslikAltCizgi.Top = 173;
            this.Refresh();
            pnlTakmaIsimBaslat.Visible  = true;
            flwPnlGameLvl.Visible       = true;
        }

        #region kolay-orta-zor buton seçme senkronizasyon

        
        private void metroToggle1_Click(object sender, EventArgs e)
        {
            toggleKolay.CheckState = CheckState.Checked;
            toggleOrta.CheckState = CheckState.Unchecked;
            toggleZor.CheckState = CheckState.Unchecked;
        }

        private void metroToggle2_Click(object sender, EventArgs e)
        {
            toggleKolay.CheckState = CheckState.Unchecked;
            toggleOrta.CheckState = CheckState.Checked;
            toggleZor.CheckState = CheckState.Unchecked;
        }

        private void metroToggle3_Click(object sender, EventArgs e)
        {
            toggleKolay.CheckState = CheckState.Unchecked;
            toggleOrta.CheckState = CheckState.Unchecked;
            toggleZor.CheckState = CheckState.Checked;
        }
        #endregion

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu.Show(btnMenu, 0, btnMenu.Height);
        }

        private void CikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skorTablosuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SkorForm skrfrm = new SkorForm
            {
                Owner = this,
                StyleManager = StyleManager,
                Theme = Theme,
                Style = Style
            };
            skrfrm.ShowDialog();
        }

        private void HakkindaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox
            {
                Theme = Theme,
                Style = Style,
                StyleManager = StyleManager
            };
            ab.Show();
        }


        #region Konsol

       
        private void ConsoleTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && MayinTarlasi !=null)
            {
                richTextBox1.Text   += consoleTxtBx.Text + "\n";
                if (consoleTxtBx.Text == "help")
                {
                    richTextBox1.Text +=    "print array    => iki boyutlu diziyi yazdırır, 9'lar mayınları temsil eder\n"+
                                            "bomb off       => Bütün mayınları tedbirli moda geçirir\n"+
                                            "bomb on        => Bütün mayınları tedbirli moddan çıkartır\n"+
                                            "clear          => Ekranı temizler\n"+
                                            "exit           => Oyunu kapatır\n";
                }
                else if (consoleTxtBx.Text == "print array" )
                {
                    richTextBox1.Text += MayinTarlasi.MatrisPrint();
                }
                else if (consoleTxtBx.Text == "bomb off")
                {
                    MayinTarlasi.MayinlariKilitle();
                }
                else if (consoleTxtBx.Text == "bomb on")
                {
                    MayinTarlasi.MayinlarinKilidiniKaldir();
                }
                else if (consoleTxtBx.Text == "clear")
                {
                    richTextBox1.Text = "";
                }
                else if (consoleTxtBx.Text == "exit")
                {
                    this.Close();
                    return;
                }

                consoleTxtBx.Text   = "";
                richTextBox1.SelectionStart = richTextBox1.TextLength;
                richTextBox1.ScrollToCaret();
            }
        }
        
        private void AnaForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '"'  && MayinTarlasi !=null)
            {
                btnCnslOpen.PerformClick();
                consoleTxtBx.Focus();
            }
        }

        private void consoleTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '"')
            {
                e.Handled = true;
                return;
            }
            e.Handled=false;
            return;
        }

        #endregion
    }
}
