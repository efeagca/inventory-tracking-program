namespace Envanter_Takip
{
    partial class Sube_Sayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sube_Sayfasi));
            this.subeEkleButton = new System.Windows.Forms.Button();
            this.subelerListBox = new System.Windows.Forms.ListBox();
            this.stokGoruntuleButton1 = new System.Windows.Forms.Button();
            this.deleteSubeButton = new System.Windows.Forms.Button();
            this.logOutPictureBox = new System.Windows.Forms.PictureBox();
            this.addSubePictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logOutPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addSubePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // subeEkleButton
            // 
            this.subeEkleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(7)))), ((int)(((byte)(82)))));
            this.subeEkleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subeEkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subeEkleButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subeEkleButton.ForeColor = System.Drawing.SystemColors.Control;
            this.subeEkleButton.Location = new System.Drawing.Point(204, 87);
            this.subeEkleButton.Name = "subeEkleButton";
            this.subeEkleButton.Size = new System.Drawing.Size(75, 57);
            this.subeEkleButton.TabIndex = 3;
            this.subeEkleButton.Text = "Yeni Şube Ekle";
            this.subeEkleButton.UseVisualStyleBackColor = false;
            this.subeEkleButton.Click += new System.EventHandler(this.subeEkleButton_Click);
            // 
            // subelerListBox
            // 
            this.subelerListBox.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subelerListBox.FormattingEnabled = true;
            this.subelerListBox.ItemHeight = 19;
            this.subelerListBox.Location = new System.Drawing.Point(61, 104);
            this.subelerListBox.Name = "subelerListBox";
            this.subelerListBox.Size = new System.Drawing.Size(127, 175);
            this.subelerListBox.TabIndex = 4;
            // 
            // stokGoruntuleButton1
            // 
            this.stokGoruntuleButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(7)))), ((int)(((byte)(82)))));
            this.stokGoruntuleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stokGoruntuleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stokGoruntuleButton1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokGoruntuleButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.stokGoruntuleButton1.Location = new System.Drawing.Point(204, 215);
            this.stokGoruntuleButton1.Name = "stokGoruntuleButton1";
            this.stokGoruntuleButton1.Size = new System.Drawing.Size(75, 64);
            this.stokGoruntuleButton1.TabIndex = 5;
            this.stokGoruntuleButton1.Text = "Stok Görüntüle";
            this.stokGoruntuleButton1.UseVisualStyleBackColor = false;
            this.stokGoruntuleButton1.Click += new System.EventHandler(this.stokGoruntuleButton1_Click);
            // 
            // deleteSubeButton
            // 
            this.deleteSubeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.deleteSubeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteSubeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteSubeButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteSubeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteSubeButton.Location = new System.Drawing.Point(204, 150);
            this.deleteSubeButton.Name = "deleteSubeButton";
            this.deleteSubeButton.Size = new System.Drawing.Size(75, 59);
            this.deleteSubeButton.TabIndex = 6;
            this.deleteSubeButton.Text = "Şube Sil";
            this.deleteSubeButton.UseVisualStyleBackColor = false;
            this.deleteSubeButton.Click += new System.EventHandler(this.deleteSubeButton_Click);
            // 
            // logOutPictureBox
            // 
            this.logOutPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logOutPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logOutPictureBox.BackgroundImage")));
            this.logOutPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logOutPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutPictureBox.Location = new System.Drawing.Point(17, 12);
            this.logOutPictureBox.Name = "logOutPictureBox";
            this.logOutPictureBox.Size = new System.Drawing.Size(29, 29);
            this.logOutPictureBox.TabIndex = 10;
            this.logOutPictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.logOutPictureBox, "Çıkış");
            this.logOutPictureBox.Click += new System.EventHandler(this.logOutPictureBox_Click);
            // 
            // addSubePictureBox1
            // 
            this.addSubePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.addSubePictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addSubePictureBox1.BackgroundImage")));
            this.addSubePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addSubePictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSubePictureBox1.Location = new System.Drawing.Point(52, 12);
            this.addSubePictureBox1.Name = "addSubePictureBox1";
            this.addSubePictureBox1.Size = new System.Drawing.Size(29, 29);
            this.addSubePictureBox1.TabIndex = 11;
            this.addSubePictureBox1.TabStop = false;
            this.toolTip.SetToolTip(this.addSubePictureBox1, "Yeni Şube Ekle");
            this.addSubePictureBox1.Click += new System.EventHandler(this.subeEkleButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(87, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox1, "Şube Sil");
            this.pictureBox1.Click += new System.EventHandler(this.deleteSubeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(57, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Şubeler:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(122, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 29);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox2, "Arama");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Sube_Sayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(347, 364);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addSubePictureBox1);
            this.Controls.Add(this.logOutPictureBox);
            this.Controls.Add(this.deleteSubeButton);
            this.Controls.Add(this.stokGoruntuleButton1);
            this.Controls.Add(this.subelerListBox);
            this.Controls.Add(this.subeEkleButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Sube_Sayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şube Sayfası";
            this.Load += new System.EventHandler(this.Sube_Sayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logOutPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addSubePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button subeEkleButton;
        private System.Windows.Forms.ListBox subelerListBox;
        private System.Windows.Forms.Button stokGoruntuleButton1;
        private System.Windows.Forms.Button deleteSubeButton;
        private System.Windows.Forms.PictureBox logOutPictureBox;
        private System.Windows.Forms.PictureBox addSubePictureBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip;
    }
}