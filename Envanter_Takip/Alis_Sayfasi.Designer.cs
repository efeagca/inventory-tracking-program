namespace Envanter_Takip
{
    partial class Alis_Sayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alis_Sayfasi));
            this.aLIMDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLIMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backPictureBox = new System.Windows.Forms.PictureBox();
            this.printPictureBox = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pdfPictureBox = new System.Windows.Forms.PictureBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.aLIMDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLIMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // aLIMDataGridView
            // 
            this.aLIMDataGridView.AllowUserToAddRows = false;
            this.aLIMDataGridView.AutoGenerateColumns = false;
            this.aLIMDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.aLIMDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.aLIMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aLIMDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.UrunAdi,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.aLIMDataGridView.DataSource = this.aLIMBindingSource;
            this.aLIMDataGridView.Location = new System.Drawing.Point(0, 43);
            this.aLIMDataGridView.MultiSelect = false;
            this.aLIMDataGridView.Name = "aLIMDataGridView";
            this.aLIMDataGridView.ReadOnly = true;
            this.aLIMDataGridView.RowTemplate.Height = 40;
            this.aLIMDataGridView.Size = new System.Drawing.Size(653, 350);
            this.aLIMDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Barkod";
            this.dataGridViewTextBoxColumn2.HeaderText = "Barkod";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // UrunAdi
            // 
            this.UrunAdi.HeaderText = "Ürün Adı";
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Miktar";
            this.dataGridViewTextBoxColumn3.HeaderText = "Miktar";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Birim_Alis_Fiyati";
            this.dataGridViewTextBoxColumn4.HeaderText = "Birim Alış Fiyatı";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tarih";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // aLIMBindingSource
            // 
            this.aLIMBindingSource.DataSource = typeof(Envanter_Database.ALIM);
            // 
            // backPictureBox
            // 
            this.backPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backPictureBox.BackgroundImage")));
            this.backPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backPictureBox.Location = new System.Drawing.Point(12, 8);
            this.backPictureBox.Name = "backPictureBox";
            this.backPictureBox.Size = new System.Drawing.Size(39, 29);
            this.backPictureBox.TabIndex = 5;
            this.backPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.backPictureBox, "Geri");
            this.backPictureBox.Click += new System.EventHandler(this.backPictureBox_Click);
            // 
            // printPictureBox
            // 
            this.printPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("printPictureBox.BackgroundImage")));
            this.printPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.printPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printPictureBox.Location = new System.Drawing.Point(610, 8);
            this.printPictureBox.Name = "printPictureBox";
            this.printPictureBox.Size = new System.Drawing.Size(32, 29);
            this.printPictureBox.TabIndex = 6;
            this.printPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.printPictureBox, "Yazdır");
            this.printPictureBox.Click += new System.EventHandler(this.printPictureBox_Click);
            // 
            // pdfPictureBox
            // 
            this.pdfPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pdfPictureBox.BackgroundImage")));
            this.pdfPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pdfPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pdfPictureBox.Location = new System.Drawing.Point(572, 8);
            this.pdfPictureBox.Name = "pdfPictureBox";
            this.pdfPictureBox.Size = new System.Drawing.Size(32, 29);
            this.pdfPictureBox.TabIndex = 12;
            this.pdfPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.pdfPictureBox, "PDF Dönüştür");
            this.pdfPictureBox.Click += new System.EventHandler(this.pdfPictureBox_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Alis_Sayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 393);
            this.Controls.Add(this.pdfPictureBox);
            this.Controls.Add(this.printPictureBox);
            this.Controls.Add(this.backPictureBox);
            this.Controls.Add(this.aLIMDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Alis_Sayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alım Geçmişi";
            this.Load += new System.EventHandler(this.Alis_Sayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aLIMDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLIMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource aLIMBindingSource;
        private System.Windows.Forms.DataGridView aLIMDataGridView;
        private System.Windows.Forms.PictureBox backPictureBox;
        private System.Windows.Forms.PictureBox printPictureBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.PictureBox pdfPictureBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}