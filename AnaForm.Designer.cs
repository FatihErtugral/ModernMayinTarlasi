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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
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
            resources.ApplyResources(this.Menu, "Menu");
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniOyunToolStripMenuItem,
            this.skorTablosuToolStripMenuItem,
            this.hakkındaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.Menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.Menu.Name = "Menu";
            this.Menu.UseCustomBackColor = true;
            this.Menu.UseCustomForeColor = true;
            this.Menu.UseStyleColors = true;
            // 
            // yeniOyunToolStripMenuItem
            // 
            resources.ApplyResources(this.yeniOyunToolStripMenuItem, "yeniOyunToolStripMenuItem");
            this.yeniOyunToolStripMenuItem.Name = "yeniOyunToolStripMenuItem";
            this.yeniOyunToolStripMenuItem.Click += new System.EventHandler(this.yeniOyunToolStripMenuItem_Click);
            // 
            // skorTablosuToolStripMenuItem
            // 
            resources.ApplyResources(this.skorTablosuToolStripMenuItem, "skorTablosuToolStripMenuItem");
            this.skorTablosuToolStripMenuItem.Name = "skorTablosuToolStripMenuItem";
            this.skorTablosuToolStripMenuItem.Click += new System.EventHandler(this.skorTablosuToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            resources.ApplyResources(this.hakkındaToolStripMenuItem, "hakkındaToolStripMenuItem");
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.HakkindaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            resources.ApplyResources(this.çıkışToolStripMenuItem, "çıkışToolStripMenuItem");
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.CikisToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.lblKalanSureBoard, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMayinSayisiBoard, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSkorBoard, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTemizAlanBoard, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTemizAlan, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMayinSayisi, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblKalansure, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSkor, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // lblKalanSureBoard
            // 
            resources.ApplyResources(this.lblKalanSureBoard, "lblKalanSureBoard");
            this.lblKalanSureBoard.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblKalanSureBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKalanSureBoard.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblKalanSureBoard.Name = "lblKalanSureBoard";
            // 
            // lblMayinSayisiBoard
            // 
            resources.ApplyResources(this.lblMayinSayisiBoard, "lblMayinSayisiBoard");
            this.lblMayinSayisiBoard.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblMayinSayisiBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMayinSayisiBoard.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblMayinSayisiBoard.Name = "lblMayinSayisiBoard";
            // 
            // lblSkorBoard
            // 
            resources.ApplyResources(this.lblSkorBoard, "lblSkorBoard");
            this.lblSkorBoard.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblSkorBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSkorBoard.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblSkorBoard.Name = "lblSkorBoard";
            // 
            // lblTemizAlanBoard
            // 
            resources.ApplyResources(this.lblTemizAlanBoard, "lblTemizAlanBoard");
            this.lblTemizAlanBoard.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblTemizAlanBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTemizAlanBoard.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblTemizAlanBoard.Name = "lblTemizAlanBoard";
            // 
            // lblTemizAlan
            // 
            resources.ApplyResources(this.lblTemizAlan, "lblTemizAlan");
            this.lblTemizAlan.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTemizAlan.Name = "lblTemizAlan";
            this.lblTemizAlan.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblTemizAlan.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblTemizAlan.UseCustomForeColor = true;
            // 
            // lblMayinSayisi
            // 
            resources.ApplyResources(this.lblMayinSayisi, "lblMayinSayisi");
            this.lblMayinSayisi.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblMayinSayisi.Name = "lblMayinSayisi";
            this.lblMayinSayisi.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblMayinSayisi.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblMayinSayisi.UseCustomForeColor = true;
            // 
            // lblKalansure
            // 
            resources.ApplyResources(this.lblKalansure, "lblKalansure");
            this.lblKalansure.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblKalansure.Name = "lblKalansure";
            this.lblKalansure.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblKalansure.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblKalansure.UseCustomForeColor = true;
            // 
            // lblSkor
            // 
            resources.ApplyResources(this.lblSkor, "lblSkor");
            this.lblSkor.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblSkor.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSkor.UseCustomForeColor = true;
            // 
            // titleBaslikAltCizgi
            // 
            resources.ApplyResources(this.titleBaslikAltCizgi, "titleBaslikAltCizgi");
            this.titleBaslikAltCizgi.ActiveControl = null;
            this.titleBaslikAltCizgi.Name = "titleBaslikAltCizgi";
            this.titleBaslikAltCizgi.Style = MetroFramework.MetroColorStyle.Lime;
            this.titleBaslikAltCizgi.UseSelectable = true;
            // 
            // lblTakmaIsım
            // 
            resources.ApplyResources(this.lblTakmaIsım, "lblTakmaIsım");
            this.lblTakmaIsım.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTakmaIsım.Name = "lblTakmaIsım";
            this.lblTakmaIsım.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblTakmaIsım.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtBxTakmaIsim
            // 
            resources.ApplyResources(this.txtBxTakmaIsim, "txtBxTakmaIsim");
            // 
            // 
            // 
            this.txtBxTakmaIsim.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription");
            this.txtBxTakmaIsim.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName");
            this.txtBxTakmaIsim.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor")));
            this.txtBxTakmaIsim.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize")));
            this.txtBxTakmaIsim.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode")));
            this.txtBxTakmaIsim.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage")));
            this.txtBxTakmaIsim.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout")));
            this.txtBxTakmaIsim.CustomButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.txtBxTakmaIsim.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock")));
            this.txtBxTakmaIsim.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle")));
            this.txtBxTakmaIsim.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font")));
            this.txtBxTakmaIsim.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtBxTakmaIsim.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign")));
            this.txtBxTakmaIsim.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex")));
            this.txtBxTakmaIsim.CustomButton.ImageKey = resources.GetString("resource.ImageKey");
            this.txtBxTakmaIsim.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.txtBxTakmaIsim.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.txtBxTakmaIsim.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize")));
            this.txtBxTakmaIsim.CustomButton.Name = "";
            this.txtBxTakmaIsim.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft")));
            this.txtBxTakmaIsim.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.txtBxTakmaIsim.CustomButton.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtBxTakmaIsim.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.txtBxTakmaIsim.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign")));
            this.txtBxTakmaIsim.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation")));
            this.txtBxTakmaIsim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBxTakmaIsim.CustomButton.UseCustomBackColor = true;
            this.txtBxTakmaIsim.CustomButton.UseCustomForeColor = true;
            this.txtBxTakmaIsim.CustomButton.UseSelectable = true;
            this.txtBxTakmaIsim.CustomButton.UseStyleColors = true;
            this.txtBxTakmaIsim.CustomButton.UseVisualStyleBackColor = true;
            this.txtBxTakmaIsim.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.txtBxTakmaIsim.IconRight = true;
            this.txtBxTakmaIsim.Lines = new string[0];
            this.txtBxTakmaIsim.MaxLength = 35;
            this.txtBxTakmaIsim.Name = "txtBxTakmaIsim";
            this.txtBxTakmaIsim.PasswordChar = '\0';
            this.txtBxTakmaIsim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBxTakmaIsim.SelectedText = "";
            this.txtBxTakmaIsim.SelectionLength = 0;
            this.txtBxTakmaIsim.SelectionStart = 0;
            this.txtBxTakmaIsim.ShortcutsEnabled = false;
            this.txtBxTakmaIsim.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtBxTakmaIsim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxTakmaIsim.UseSelectable = true;
            this.txtBxTakmaIsim.UseStyleColors = true;
            this.txtBxTakmaIsim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBxTakmaIsim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBxTakmaIsim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBxTakmaIsim_KeyDown);
            // 
            // btnBaslat
            // 
            resources.ApplyResources(this.btnBaslat, "btnBaslat");
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.UseSelectable = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // flwPnlGameLvl
            // 
            resources.ApplyResources(this.flwPnlGameLvl, "flwPnlGameLvl");
            this.flwPnlGameLvl.Controls.Add(this.lblKolay);
            this.flwPnlGameLvl.Controls.Add(this.toggleKolay);
            this.flwPnlGameLvl.Controls.Add(this.lblOrta);
            this.flwPnlGameLvl.Controls.Add(this.toggleOrta);
            this.flwPnlGameLvl.Controls.Add(this.lblZor);
            this.flwPnlGameLvl.Controls.Add(this.toggleZor);
            this.flwPnlGameLvl.Name = "flwPnlGameLvl";
            // 
            // lblKolay
            // 
            resources.ApplyResources(this.lblKolay, "lblKolay");
            this.lblKolay.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblKolay.Name = "lblKolay";
            this.lblKolay.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblKolay.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblKolay.UseCustomForeColor = true;
            // 
            // toggleKolay
            // 
            resources.ApplyResources(this.toggleKolay, "toggleKolay");
            this.toggleKolay.Checked = true;
            this.toggleKolay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleKolay.DisplayFocus = true;
            this.toggleKolay.DisplayStatus = false;
            this.toggleKolay.Name = "toggleKolay";
            this.toggleKolay.Style = MetroFramework.MetroColorStyle.Lime;
            this.toggleKolay.TabStop = false;
            this.toggleKolay.Theme = this.Theme;
            this.toggleKolay.UseCustomBackColor = true;
            this.toggleKolay.UseCustomForeColor = true;
            this.toggleKolay.UseSelectable = true;
            this.toggleKolay.UseStyleColors = true;
            this.toggleKolay.Click += new System.EventHandler(this.metroToggle1_Click);
            // 
            // lblOrta
            // 
            resources.ApplyResources(this.lblOrta, "lblOrta");
            this.lblOrta.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblOrta.Name = "lblOrta";
            this.lblOrta.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblOrta.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblOrta.UseCustomForeColor = true;
            // 
            // toggleOrta
            // 
            resources.ApplyResources(this.toggleOrta, "toggleOrta");
            this.toggleOrta.DisplayFocus = true;
            this.toggleOrta.DisplayStatus = false;
            this.toggleOrta.Name = "toggleOrta";
            this.toggleOrta.Style = MetroFramework.MetroColorStyle.Lime;
            this.toggleOrta.TabStop = false;
            this.toggleOrta.UseSelectable = true;
            this.toggleOrta.Click += new System.EventHandler(this.metroToggle2_Click);
            // 
            // lblZor
            // 
            resources.ApplyResources(this.lblZor, "lblZor");
            this.lblZor.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblZor.Name = "lblZor";
            this.lblZor.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblZor.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblZor.UseCustomForeColor = true;
            // 
            // toggleZor
            // 
            resources.ApplyResources(this.toggleZor, "toggleZor");
            this.toggleZor.DisplayFocus = true;
            this.toggleZor.DisplayStatus = false;
            this.flwPnlGameLvl.SetFlowBreak(this.toggleZor, true);
            this.toggleZor.Name = "toggleZor";
            this.toggleZor.Style = MetroFramework.MetroColorStyle.Lime;
            this.toggleZor.TabStop = false;
            this.toggleZor.UseSelectable = true;
            this.toggleZor.Click += new System.EventHandler(this.metroToggle3_Click);
            // 
            // pnlTakmaIsimBaslat
            // 
            resources.ApplyResources(this.pnlTakmaIsimBaslat, "pnlTakmaIsimBaslat");
            this.pnlTakmaIsimBaslat.Controls.Add(this.btnBaslat);
            this.pnlTakmaIsimBaslat.Controls.Add(this.txtBxTakmaIsim);
            this.pnlTakmaIsimBaslat.Controls.Add(this.lblTakmaIsım);
            this.pnlTakmaIsimBaslat.Name = "pnlTakmaIsimBaslat";
            // 
            // pnlConsole
            // 
            resources.ApplyResources(this.pnlConsole, "pnlConsole");
            this.pnlConsole.BackColor = System.Drawing.Color.Transparent;
            this.pnlConsole.Controls.Add(this.richTextBox1);
            this.pnlConsole.Controls.Add(this.consoleTxtBx);
            this.pnlConsole.Name = "pnlConsole";
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.LawnGreen;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.TabStop = false;
            // 
            // consoleTxtBx
            // 
            resources.ApplyResources(this.consoleTxtBx, "consoleTxtBx");
            this.consoleTxtBx.BackColor = System.Drawing.SystemColors.InfoText;
            this.consoleTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleTxtBx.ForeColor = System.Drawing.Color.DarkOrange;
            this.consoleTxtBx.Name = "consoleTxtBx";
            this.consoleTxtBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConsoleTextBox_KeyDown);
            this.consoleTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.consoleTxtBx_KeyPress);
            // 
            // pnlGameMap
            // 
            resources.ApplyResources(this.pnlGameMap, "pnlGameMap");
            this.pnlGameMap.Name = "pnlGameMap";
            // 
            // btnMenu
            // 
            resources.ApplyResources(this.btnMenu, "btnMenu");
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.TabStop = false;
            this.btnMenu.UseSelectable = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // AnaForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlConsole);
            this.Controls.Add(this.pnlTakmaIsimBaslat);
            this.Controls.Add(this.flwPnlGameLvl);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.titleBaslikAltCizgi);
            this.Controls.Add(this.pnlGameMap);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AnaForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
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

