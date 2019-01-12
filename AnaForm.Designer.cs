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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
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
            this.lblSkor = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblKalansure = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnMenu = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtBxTakmaIsim = new MetroFramework.Controls.MetroTextBox();
            this.btnBaslat = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroToggle2 = new MetroFramework.Controls.MetroToggle();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroToggle3 = new MetroFramework.Controls.MetroToggle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.pnlConsole = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.consoleTxtBx = new System.Windows.Forms.TextBox();
            this.Menu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlConsole.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 187);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(102, 66);
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
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
            this.tableLayoutPanel1.Controls.Add(this.lblSkor, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblKalansure, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(135, 3);
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
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSkor.Location = new System.Drawing.Point(207, 0);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(75, 23);
            this.lblSkor.TabIndex = 2;
            this.lblSkor.Text = "Temiz Alan:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroLabel1.Location = new System.Drawing.Point(200, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 24);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Mayın Sayısı:";
            // 
            // lblKalansure
            // 
            this.lblKalansure.AutoSize = true;
            this.lblKalansure.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblKalansure.Location = new System.Drawing.Point(37, 0);
            this.lblKalansure.Name = "lblKalansure";
            this.lblKalansure.Size = new System.Drawing.Size(73, 23);
            this.lblKalansure.TabIndex = 2;
            this.lblKalansure.Text = "Kalan Süre:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroLabel2.Location = new System.Drawing.Point(71, 23);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 24);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Skor:";
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMenu.Location = new System.Drawing.Point(3, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 17);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseSelectable = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.1715F));
            this.tableLayoutPanel2.Controls.Add(this.btnMenu, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 69);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.75961F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(484, 67);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(23, 173);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(0);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(484, 3);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTile1.TabIndex = 15;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(21, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(76, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Takma isim:";
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
            this.txtBxTakmaIsim.Location = new System.Drawing.Point(21, 22);
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
            this.btnBaslat.Location = new System.Drawing.Point(21, 54);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(175, 28);
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseSelectable = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.metroLabel3);
            this.flowLayoutPanel2.Controls.Add(this.metroToggle1);
            this.flowLayoutPanel2.Controls.Add(this.metroLabel4);
            this.flowLayoutPanel2.Controls.Add(this.metroToggle2);
            this.flowLayoutPanel2.Controls.Add(this.metroLabel6);
            this.flowLayoutPanel2.Controls.Add(this.metroToggle3);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(388, 91);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(119, 68);
            this.flowLayoutPanel2.TabIndex = 22;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.Location = new System.Drawing.Point(3, 2);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Kolay:";
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Checked = true;
            this.metroToggle1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroToggle1.DisplayFocus = true;
            this.metroToggle1.DisplayStatus = false;
            this.metroToggle1.Location = new System.Drawing.Point(54, 3);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(50, 17);
            this.metroToggle1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroToggle1.TabIndex = 1;
            this.metroToggle1.TabStop = false;
            this.metroToggle1.Text = "On";
            this.metroToggle1.Theme = this.Theme;
            this.metroToggle1.UseCustomBackColor = true;
            this.metroToggle1.UseCustomForeColor = true;
            this.metroToggle1.UseSelectable = true;
            this.metroToggle1.UseStyleColors = true;
            this.metroToggle1.Click += new System.EventHandler(this.metroToggle1_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel4.Location = new System.Drawing.Point(3, 25);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(45, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Orta:";
            // 
            // metroToggle2
            // 
            this.metroToggle2.AutoSize = true;
            this.metroToggle2.DisplayFocus = true;
            this.metroToggle2.DisplayStatus = false;
            this.metroToggle2.Location = new System.Drawing.Point(54, 26);
            this.metroToggle2.Name = "metroToggle2";
            this.metroToggle2.Size = new System.Drawing.Size(50, 17);
            this.metroToggle2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroToggle2.TabIndex = 1;
            this.metroToggle2.TabStop = false;
            this.metroToggle2.Text = "Off";
            this.metroToggle2.UseSelectable = true;
            this.metroToggle2.Click += new System.EventHandler(this.metroToggle2_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel6.Location = new System.Drawing.Point(3, 48);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(45, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Zor:";
            // 
            // metroToggle3
            // 
            this.metroToggle3.AutoSize = true;
            this.metroToggle3.DisplayFocus = true;
            this.metroToggle3.DisplayStatus = false;
            this.flowLayoutPanel2.SetFlowBreak(this.metroToggle3, true);
            this.metroToggle3.Location = new System.Drawing.Point(54, 49);
            this.metroToggle3.Name = "metroToggle3";
            this.metroToggle3.Size = new System.Drawing.Size(50, 17);
            this.metroToggle3.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroToggle3.TabIndex = 1;
            this.metroToggle3.TabStop = false;
            this.metroToggle3.Text = "Off";
            this.metroToggle3.UseSelectable = true;
            this.metroToggle3.Click += new System.EventHandler(this.metroToggle3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBaslat);
            this.panel1.Controls.Add(this.txtBxTakmaIsim);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Location = new System.Drawing.Point(159, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 100);
            this.panel1.TabIndex = 23;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(23, 131);
            this.metroTile2.Margin = new System.Windows.Forms.Padding(0);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(484, 3);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTile2.TabIndex = 24;
            this.metroTile2.Text = "metroTile2";
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Visible = false;
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
            // AnaForm
            // 
            this.AccessibleName = "fatihertugral89@gmail.com";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 196);
            this.Controls.Add(this.pnlConsole);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(530, 196);
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
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlConsole.ResumeLayout(false);
            this.pnlConsole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private new MetroFramework.Controls.MetroContextMenu Menu;
        private System.Windows.Forms.ToolStripMenuItem yeniOyunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSkorBoard;
        private MetroFramework.Controls.MetroLabel lblKalansure;
        private MetroFramework.Controls.MetroLabel lblSkor;
        private System.Windows.Forms.Label lblKalanSureBoard;
        private MetroFramework.Controls.MetroButton btnMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblMayinSayisiBoard;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label lblTemizAlanBoard;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtBxTakmaIsim;
        private MetroFramework.Controls.MetroButton btnBaslat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroToggle metroToggle2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroToggle metroToggle3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.ToolStripMenuItem skorTablosuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.Panel pnlConsole;
        private System.Windows.Forms.TextBox consoleTxtBx;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

