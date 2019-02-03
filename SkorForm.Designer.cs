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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataGridSkor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSkor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridSkor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridSkor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridSkor.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridSkor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSkor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridSkor.ColumnHeadersHeight = 25;
            this.dataGridSkor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridSkor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oyuncuAdiDataGridViewTextBoxColumn,
            this.oyuncuSkorDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.dataGridSkor.DataSource = this.puanlamaBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSkor.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridSkor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSkor.EnableHeadersVisualStyles = false;
            this.dataGridSkor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridSkor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridSkor.Location = new System.Drawing.Point(1, 1);
            this.dataGridSkor.MultiSelect = false;
            this.dataGridSkor.Name = "dataGridSkor";
            this.dataGridSkor.ReadOnly = true;
            this.dataGridSkor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSkor.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridSkor.RowHeadersVisible = false;
            this.dataGridSkor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridSkor.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridSkor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridSkor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSkor.Size = new System.Drawing.Size(453, 114);
            this.dataGridSkor.Style = MetroFramework.MetroColorStyle.Lime;
            this.dataGridSkor.TabIndex = 0;
            this.dataGridSkor.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dataGridSkor.UseCustomForeColor = true;
            // 
            // oyuncuAdiDataGridViewTextBoxColumn
            // 
            this.oyuncuAdiDataGridViewTextBoxColumn.DataPropertyName = "oyuncuAdi";
            this.oyuncuAdiDataGridViewTextBoxColumn.HeaderText = "OYUNCU";
            this.oyuncuAdiDataGridViewTextBoxColumn.Name = "oyuncuAdiDataGridViewTextBoxColumn";
            this.oyuncuAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oyuncuSkorDataGridViewTextBoxColumn
            // 
            this.oyuncuSkorDataGridViewTextBoxColumn.DataPropertyName = "oyuncuSkor";
            this.oyuncuSkorDataGridViewTextBoxColumn.HeaderText = "SKOR";
            this.oyuncuSkorDataGridViewTextBoxColumn.Name = "oyuncuSkorDataGridViewTextBoxColumn";
            this.oyuncuSkorDataGridViewTextBoxColumn.ReadOnly = true;
            this.oyuncuSkorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "TARIH";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LawnGreen;
            this.panel1.Controls.Add(this.dataGridSkor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 30);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(455, 116);
            this.panel1.TabIndex = 1;
            // 
            // SkorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(475, 166);
            this.Controls.Add(this.panel1);
            this.DisplayHeader = false;
            this.DoubleBuffered = false;
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SkorForm";
            this.Padding = new System.Windows.Forms.Padding(10, 30, 10, 20);
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Green;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn oyuncuAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oyuncuSkorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
    }
}