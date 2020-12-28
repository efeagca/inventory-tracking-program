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
    public partial class Yeni_Sube : Form
    {
        Envanter_Database.KULLANICI kullanici;
        Envanter_Database.EnvanterContainer dbcontext = new Envanter_Database.EnvanterContainer();
        public Yeni_Sube(Envanter_Database.KULLANICI kullanici)
        {
            InitializeComponent();
            this.kullanici = kullanici;

        }

        private void backtoLoginButton_Click(object sender, EventArgs e)
        {
            
            Sube_Sayfasi nss=new Sube_Sayfasi(kullanici);
            nss.Show();
            this.Close();
        }

        private void ekleButton1_Click(object sender, EventArgs e)
        {
            var SubeQuery =
                    from k in dbcontext.SUBESet1
                    where k.KullaniciID.Equals(kullanici.KullaniciID) && k.SubeAdi.Equals(subeadiTextBox.Text)
                    select k;
            Array a = SubeQuery.ToArray();
            if (a.Length!=0)
            {
                MessageBox.Show("Bu şube kayıtlı." ,"HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Envanter_Database.SUBE sube = new Envanter_Database.SUBE();
            sube.KullaniciID = kullanici.KullaniciID;
            sube.SubeAdi = subeadiTextBox.Text;
            dbcontext.SUBESet1.Add(sube);
            dbcontext.SaveChanges();

            Sube_Sayfasi nss = new Sube_Sayfasi(kullanici);
            nss.Show();
            this.Close();
        }
    }
}
