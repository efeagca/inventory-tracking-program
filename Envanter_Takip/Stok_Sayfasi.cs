using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace Envanter_Takip
{
    public partial class Stok_Sayfasi : Form
    {
        Envanter_Database.SUBE sube;
        Envanter_Database.EnvanterContainer dbcontext = new Envanter_Database.EnvanterContainer();

        public Stok_Sayfasi(Envanter_Database.SUBE sube)
        {
            this.sube = sube;
            InitializeComponent();
        }

        private void Stok_Sayfasi_Load(object sender, EventArgs e)
        {
            this.Text=sube.SubeAdi;
            dbcontext.URUNSet1.Where(a => a.KullaniciID == sube.KullaniciID && a.SubeId ==sube.SubeId).Load();
            uRUNBindingSource.DataSource = dbcontext.URUNSet1.Local.OrderBy(a => a.Barkod);
        }

        private void eklemePictureBox1_Click(object sender, EventArgs e)
        {
            Stok_Ekleme_Sayfasi ses = new Stok_Ekleme_Sayfasi(sube);
            this.Close();
            ses.Show();   
        }

        private void deletePictureBox_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Emin misiniz?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            else if (dialogResult == DialogResult.Yes)
            {
              

            if (uRUNDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silmek istediğiniz ürün veya ürünleri seçiniz");
                return;
            }

            Envanter_Database.URUN urun = new Envanter_Database.URUN();
            List<int> silincek_urun_barkodlari = new List<int>();
            
            foreach (DataGridViewRow rowselected in uRUNDataGridView.SelectedRows)
            {
                silincek_urun_barkodlari.Add (Convert.ToInt32( uRUNDataGridView[0, rowselected.Index].Value));
                uRUNDataGridView.Rows.Remove(rowselected);
            }
            foreach (int barkod in silincek_urun_barkodlari)
            {
                object[] o = { barkod, sube.SubeId, sube.KullaniciID };
                Envanter_Database.URUN tempUrun = dbcontext.URUNSet1.Find(o);
                if (tempUrun !=null)
                {
                    dbcontext.URUNSet1.Remove(tempUrun);

                }
            }
            dbcontext.SaveChanges();
            }

        }

        private void addNewpictureBox1_Click(object sender, EventArgs e)
        {
            Yeni_Urun yu = new Yeni_Urun(sube);
           
            this.Close();
            yu.Show();
        }

        private void backPictureBox_Click(object sender, EventArgs e)
        {
            Envanter_Database.KULLANICI kullanici = new Envanter_Database.KULLANICI();
            kullanici = dbcontext.KULLANICISet.Find(sube.KullaniciID);
            Sube_Sayfasi sb = new Sube_Sayfasi(kullanici);
            
            this.Close();
            sb.Show();
        }

        private void minusPictureBox1_Click(object sender, EventArgs e)
        {
            Stok_Azaltma_Sayfasi sas = new Stok_Azaltma_Sayfasi(sube);
            this.Close();
            sas.Show();



        }

        private void updatePictureBox_Click(object sender, EventArgs e)
        {
            Stok_Guncelleme_Sayfasi sgs = new Stok_Guncelleme_Sayfasi(sube);
            this.Close();
            sgs.Show();
        }
        Yazdirma y;
        private void printPictureBox_Click(object sender, EventArgs e)
        {
            
            y = new Yazdirma(uRUNDataGridView);
            y.Yazdir();
            printPreviewDialog1.ShowDialog();

        }

        private void SatisGoruntuleButton_Click(object sender, EventArgs e)
        {
            Satis_Sayfasi ss = new Satis_Sayfasi(sube);
            this.Close();
            ss.Show();
        }

        private void alimGecmisiButton_Click(object sender, EventArgs e)
        {
            Alis_Sayfasi aas = new Alis_Sayfasi(sube);
            this.Close();
            aas.Show();
        }

        private void searchPictureBox_Click(object sender, EventArgs e)
        {
            Search();

        }

        // arama metodu
        private void Search()
        {
            if (uRUNDataGridView.Rows.Count != 0 && aramaTextBox.Text.Length != 0)
            {
                int barkod, stok, kss;
                double birimFiyat;
                uRUNBindingSource.Clear();
                if (Int32.TryParse(aramaTextBox.Text, out barkod))
                {
                    barkod = Convert.ToInt32(aramaTextBox.Text);
                }
                if (Int32.TryParse(aramaTextBox.Text, out stok))
                {
                    stok = Convert.ToInt32(aramaTextBox.Text);
                }
                if (Int32.TryParse(aramaTextBox.Text, out kss))
                {
                    kss = Convert.ToInt32(aramaTextBox.Text);
                }
                if (double.TryParse(aramaTextBox.Text, out birimFiyat))
                {
                    birimFiyat = Convert.ToDouble(aramaTextBox.Text);
                }

                var query =
                    from u in dbcontext.URUNSet1
                    where u.SubeId == sube.SubeId &&
                         u.KullaniciID == sube.KullaniciID &&
                        (u.Barkod == barkod ||
                        u.Stok == stok ||
                        u.Kritik_Stok_Seviyesi == kss ||
                        u.Birim_Fiyat == birimFiyat ||
                        u.UrunAdi.Contains(aramaTextBox.Text) ||
                        u.UrunCinsi.Contains(aramaTextBox.Text) ||
                        u.Birim.Contains(aramaTextBox.Text) ||
                        u.Aciklama1.Contains(aramaTextBox.Text) ||
                        u.Aciklama2.Contains(aramaTextBox.Text))
                    select u;

                foreach (var urun in query)
                {

                    uRUNBindingSource.Add(urun);

                }
            }
            else
            {
                uRUNBindingSource.Clear();
                var query =
                    from u in dbcontext.URUNSet1
                    where u.SubeId == sube.SubeId &&
                         u.KullaniciID == sube.KullaniciID
                    select u;
                foreach (var urun in query)
                {
                    uRUNBindingSource.Add(urun);
                }
            }
        }

       

        private void aramaTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            Search();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(y.bmp, 0, 0);
        }

        private void pdfPictureBox_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(uRUNDataGridView.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in uRUNDataGridView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in uRUNDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        pdfTable.AddCell(cell.Value.ToString());

                    }

                }
            }

            //Exporting to PDF

            folderBrowserDialog1.ShowDialog();
            using (FileStream stream = new FileStream(folderBrowserDialog1.SelectedPath + "DataGridViewExport.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A1, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
        }
    }
}
