using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Envanter_Takip
{
    public partial class Giris_Sayfasi : Form
    {
        private Envanter_Database.EnvanterContainer dbcontext = new Envanter_Database.EnvanterContainer();

        public Giris_Sayfasi()
        {
            
            InitializeComponent();
            this.CenterToScreen();
            
        }

        private void createAccountLabel_Click(object sender, EventArgs e)
        {
            SetVisibleCore(false);
            Yeni_Hesap yh = new Yeni_Hesap();
            yh.Show();
           
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            var kullaniciAdiQuery =
                    from k in dbcontext.KULLANICISet
                    where  k.KullaniciAdi==usernameTextBox.Text 
                    select  k;
           
            Array a = kullaniciAdiQuery.ToArray();
            //Girilen kullanıcı adı database'de yok ise bu hata mesajını gönderir.
            if (a.Length == 0)
            {
                MessageBox.Show("Kullanıcı Adı bulunamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextBox.Clear();
                return;
            }

            Envanter_Database.KULLANICI kullanici=(Envanter_Database.KULLANICI)a.GetValue(0);
            RNGCrypt decrypt = new RNGCrypt();

            String sifre = decrypt.UnHashPassword(kullanici);
            
            
            //Kullanıcı var ancak şifresi doğru girilmedi ise bu hata mesajı gönderir.
            if (!sifre.Equals(passwordTextBox.Text))
            {
                MessageBox.Show("Şifre yanlış!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextBox.Clear();
                return;
            }

            //Her şey doğru girildiyse bir sonraki sayfa açılır.
            this.SetVisibleCore(false);
            Sube_Sayfasi ss = new Sube_Sayfasi(kullanici);
            ss.Show();

        }

        //Sayfanın herhangi bir yerinde enter tuşuna basıldığında login yapar.
        private void Giris_Sayfasi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
            }

        }

        private void Giris_Sayfasi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
