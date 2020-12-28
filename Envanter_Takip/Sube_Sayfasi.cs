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

    public partial class Sube_Sayfasi : Form
    {

        private Envanter_Database.EnvanterContainer dbcontext = new Envanter_Database.EnvanterContainer();
        Envanter_Database.KULLANICI kullanici;
        public Sube_Sayfasi(Envanter_Database.KULLANICI kullanici)
        {
            this.kullanici = kullanici; //Şifresi girilen kullanıcının bilgilerini buraya aktardık.
            InitializeComponent();
        }
        
            
        //Sayfa ilk açıldığı zaman şube adlarının listelenmesini sağlar.
        private void Sube_Sayfasi_Load(object sender, EventArgs e)
        {
            var SubeQuery =
                    from k in dbcontext.SUBESet1
                    where k.KullaniciID.Equals(kullanici.KullaniciID)
                    select k;

            Array subeList = SubeQuery.ToArray();
            for (int i = 0; i < subeList.Length; i++)
            {
                Envanter_Database.SUBE temp = (Envanter_Database.SUBE)subeList.GetValue(i);
                subelerListBox.Items.Add(temp.SubeAdi);
            }
        }

        //Şube ekleme penceresine gider.
        private void subeEkleButton_Click(object sender, EventArgs e)
        {
            Yeni_Sube ys = new Yeni_Sube(kullanici);
            
            ys.Show();
            this.Close();
        }

        //Şube silme komutu.
        private void deleteSubeButton_Click(object sender, EventArgs e)
        {
            var SubeQuery =
                   from k in dbcontext.SUBESet1
                   where k.KullaniciID.Equals(kullanici.KullaniciID) && k.SubeAdi.Equals(subelerListBox.SelectedItem.ToString())
                   select k;

            Array a = SubeQuery.ToArray();
            Envanter_Database.SUBE temp = (Envanter_Database.SUBE)a.GetValue(0);

            dbcontext.SUBESet1.Remove(temp);
            dbcontext.SaveChanges();
            subelerListBox.Items.Remove(temp.SubeAdi);
            
        }
        
        //Hesaptan çıkış yapar. Giriş sayfasına döner.
        private void logOutPictureBox_Click(object sender, EventArgs e)
        {
            Giris_Sayfasi gs = new Giris_Sayfasi();
            gs.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e) //search ikonu
        {
            Arama_Sayfasi a = new Arama_Sayfasi(kullanici);
            this.Close();
            a.Show();
        }

        private void stokGoruntuleButton1_Click(object sender, EventArgs e)
        {
            if (subelerListBox.SelectedItems.Count ==0)
            {
                MessageBox.Show("Lütfen görüntülemek istediğiniz şubeyi seçiniz");
                return;
            }

            var SubeQuery =
                  from k in dbcontext.SUBESet1
                  where k.KullaniciID.Equals(kullanici.KullaniciID) && k.SubeAdi.Equals(subelerListBox.SelectedItem.ToString())
                  select k;

            Array a = SubeQuery.ToArray();
            Envanter_Database.SUBE temp = (Envanter_Database.SUBE)a.GetValue(0);

            Stok_Sayfasi ss = new Stok_Sayfasi(temp);
            this.Close();
            ss.Show();
        }
    }
}