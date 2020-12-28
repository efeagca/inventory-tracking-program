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
    public partial class Stok_Guncelleme_Sayfasi : Form
    {
        private Envanter_Database.EnvanterContainer dbcontext = new Envanter_Database.EnvanterContainer();
        Envanter_Database.SUBE sube;
        public Stok_Guncelleme_Sayfasi(Envanter_Database.SUBE sube)
        {
            this.sube = sube;
            InitializeComponent();
        }

        private void iptalButton1_Click(object sender, EventArgs e)
        {
            Stok_Sayfasi ss = new Stok_Sayfasi(sube);
            this.Close();
            ss.Show();
        }

        


         private void ekleButton1_Click(object sender, EventArgs e)
        {
            Envanter_Database.URUN urun = new Envanter_Database.URUN();

            
            if (barkodTextBox.Text.Length == 0)
            {
                MessageBox.Show("Barkod boş bırakılamaz","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            urun.Barkod = Convert.ToInt32(barkodTextBox.Text);
            urun.SubeId = sube.SubeId;
            urun.KullaniciID = sube.KullaniciID;

            object[] o = { urun.Barkod, urun.SubeId, urun.KullaniciID };
            Envanter_Database.URUN tempUrun =dbcontext.URUNSet1.Find(o);
            
            if (tempUrun==null)
            {
                MessageBox.Show("Bu barkoda ait ürün bulunamadı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (urunAdiTextBox.Text.Length != 0)
                {
                    tempUrun.UrunAdi = urunAdiTextBox.Text;
                    
                }
                if (urunCinsiTextBox.Text.Length != 0)
                {
                    tempUrun.UrunCinsi = urunCinsiTextBox.Text;

                }
                if (aciklamaTextBox1.Text.Length != 0)
                {
                    tempUrun.Aciklama1 = aciklamaTextBox1.Text;

                }
                if (aciklamaTextBox2.Text.Length != 0)
                {
                    tempUrun.Aciklama2 = aciklamaTextBox2.Text;

                }
                if (kritikSSTextBox.Text.Length != 0)
                {
                    tempUrun.Kritik_Stok_Seviyesi = Convert.ToInt32(kritikSSTextBox.Text);

                }
                if (satisFiyatTextBox.Text.Length != 0)
                {
                    tempUrun.Birim_Fiyat =Convert.ToInt32( satisFiyatTextBox.Text);

                }
                if (birimComboBox.SelectedItem != null)
                {
                    tempUrun.Birim = birimComboBox.SelectedItem.ToString();

                }
                if (alinanStokTextBox.Text.Length != 0)
                {
                    tempUrun.Stok += Convert.ToInt32(alinanStokTextBox.Text);
                }
                int barkod = Convert.ToInt32(barkodTextBox.Text);

                var result = dbcontext.URUNSet1.Single(u => u.Barkod == barkod);

                dbcontext.Entry(result).CurrentValues.SetValues(tempUrun);

            }

            dbcontext.SaveChanges();

            Stok_Sayfasi ss = new Stok_Sayfasi(sube);
            this.Close();
            ss.Show();

        }
    }
}
