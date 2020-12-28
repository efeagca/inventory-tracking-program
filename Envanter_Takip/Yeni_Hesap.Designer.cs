namespace Envanter_Takip
{
    partial class Yeni_Hesap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yeni_Hesap));
            this.createUsernameTextBox = new System.Windows.Forms.TextBox();
            this.createPasswordTextBox = new System.Windows.Forms.TextBox();
            this.createAgainPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.backtoLoginButton = new System.Windows.Forms.Button();
            this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // createUsernameTextBox
            // 
            this.createUsernameTextBox.Location = new System.Drawing.Point(56, 106);
            this.createUsernameTextBox.Name = "createUsernameTextBox";
            this.createUsernameTextBox.Size = new System.Drawing.Size(142, 20);
            this.createUsernameTextBox.TabIndex = 1;
            // 
            // createPasswordTextBox
            // 
            this.createPasswordTextBox.Location = new System.Drawing.Point(56, 162);
            this.createPasswordTextBox.Name = "createPasswordTextBox";
            this.createPasswordTextBox.PasswordChar = '*';
            this.createPasswordTextBox.Size = new System.Drawing.Size(142, 20);
            this.createPasswordTextBox.TabIndex = 2;
            // 
            // createAgainPasswordTextBox
            // 
            this.createAgainPasswordTextBox.Location = new System.Drawing.Point(56, 214);
            this.createAgainPasswordTextBox.Name = "createAgainPasswordTextBox";
            this.createAgainPasswordTextBox.PasswordChar = '*';
            this.createAgainPasswordTextBox.Size = new System.Drawing.Size(142, 20);
            this.createAgainPasswordTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(53, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(53, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(53, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifreyi Doğrula";
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(59)))));
            this.createButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.createButton.ForeColor = System.Drawing.SystemColors.Control;
            this.createButton.Location = new System.Drawing.Point(128, 255);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(70, 27);
            this.createButton.TabIndex = 10;
            this.createButton.Text = "OLUŞTUR";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
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
            this.backtoLoginButton.TabIndex = 13;
            this.backtoLoginButton.UseVisualStyleBackColor = false;
            this.backtoLoginButton.Click += new System.EventHandler(this.backtoLoginButton_Click);
            // 
            // kullaniciBindingSource
            // 
            this.kullaniciBindingSource.DataSource = typeof(Envanter_Database.KULLANICI);
            // 
            // Yeni_Hesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(262, 356);
            this.Controls.Add(this.backtoLoginButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createAgainPasswordTextBox);
            this.Controls.Add(this.createPasswordTextBox);
            this.Controls.Add(this.createUsernameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Yeni_Hesap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Hesap Oluştur";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Yeni_Hesap_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox createUsernameTextBox;
        private System.Windows.Forms.TextBox createPasswordTextBox;
        private System.Windows.Forms.TextBox createAgainPasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button backtoLoginButton;
        private System.Windows.Forms.BindingSource kullaniciBindingSource;
    }
}