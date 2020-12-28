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
    public partial class Yeni_Urun : Form
    {
        private Envanter_Database.EnvanterContainer dbcontext = new Envanter_Database.EnvanterContainer();
        private Envanter_Database.SUBE sube;
        public Yeni_Urun(Envanter_Database.SUBE sube)
        {
            this.sube = sube;
            InitializeComponent();
        }

        private void ekleButton1_Click(object sender, EventArgs e)
        {
            Envanter_Database.URUN urun = new Envanter_Database.URUN();
            urun.SubeId = sube.SubeId;
            urun.KullaniciID = sube.KullaniciID;


            if ((urunAdiTextBox.Text.Length == 0) ||
                (urunCinsiTextBox.Text.Length == 0) ||
                (satisFiyatTextBox.Text.Length == 0) ||
                (birimComboBox.SelectedItem.ToString().Length == 0) ||
                (alinanStokTextBox.Text.Length == 0) ||
                (alisFiyatTextBox.Text.Length == 0))
            {
                MessageBox.Show("Ürün adı, Ürün Cinsi, Alış Fiyatı, Satış Fiyatı ve Birimi boş bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            urun.Aciklama1 = aciklamaTextBox1.Text;
            urun.Aciklama2 = aciklamaTextBox2.Text;
            urun.Birim = birimComboBox.SelectedItem.ToString();
            urun.Birim_Fiyat = Convert.ToInt32(satisFiyatTextBox.Text);
            if (kritikSSTextBox.Text.Length!=0)
            {
                urun.Kritik_Stok_Seviyesi = Convert.ToInt32(kritikSSTextBox.Text);

            }
            urun.Stok = Convert.ToInt32(alinanStokTextBox.Text);
            urun.UrunAdi = urunAdiTextBox.Text;
            urun.UrunCinsi = urunCinsiTextBox.Text;

            dbcontext.URUNSet1.Add(urun);

            Envanter_Database.ALIM alim = new Envanter_Database.ALIM();
            alim.Barkod = urun.Barkod;
            alim.Birim_Alis_Fiyati = Convert.ToInt32(alisFiyatTextBox.Text);
            alim.Date = DateTime.Now;
            alim.KullaniciID = urun.KullaniciID;
            alim.Miktar = urun.Stok;
            alim.SubeId = urun.SubeId;

            dbcontext.ALIMSet.Add(alim);
            dbcontext.SaveChanges();
            Stok_Sayfasi ss = new Stok_Sayfasi(sube);
            this.Close();
            ss.Show();
        }

        private void iptalButton1_Click(object sender, EventArgs e)
        {
            Stok_Sayfasi ss = new Stok_Sayfasi(sube);
            ss.Show();
            this.Close();
        }
    }
}
