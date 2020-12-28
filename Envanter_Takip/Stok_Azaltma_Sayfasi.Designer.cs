namespace Envanter_Takip
{
    partial class Stok_Azaltma_Sayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stok_Azaltma_Sayfasi));
            this.azaltButton = new System.Windows.Forms.Button();
            this.backtoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.barkodTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stokSayisitextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // azaltButton
            // 
            this.azaltButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(27)))), ((int)(((byte)(59)))));
            this.azaltButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.azaltButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.azaltButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.azaltButton.ForeColor = System.Drawing.SystemColors.Control;
            this.azaltButton.Location = new System.Drawing.Point(207, 116);
            this.azaltButton.Name = "azaltButton";
            this.azaltButton.Size = new System.Drawing.Size(75, 23);
            this.azaltButton.TabIndex = 19;
            this.azaltButton.Text = "Azalt";
            this.azaltButton.UseVisualStyleBackColor = false;
            this.azaltButton.Click += new System.EventHandler(this.azaltButton_Click);
            // 
            // backtoButton
            // 
            this.backtoButton.BackColor = System.Drawing.Color.Transparent;
            this.backtoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backtoButton.BackgroundImage")));
            this.backtoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backtoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backtoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backtoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backtoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backtoButton.Location = new System.Drawing.Point(12, 12);
            this.backtoButton.Name = "backtoButton";
            this.backtoButton.Size = new System.Drawing.Size(44, 24);
            this.backtoButton.TabIndex = 18;
            this.backtoButton.UseVisualStyleBackColor = false;
            this.backtoButton.Click += new System.EventHandler(this.backtoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(35, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Barkod            :";
            // 
            // barkodTextBox
            // 
            this.barkodTextBox.Location = new System.Drawing.Point(126, 50);
            this.barkodTextBox.Name = "barkodTextBox";
            this.barkodTextBox.Size = new System.Drawing.Size(156, 20);
            this.barkodTextBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(35, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Stok Miktarı :";
            // 
            // stokSayisitextBox
            // 
            this.stokSayisitextBox.Location = new System.Drawing.Point(126, 80);
            this.stokSayisitextBox.Name = "stokSayisitextBox";
            this.stokSayisitextBox.Size = new System.Drawing.Size(156, 20);
            this.stokSayisitextBox.TabIndex = 20;
            // 
            // Stok_Azaltma_Sayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(325, 169);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stokSayisitextBox);
            this.Controls.Add(this.azaltButton);
            this.Controls.Add(this.backtoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barkodTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Stok_Azaltma_Sayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Azaltma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button azaltButton;
        private System.Windows.Forms.Button backtoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox barkodTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stokSayisitextBox;
    }
}