using System;
using System.Drawing;
using System.Windows.Forms;
// MatrisField sınıfında:  İki boyutlu integer bir matriste, mayınlı butonları temsil etmesi için random sayı ile "-1" ile kodlanıp matrise yerleştiriliyor
// Aynı zamanda yerleştirilen "-1" çevreisindeki hücrelerin(indis) değeri bir arttırıylıyor.(mayın tarlası oyununun kuralları gereği rakamlar, çevresinde bulunan mayın  sayısını vermelidir.)
// Matris oluşturulduktan sonra TarladakiButonlar sınıfında matris referans alınıp butonlar Dictionary yapısı içinde, kordinatları(key) kodlanarak yerleştiriliyor. Bu şekilde tasarlamak, buton boyutlarını rahat ayarlamamızı sağlıyor
// buton çok geniş kapsamlı bir nesne olduğu için zayıf bilgisayarlarda oyun kasabilir. Onun yerine daha az özellikli bir buton nesnesi tanımlanabilirdi.
namespace WindowsFormsApp
{
    public partial class AnaForm : MetroFramework.Forms.MetroForm
    {
        private TarladakiButonlar   MayinTarlasi;
        private SkorJsonDosyaCikisi SkorTablosu;
        private string  takmaIsim;
        private ushort  mayinSayisi;
        private int     saniye = 0;

        public AnaForm()
        {
            InitializeComponent();
            pencereyiKonumlandir();
            this.ActiveControl = txtBxTakmaIsim;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SkorTablosu = new SkorJsonDosyaCikisi();
            metroToggle1.Style = this.Style;
            metroToggle1.Theme = this.Theme;
            metroToggle2.Style = this.Style;
            metroToggle2.Theme = this.Theme;
            metroToggle3.Style = this.Style;
            metroToggle3.Theme = this.Theme;
            
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
            this.Hide();
            panel1.Visible = flowLayoutPanel2.Visible = false;

            if (metroToggle1.CheckState == CheckState.Checked)
            {
                mayinSayisi     = 15;
                saniye          = 100;
                MayinTarlasi    = new TarladakiButonlar(22, 10, mayinSayisi);

            }
            else if (metroToggle2.CheckState == CheckState.Checked)
            {
                mayinSayisi     = 30;
                saniye          = 150;
                MayinTarlasi    = new TarladakiButonlar(22, 15, mayinSayisi);
            }
            else if (metroToggle3.CheckState == CheckState.Checked)
            {
                mayinSayisi     = 45;
                saniye          = 200;
                MayinTarlasi    = new TarladakiButonlar(22, 20, mayinSayisi);
            }
            metroTile1.Top  = 130;
            metroPanel1.Top = 145;
            MayinTarlasi.MatristekiVeriyiButonlaraCevirListeYap(ref metroPanel1);
            this.Width      = metroPanel1.Width + 46;
            this.Height     = metroPanel1.Height + 160;
            this.MinimumSize = new Size(metroPanel1.Width + 46,metroPanel1.Height + 160);
            this.MaximumSize = new Size(metroPanel1.Width + 46,metroPanel1.Height + 160);
            metroTile1.Width = metroPanel1.Width;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            lblMayinSayisiBoard.Text    = mayinSayisi.ToString();
            tableLayoutPanel1.Visible   = true;
            metroTile1.Visible          = true;
            takmaIsim = (txtBxTakmaIsim.Text == "" ) ? "-" : txtBxTakmaIsim.Text;
            timer1.Start();

            pencereyiKonumlandir();
            this.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye--;
            if (saniye == 0)
            {
                SkorTablosu.Ekle(takmaIsim, MayinTarlasi.skor);
                timer1.Stop();
                SkorGoster();
                return;
            }
            lblSkorBoard.Text      = MayinTarlasi.skor.ToString();
            lblTemizAlanBoard.Text = MayinTarlasi.AcilmamisMayinsizButon.ToString();
            lblKalanSureBoard.Text = saniye.ToString();

            if (MayinTarlasi.AcilmamisMayinsizButon == 0)
            {
                SkorTablosu.Ekle(takmaIsim, MayinTarlasi.skor + (saniye *2)); // kalan saniye 2 ile çarpılıp skora ekleniyor.
                lblSkorBoard.Text = (MayinTarlasi.skor).ToString();
                timer1.Stop();
                SkorGoster();
                return;
            }
            if (MayinTarlasi.kaybetme)
            {
                SkorTablosu.Ekle(takmaIsim, MayinTarlasi.skor);
                timer1.Stop();
                SkorGoster();
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
            pencereyiBaslangicAyarlarinaCek();
        }

        private void pencereyiKonumlandir()
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                                      (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 4);
        }

        private void pencereyiBaslangicAyarlarinaCek()
        {
            timer1.Stop();
            this.Hide();
            metroPanel1.Controls.Clear();
            lblSkorBoard.Text      = "0";
            lblTemizAlanBoard.Text = "0";
            lblKalanSureBoard.Text = "0";
            MayinTarlasi                = null;
            tableLayoutPanel1.Visible   = false;
            panel1.Visible              = true;
            flowLayoutPanel2.Visible    = true;
            txtBxTakmaIsim.Focus();
            metroTile1.Top = 173;
            this.Show();
        }
        private void metroToggle1_Click(object sender, EventArgs e)
        {
            metroToggle1.CheckState = CheckState.Checked;
            metroToggle2.CheckState = CheckState.Unchecked;
            metroToggle3.CheckState = CheckState.Unchecked;
        }

        private void metroToggle2_Click(object sender, EventArgs e)
        {
            metroToggle1.CheckState = CheckState.Unchecked;
            metroToggle2.CheckState = CheckState.Checked;
            metroToggle3.CheckState = CheckState.Unchecked;
        }

        private void metroToggle3_Click(object sender, EventArgs e)
        {
            metroToggle1.CheckState = CheckState.Unchecked;
            metroToggle2.CheckState = CheckState.Unchecked;
            metroToggle3.CheckState = CheckState.Checked;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Menu.Show(metroButton1, 0, metroButton1.Height);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox
            {
                Theme = Theme,
                Style = Style,
                StyleManager = StyleManager
            };
            ab.Show();
        }
    }
}
