namespace WindowsFormsApp
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Menu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.yeniOyunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skorTablosuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblKalanSureBoard = new System.Windows.Forms.Label();
            this.lblMayinSayisiBoard = new System.Windows.Forms.Label();
            this.lblSkorBoard = new System.Windows.Forms.Label();
            this.lblTemizAlanBoard = new System.Windows.Forms.Label();
            this.lblTemizAlan = new MetroFramework.Controls.MetroLabel();
            this.lblMayinSayisi = new MetroFramework.Controls.MetroLabel();
            this.lblKalansure = new MetroFramework.Controls.MetroLabel();
            this.lblSkor = new MetroFramework.Controls.MetroLabel();
            this.titleBaslikAltCizgi = new MetroFramework.Controls.MetroTile();
            this.lblTakmaIsım = new MetroFramework.Controls.MetroLabel();
            this.txtBxTakmaIsim = new MetroFramework.Controls.MetroTextBox();
            this.btnBaslat = new MetroFramework.Controls.MetroButton();
            this.flwPnlGameLvl = new System.Windows.Forms.FlowLayoutPanel();
            this.lblKolay = new MetroFramework.Controls.MetroLabel();
            this.toggleKolay = new MetroFramework.Controls.MetroToggle();
            this.lblOrta = new MetroFramework.Controls.MetroLabel();
            this.toggleOrta = new MetroFramework.Controls.MetroToggle();
            this.lblZor = new MetroFramework.Controls.MetroLabel();
            this.toggleZor = new MetroFramework.Controls.MetroToggle();
            this.pnlTakmaIsimBaslat = new System.Windows.Forms.Panel();
            this.pnlConsole = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.consoleTxtBx = new System.Windows.Forms.TextBox();
            this.pnlGameMap = new System.Windows.Forms.Panel();
            this.btnMenu = new MetroFramework.Controls.MetroButton();
            this.Menu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flwPnlGameLvl.SuspendLayout();
            this.pnlTakmaIsimBaslat.SuspendLayout();
            this.pnlConsole.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniOyunToolStripMenuItem,
            this.skorTablosuToolStripMenuItem,
            this.hakkındaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.Menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(142, 92);
            this.Menu.Text = "Menü";
            this.Menu.UseCustomBackColor = true;
            this.Menu.UseCustomForeColor = true;
            this.Menu.UseStyleColors = true;
            // 
            // yeniOyunToolStripMenuItem
            // 
            this.yeniOyunToolStripMenuItem.Name = "yeniOyunToolStripMenuItem";
            this.yeniOyunToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.yeniOyunToolStripMenuItem.Text = "Yeni Oyun";
            this.yeniOyunToolStripMenuItem.Click += new System.EventHandler(this.yeniOyunToolStripMenuItem_Click);
            // 
            // skorTablosuToolStripMenuItem
            // 
            this.skorTablosuToolStripMenuItem.Name = "skorTablosuToolStripMenuItem";
            this.skorTablosuToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.skorTablosuToolStripMenuItem.Text = "Skor Tablosu";
            this.skorTablosuToolStripMenuItem.Click += new System.EventHandler(this.skorTablosuToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.HakkindaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.CikisToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.69231F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.30769F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.69231F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.30769F));
            this.tableLayoutPanel1.Controls.Add(this.lblKalanSureBoard, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMayinSayisiBoard, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSkorBoard, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTemizAlanBoard, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTemizAlan, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMayinSayisi, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblKalansure, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSkor, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(271, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(346, 47);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Visible = false;
            // 
            // lblKalanSureBoard
            // 
            this.lblKalanSureBoard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKalanSureBoard.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblKalanSureBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKalanSureBoard.Font = new System.Drawing.Font("Let\'s go Digital", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKalanSureBoard.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblKalanSureBoard.Location = new System.Drawing.Point(115, 1);
            this.lblKalanSureBoard.Margin = new System.Windows.Forms.Padding(0);
            this.lblKalanSureBoard.Name = "lblKalanSureBoard";
            this.lblKalanSureBoard.Size = new System.Drawing.Size(55, 21);
            this.lblKalanSureBoard.TabIndex = 2;
            this.lblKalanSureBoard.Text = "00:00";
            this.lblKalanSureBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMayinSayisiBoard
            // 
            this.lblMayinSayisiBoard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMayinSayisiBoard.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblMayinSayisiBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMayinSayisiBoard.Font = new System.Drawing.Font("Let\'s go Digital", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayinSayisiBoard.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblMayinSayisiBoard.Location = new System.Drawing.Point(288, 24);
            this.lblMayinSayisiBoard.Margin = new System.Windows.Forms.Padding(0);
            this.lblMayinSayisiBoard.Name = "lblMayinSayisiBoard";
            this.lblMayinSayisiBoard.Size = new System.Drawing.Size(55, 22);
            this.lblMayinSayisiBoard.TabIndex = 2;
            this.lblMayinSayisiBoard.Text = "9999";
            this.lblMayinSayisiBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSkorBoard
            // 
            this.lblSkorBoard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSkorBoard.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblSkorBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSkorBoard.Font = new System.Drawing.Font("Let\'s go Digital", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkorBoard.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblSkorBoard.Location = new System.Drawing.Point(115, 24);
            this.lblSkorBoard.Margin = new System.Windows.Forms.Padding(0);
            this.lblSkorBoard.Name = "lblSkorBoard";
            this.lblSkorBoard.Size = new System.Drawing.Size(55, 22);
            this.lblSkorBoard.TabIndex = 2;
            this.lblSkorBoard.Text = "9999";
            this.lblSkorBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemizAlanBoard
            // 
            this.lblTemizAlanBoard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTemizAlanBoard.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblTemizAlanBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTemizAlanBoard.Font = new System.Drawing.Font("Let\'s go Digital", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemizAlanBoard.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblTemizAlanBoard.Location = new System.Drawing.Point(288, 0);
            this.lblTemizAlanBoard.Margin = new System.Windows.Forms.Padding(0);
            this.lblTemizAlanBoard.Name = "lblTemizAlanBoard";
            this.lblTemizAlanBoard.Size = new System.Drawing.Size(55, 22);
            this.lblTemizAlanBoard.TabIndex = 2;
            this.lblTemizAlanBoard.Text = "9999";
            this.lblTemizAlanBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemizAlan
            // 
            this.lblTemizAlan.AutoSize = true;
            this.lblTemizAlan.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTemizAlan.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTemizAlan.Location = new System.Drawing.Point(205, 0);
            this.lblTemizAlan.Name = "lblTemizAlan";
            this.lblTemizAlan.Size = new System.Drawing.Size(77, 23);
            this.lblTemizAlan.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblTemizAlan.TabIndex = 2;
            this.lblTemizAlan.Text = "Temiz Alan:";
            this.lblTemizAlan.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblTemizAlan.UseCustomForeColor = true;
            // 
            // lblMayinSayisi
            // 
            this.lblMayinSayisi.AutoSize = true;
            this.lblMayinSayisi.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMayinSayisi.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblMayinSayisi.Location = new System.Drawing.Point(195, 23);
            this.lblMayinSayisi.Name = "lblMayinSayisi";
            this.lblMayinSayisi.Size = new System.Drawing.Size(87, 24);
            this.lblMayinSayisi.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblMayinSayisi.TabIndex = 2;
            this.lblMayinSayisi.Text = "Mayın Sayısı:";
            this.lblMayinSayisi.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblMayinSayisi.UseCustomForeColor = true;
            // 
            // lblKalansure
            // 
            this.lblKalansure.AutoSize = true;
            this.lblKalansure.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblKalansure.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblKalansure.Location = new System.Drawing.Point(34, 0);
            this.lblKalansure.Name = "lblKalansure";
            this.lblKalansure.Size = new System.Drawing.Size(76, 23);
            this.lblKalansure.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblKalansure.TabIndex = 2;
            this.lblKalansure.Text = "Kalan Süre:";
            this.lblKalansure.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblKalansure.UseCustomForeColor = true;
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSkor.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblSkor.Location = new System.Drawing.Point(71, 23);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(39, 24);
            this.lblSkor.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblSkor.TabIndex = 2;
            this.lblSkor.Text = "Skor:";
            this.lblSkor.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSkor.UseCustomForeColor = true;
            // 
            // titleBaslikAltCizgi
            // 
            this.titleBaslikAltCizgi.ActiveControl = null;
            this.titleBaslikAltCizgi.Location = new System.Drawing.Point(23, 173);
            this.titleBaslikAltCizgi.Margin = new System.Windows.Forms.Padding(0);
            this.titleBaslikAltCizgi.Name = "titleBaslikAltCizgi";
            this.titleBaslikAltCizgi.Size = new System.Drawing.Size(594, 3);
            this.titleBaslikAltCizgi.Style = MetroFramework.MetroColorStyle.Lime;
            this.titleBaslikAltCizgi.TabIndex = 15;
            this.titleBaslikAltCizgi.Text = "metroTile1";
            this.titleBaslikAltCizgi.UseSelectable = true;
            // 
            // lblTakmaIsım
            // 
            this.lblTakmaIsım.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTakmaIsım.AutoSize = true;
            this.lblTakmaIsım.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTakmaIsım.Location = new System.Drawing.Point(21, -1);
            this.lblTakmaIsım.Name = "lblTakmaIsım";
            this.lblTakmaIsım.Size = new System.Drawing.Size(76, 19);
            this.lblTakmaIsım.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblTakmaIsım.TabIndex = 5;
            this.lblTakmaIsım.Text = "Takma isim:";
            this.lblTakmaIsım.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtBxTakmaIsim
            // 
            this.txtBxTakmaIsim.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtBxTakmaIsim.CustomButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.txtBxTakmaIsim.CustomButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtBxTakmaIsim.CustomButton.Image = null;
            this.txtBxTakmaIsim.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.txtBxTakmaIsim.CustomButton.Name = "";
            this.txtBxTakmaIsim.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBxTakmaIsim.CustomButton.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtBxTakmaIsim.CustomButton.TabIndex = 1;
            this.txtBxTakmaIsim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBxTakmaIsim.CustomButton.UseCustomBackColor = true;
            this.txtBxTakmaIsim.CustomButton.UseCustomForeColor = true;
            this.txtBxTakmaIsim.CustomButton.UseSelectable = true;
            this.txtBxTakmaIsim.CustomButton.UseStyleColors = true;
            this.txtBxTakmaIsim.CustomButton.UseVisualStyleBackColor = true;
            this.txtBxTakmaIsim.CustomButton.Visible = false;
            this.txtBxTakmaIsim.IconRight = true;
            this.txtBxTakmaIsim.Lines = new string[0];
            this.txtBxTakmaIsim.Location = new System.Drawing.Point(21, 21);
            this.txtBxTakmaIsim.MaxLength = 35;
            this.txtBxTakmaIsim.Name = "txtBxTakmaIsim";
            this.txtBxTakmaIsim.PasswordChar = '\0';
            this.txtBxTakmaIsim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBxTakmaIsim.SelectedText = "";
            this.txtBxTakmaIsim.SelectionLength = 0;
            this.txtBxTakmaIsim.SelectionStart = 0;
            this.txtBxTakmaIsim.ShortcutsEnabled = false;
            this.txtBxTakmaIsim.Size = new System.Drawing.Size(175, 23);
            this.txtBxTakmaIsim.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtBxTakmaIsim.TabIndex = 1;
            this.txtBxTakmaIsim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxTakmaIsim.UseSelectable = true;
            this.txtBxTakmaIsim.UseStyleColors = true;
            this.txtBxTakmaIsim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBxTakmaIsim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBxTakmaIsim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBxTakmaIsim_KeyDown);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBaslat.Location = new System.Drawing.Point(21, 53);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(175, 28);
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseSelectable = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // flwPnlGameLvl
            // 
            this.flwPnlGameLvl.Controls.Add(this.lblKolay);
            this.flwPnlGameLvl.Controls.Add(this.toggleKolay);
            this.flwPnlGameLvl.Controls.Add(this.lblOrta);
            this.flwPnlGameLvl.Controls.Add(this.toggleOrta);
            this.flwPnlGameLvl.Controls.Add(this.lblZor);
            this.flwPnlGameLvl.Controls.Add(this.toggleZor);
            this.flwPnlGameLvl.Location = new System.Drawing.Point(471, 84);
            this.flwPnlGameLvl.Name = "flwPnlGameLvl";
            this.flwPnlGameLvl.Size = new System.Drawing.Size(119, 68);
            this.flwPnlGameLvl.TabIndex = 22;
            // 
            // lblKolay
            // 
            this.lblKolay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKolay.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblKolay.Location = new System.Drawing.Point(3, 2);
            this.lblKolay.Name = "lblKolay";
            this.lblKolay.Size = new System.Drawing.Size(45, 19);
            this.lblKolay.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblKolay.TabIndex = 5;
            this.lblKolay.Text = "Kolay:";
            this.lblKolay.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblKolay.UseCustomForeColor = true;
            // 
            // toggleKolay
            // 
            this.toggleKolay.AutoSize = true;
            this.toggleKolay.Checked = true;
            this.toggleKolay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleKolay.DisplayFocus = true;
            this.toggleKolay.DisplayStatus = false;
            this.toggleKolay.Location = new System.Drawing.Point(54, 3);
            this.toggleKolay.Name = "toggleKolay";
            this.toggleKolay.Size = new System.Drawing.Size(50, 17);
            this.toggleKolay.Style = MetroFramework.MetroColorStyle.Lime;
            this.toggleKolay.TabIndex = 1;
            this.toggleKolay.TabStop = false;
            this.toggleKolay.Text = "On";
            this.toggleKolay.Theme = this.Theme;
            this.toggleKolay.UseCustomBackColor = true;
            this.toggleKolay.UseCustomForeColor = true;
            this.toggleKolay.UseSelectable = true;
            this.toggleKolay.UseStyleColors = true;
            this.toggleKolay.Click += new System.EventHandler(this.metroToggle1_Click);
            // 
            // lblOrta
            // 
            this.lblOrta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrta.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblOrta.Location = new System.Drawing.Point(3, 25);
            this.lblOrta.Name = "lblOrta";
            this.lblOrta.Size = new System.Drawing.Size(45, 19);
            this.lblOrta.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblOrta.TabIndex = 5;
            this.lblOrta.Text = "Orta:";
            this.lblOrta.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblOrta.UseCustomForeColor = true;
            // 
            // toggleOrta
            // 
            this.toggleOrta.AutoSize = true;
            this.toggleOrta.DisplayFocus = true;
            this.toggleOrta.DisplayStatus = false;
            this.toggleOrta.Location = new System.Drawing.Point(54, 26);
            this.toggleOrta.Name = "toggleOrta";
            this.toggleOrta.Size = new System.Drawing.Size(50, 17);
            this.toggleOrta.Style = MetroFramework.MetroColorStyle.Lime;
            this.toggleOrta.TabIndex = 1;
            this.toggleOrta.TabStop = false;
            this.toggleOrta.Text = "Off";
            this.toggleOrta.UseSelectable = true;
            this.toggleOrta.Click += new System.EventHandler(this.metroToggle2_Click);
            // 
            // lblZor
            // 
            this.lblZor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblZor.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblZor.Location = new System.Drawing.Point(3, 48);
            this.lblZor.Name = "lblZor";
            this.lblZor.Size = new System.Drawing.Size(45, 19);
            this.lblZor.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblZor.TabIndex = 5;
            this.lblZor.Text = "Zor:";
            this.lblZor.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblZor.UseCustomForeColor = true;
            // 
            // toggleZor
            // 
            this.toggleZor.AutoSize = true;
            this.toggleZor.DisplayFocus = true;
            this.toggleZor.DisplayStatus = false;
            this.flwPnlGameLvl.SetFlowBreak(this.toggleZor, true);
            this.toggleZor.Location = new System.Drawing.Point(54, 49);
            this.toggleZor.Name = "toggleZor";
            this.toggleZor.Size = new System.Drawing.Size(50, 17);
            this.toggleZor.Style = MetroFramework.MetroColorStyle.Lime;
            this.toggleZor.TabIndex = 1;
            this.toggleZor.TabStop = false;
            this.toggleZor.Text = "Off";
            this.toggleZor.UseSelectable = true;
            this.toggleZor.Click += new System.EventHandler(this.metroToggle3_Click);
            // 
            // pnlTakmaIsimBaslat
            // 
            this.pnlTakmaIsimBaslat.Controls.Add(this.btnBaslat);
            this.pnlTakmaIsimBaslat.Controls.Add(this.txtBxTakmaIsim);
            this.pnlTakmaIsimBaslat.Controls.Add(this.lblTakmaIsım);
            this.pnlTakmaIsimBaslat.Location = new System.Drawing.Point(212, 71);
            this.pnlTakmaIsimBaslat.Name = "pnlTakmaIsimBaslat";
            this.pnlTakmaIsimBaslat.Size = new System.Drawing.Size(216, 99);
            this.pnlTakmaIsimBaslat.TabIndex = 23;
            // 
            // pnlConsole
            // 
            this.pnlConsole.BackColor = System.Drawing.Color.Transparent;
            this.pnlConsole.Controls.Add(this.richTextBox1);
            this.pnlConsole.Controls.Add(this.consoleTxtBx);
            this.pnlConsole.Location = new System.Drawing.Point(0, -400);
            this.pnlConsole.Margin = new System.Windows.Forms.Padding(0);
            this.pnlConsole.Name = "pnlConsole";
            this.pnlConsole.Size = new System.Drawing.Size(501, 400);
            this.pnlConsole.TabIndex = 26;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.ForeColor = System.Drawing.Color.LawnGreen;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(501, 385);
            this.richTextBox1.TabIndex = 27;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            // 
            // consoleTxtBx
            // 
            this.consoleTxtBx.BackColor = System.Drawing.SystemColors.InfoText;
            this.consoleTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleTxtBx.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.consoleTxtBx.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.consoleTxtBx.ForeColor = System.Drawing.Color.DarkOrange;
            this.consoleTxtBx.Location = new System.Drawing.Point(0, 385);
            this.consoleTxtBx.Margin = new System.Windows.Forms.Padding(0);
            this.consoleTxtBx.MaxLength = 140;
            this.consoleTxtBx.Name = "consoleTxtBx";
            this.consoleTxtBx.Size = new System.Drawing.Size(501, 15);
            this.consoleTxtBx.TabIndex = 26;
            this.consoleTxtBx.WordWrap = false;
            this.consoleTxtBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConsoleTextBox_KeyDown);
            this.consoleTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.consoleTxtBx_KeyPress);
            // 
            // pnlGameMap
            // 
            this.pnlGameMap.Location = new System.Drawing.Point(23, 187);
            this.pnlGameMap.Margin = new System.Windows.Forms.Padding(0);
            this.pnlGameMap.Name = "pnlGameMap";
            this.pnlGameMap.Size = new System.Drawing.Size(102, 66);
            this.pnlGameMap.TabIndex = 9;
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMenu.Location = new System.Drawing.Point(23, 71);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 17);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseSelectable = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // AnaForm
            // 
            this.AccessibleName = "fatihertugral89@gmail.com";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 196);
            this.Controls.Add(this.pnlConsole);
            this.Controls.Add(this.pnlTakmaIsimBaslat);
            this.Controls.Add(this.flwPnlGameLvl);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.titleBaslikAltCizgi);
            this.Controls.Add(this.pnlGameMap);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 196);
            this.Name = "AnaForm";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Mayın Tarlası";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TransparencyKey = System.Drawing.Color.LavenderBlush;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AnaForm_KeyPress);
            this.Menu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flwPnlGameLvl.ResumeLayout(false);
            this.flwPnlGameLvl.PerformLayout();
            this.pnlTakmaIsimBaslat.ResumeLayout(false);
            this.pnlTakmaIsimBaslat.PerformLayout();
            this.pnlConsole.ResumeLayout(false);
            this.pnlConsole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlGameMap;
        private new MetroFramework.Controls.MetroContextMenu Menu;
        private System.Windows.Forms.ToolStripMenuItem yeniOyunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSkorBoard;
        private MetroFramework.Controls.MetroLabel lblKalansure;
        private MetroFramework.Controls.MetroLabel lblTemizAlan;
        private System.Windows.Forms.Label lblKalanSureBoard;
        private System.Windows.Forms.Label lblMayinSayisiBoard;
        private MetroFramework.Controls.MetroLabel lblMayinSayisi;
        private System.Windows.Forms.Label lblTemizAlanBoard;
        private MetroFramework.Controls.MetroLabel lblSkor;
        private MetroFramework.Controls.MetroTile titleBaslikAltCizgi;
        private MetroFramework.Controls.MetroLabel lblTakmaIsım;
        private MetroFramework.Controls.MetroTextBox txtBxTakmaIsim;
        private MetroFramework.Controls.MetroButton btnBaslat;
        private System.Windows.Forms.FlowLayoutPanel flwPnlGameLvl;
        private MetroFramework.Controls.MetroLabel lblKolay;
        private MetroFramework.Controls.MetroToggle toggleKolay;
        private System.Windows.Forms.Panel pnlTakmaIsimBaslat;
        private MetroFramework.Controls.MetroLabel lblOrta;
        private MetroFramework.Controls.MetroToggle toggleOrta;
        private MetroFramework.Controls.MetroLabel lblZor;
        private MetroFramework.Controls.MetroToggle toggleZor;
        private System.Windows.Forms.ToolStripMenuItem skorTablosuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.Panel pnlConsole;
        private System.Windows.Forms.TextBox consoleTxtBx;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MetroFramework.Controls.MetroButton btnMenu;
    }
}

