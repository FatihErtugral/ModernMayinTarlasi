namespace WindowsFormsApp
{
    partial class SkorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.puanlamaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridSkor = new MetroFramework.Controls.MetroGrid();
            this.oyuncuAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oyuncuSkorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.puanlamaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSkor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // puanlamaBindingSource
            // 
            this.puanlamaBindingSource.DataSource = typeof(WindowsFormsApp.SkorJSonModel.Puanlama);
            this.puanlamaBindingSource.Sort = "oyuncuSkor";
            // 
            // dataGridSkor
            // 
            this.dataGridSkor.AllowUserToAddRows = false;
            this.dataGridSkor.AllowUserToDeleteRows = false;
            this.dataGridSkor.AllowUserToOrderColumns = true;
            this.dataGridSkor.AllowUserToResizeColumns = false;
            this.dataGridSkor.AllowUserToResizeRows = false;
            this.dataGridSkor.AutoGenerateColumns = false;
            this.dataGridSkor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dataGridSkor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridSkor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridSkor.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridSkor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dataGridSkor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridSkor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridSkor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oyuncuAdiDataGridViewTextBoxColumn,
            this.oyuncuSkorDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.dataGridSkor.DataSource = this.puanlamaBindingSource;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSkor.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridSkor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSkor.EnableHeadersVisualStyles = false;
            this.dataGridSkor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridSkor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dataGridSkor.Location = new System.Drawing.Point(1, 1);
            this.dataGridSkor.MultiSelect = false;
            this.dataGridSkor.Name = "dataGridSkor";
            this.dataGridSkor.ReadOnly = true;
            this.dataGridSkor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSkor.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridSkor.RowHeadersVisible = false;
            this.dataGridSkor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Navy;
            this.dataGridSkor.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridSkor.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridSkor.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSkor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridSkor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSkor.Size = new System.Drawing.Size(453, 123);
            this.dataGridSkor.Style = MetroFramework.MetroColorStyle.Silver;
            this.dataGridSkor.TabIndex = 0;
            this.dataGridSkor.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dataGridSkor.UseCustomForeColor = true;
            this.dataGridSkor.UseStyleColors = true;
            // 
            // oyuncuAdiDataGridViewTextBoxColumn
            // 
            this.oyuncuAdiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.oyuncuAdiDataGridViewTextBoxColumn.DataPropertyName = "oyuncuAdi";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.oyuncuAdiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.oyuncuAdiDataGridViewTextBoxColumn.HeaderText = "OYUNCU";
            this.oyuncuAdiDataGridViewTextBoxColumn.Name = "oyuncuAdiDataGridViewTextBoxColumn";
            this.oyuncuAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.oyuncuAdiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.oyuncuAdiDataGridViewTextBoxColumn.Width = 151;
            // 
            // oyuncuSkorDataGridViewTextBoxColumn
            // 
            this.oyuncuSkorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.oyuncuSkorDataGridViewTextBoxColumn.DataPropertyName = "oyuncuSkor";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.oyuncuSkorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.oyuncuSkorDataGridViewTextBoxColumn.HeaderText = "SKOR";
            this.oyuncuSkorDataGridViewTextBoxColumn.Name = "oyuncuSkorDataGridViewTextBoxColumn";
            this.oyuncuSkorDataGridViewTextBoxColumn.ReadOnly = true;
            this.oyuncuSkorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.oyuncuSkorDataGridViewTextBoxColumn.Width = 151;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tarihDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.tarihDataGridViewTextBoxColumn.HeaderText = "TARIH";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            this.tarihDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tarihDataGridViewTextBoxColumn.Width = 151;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.dataGridSkor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(455, 125);
            this.panel1.TabIndex = 1;
            // 
            // SkorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(475, 186);
            this.Controls.Add(this.panel1);
            this.DisplayHeader = false;
            this.DoubleBuffered = false;
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SkorForm";
            this.Opacity = 0.75D;
            this.Padding = new System.Windows.Forms.Padding(10, 41, 10, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.SkyBlue;
            this.Load += new System.EventHandler(this.SkorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.puanlamaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSkor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource puanlamaBindingSource;
        private MetroFramework.Controls.MetroGrid dataGridSkor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oyuncuAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oyuncuSkorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
    }
}