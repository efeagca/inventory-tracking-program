namespace Envanter_Takip
{
    partial class Yeni_Sube
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yeni_Sube));
            this.label1 = new System.Windows.Forms.Label();
            this.subeadiTextBox = new System.Windows.Forms.TextBox();
            this.backtoLoginButton = new System.Windows.Forms.Button();
            this.ekleButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(33, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Şube Adı:";
            // 
            // subeadiTextBox
            // 
            this.subeadiTextBox.Location = new System.Drawing.Point(124, 62);
            this.subeadiTextBox.Name = "subeadiTextBox";
            this.subeadiTextBox.Size = new System.Drawing.Size(156, 20);
            this.subeadiTextBox.TabIndex = 5;
            // 
            // backtoLoginButton
            // 
            this.backtoLoginButton.BackColor = System.Drawing.Color.Transparent;
            this.backtoLoginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backtoLoginButton.BackgroundImage")));
            this.backtoLoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backtoLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backtoLoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backtoLoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backtoLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backtoLoginButton.Location = new System.Drawing.Point(12, 12);
            this.backtoLoginButton.Name = "backtoLoginButton";
            this.backtoLoginButton.Size = new System.Drawing.Size(44, 24);
            this.backtoLoginButton.TabIndex = 14;
            this.backtoLoginButton.UseVisualStyleBackColor = false;
            this.backtoLoginButton.Click += new System.EventHandler(this.backtoLoginButton_Click);
            // 
            // ekleButton1
            // 
            this.ekleButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(59)))));
            this.ekleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ekleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ekleButton1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.ekleButton1.Location = new System.Drawing.Point(205, 102);
            this.ekleButton1.Name = "ekleButton1";
            this.ekleButton1.Size = new System.Drawing.Size(75, 23);
            this.ekleButton1.TabIndex = 15;
            this.ekleButton1.Text = "Ekle";
            this.ekleButton1.UseVisualStyleBackColor = false;
            this.ekleButton1.Click += new System.EventHandler(this.ekleButton1_Click);
            // 
            // Yeni_Sube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(314, 159);
            this.Controls.Add(this.ekleButton1);
            this.Controls.Add(this.backtoLoginButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subeadiTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Yeni_Sube";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Şube Oluştur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subeadiTextBox;
        private System.Windows.Forms.Button backtoLoginButton;
        private System.Windows.Forms.Button ekleButton1;
    }
}