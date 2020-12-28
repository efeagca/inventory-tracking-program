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
    public partial class Yeni_Hesap : Form
    {
        private Envanter_Database.EnvanterContainer dbcontext=new Envanter_Database.EnvanterContainer();

        public Yeni_Hesap()
        {
            InitializeComponent();
        }

        private void backtoLoginButton_Click(object sender, EventArgs e)
        {
            SetVisibleCore(false);
            Giris_Sayfasi gs = new Giris_Sayfasi();
            gs.Show();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            //Şifre en az 5 karakter olmalı.
            if (createPasswordTextBox.Text.Length < 7)
            {
                MessageBox.Show("Şifre en az 7 karakter olmalı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                createAgainPasswordTextBox.Clear();
                createPasswordTextBox.Clear();

                return;
            }
            //Kullanıcı adı en az 5 karakter olmalı.
            if (createUsernameTextBox.Text.Length < 5)
            {
                MessageBox.Show("Kullanıcı adı en az 5 karakter olmalı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                createAgainPasswordTextBox.Clear();
                createPasswordTextBox.Clear();
                createUsernameTextBox.Clear();
                return;
            }
            //Şifre doğrulama kontrolü
            if (createPasswordTextBox.Text!=createAgainPasswordTextBox.Text)
            {

                MessageBox.Show("Parolalar birbiri ile eşleşmiyor.","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                createAgainPasswordTextBox.Clear();
                createPasswordTextBox.Clear();
                return;
            }
            //Textboxların doluluğunu kontrol eder.
            if ((createPasswordTextBox.Text ==null) || (createUsernameTextBox.Text == null) || (createAgainPasswordTextBox.Text==null))
            {
                MessageBox.Show("HATA", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                createAgainPasswordTextBox.Clear();
                createPasswordTextBox.Clear();
                createUsernameTextBox.Clear();
                return;
            }

            try
            {
                
                Envanter_Database.KULLANICI kullanici = new Envanter_Database.KULLANICI();
                
                kullanici.KullaniciAdi = createUsernameTextBox.Text;
                 
                var kullaniciAdiQuery =
                    from k in dbcontext.KULLANICISet
                    where k.KullaniciAdi.Equals(createUsernameTextBox.Text)
                    select k;
                //Kullanıcı adı unique'liği kontrolü.
                if (kullaniciAdiQuery.ToArray().Length != 0)
                {
                    MessageBox.Show("Kullanıcı Adı önceden alınmıştır.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    createAgainPasswordTextBox.Clear();
                    createPasswordTextBox.Clear();
                    createUsernameTextBox.Clear();
                    return;
                }

                RNGCrypt crypt=new RNGCrypt();

                kullanici.Sifre = createPasswordTextBox.Text;
                kullanici.Sifre = crypt.HashPassword(kullanici);
                dbcontext.KULLANICISet.Add(kullanici);
                dbcontext.SaveChanges();

                MessageBox.Show("Kayıt başarıyla oluşturuldu.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SetVisibleCore(false);
                Giris_Sayfasi gs = new Giris_Sayfasi();
                gs.Show();

            }
            catch (Exception)
            {

                MessageBox.Show("BİR HATA OLUŞTU", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        //Sayfanın herhangi bir yerinde enter tuşuna basıldığında hesap oluşturur.
        private void Yeni_Hesap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                createButton.PerformClick();
            }

        }
    }
}
