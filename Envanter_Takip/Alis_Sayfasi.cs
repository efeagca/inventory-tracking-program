using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Envanter_Takip
{
    public partial class Alis_Sayfasi : Form
    {
        Envanter_Database.SUBE sube;
        Envanter_Database.EnvanterContainer dbcontext = new Envanter_Database.EnvanterContainer();
        public Alis_Sayfasi(Envanter_Database.SUBE sube)
        {
            this.sube = sube;
            InitializeComponent();
            this.CenterToScreen();
            
        }

        private void Alis_Sayfasi_Load(object sender, EventArgs e)
        {
            int index = 0;
            dbcontext.ALIMSet.Where(a => a.KullaniciID == sube.KullaniciID && a.SubeId == sube.SubeId).Load();
            aLIMBindingSource.DataSource = dbcontext.ALIMSet.Local.OrderBy(a => a.Date);


            Array alimList = dbcontext.ALIMSet.Where(a => a.KullaniciID == sube.KullaniciID && a.SubeId == sube.SubeId).ToArray();


           

            foreach (Envanter_Database.ALIM item in alimList)
            {
               
                DataGridViewRow row = (DataGridViewRow)aLIMDataGridView.Rows[index];
                Array urunList =dbcontext.URUNSet1.Where(a => a.Barkod == item.Barkod).ToArray();

                if (urunList.Length!=0) // alınan ürün ürün tablomuzda var ise
                {
                    Envanter_Database.URUN u = (Envanter_Database.URUN)urunList.GetValue(0);
                    row.Cells[1].Value =u.UrunAdi;
                }
                else // alınan ürün ürünler tablosundan silinmiş ise ürünün adı yerine silinmiş yazdırıyoruz
                {
                    row.Cells[1].Value = "(silinmiş)";
                }

                
                index++;
            }

        }

        private void backPictureBox_Click(object sender, EventArgs e)
        {
            Stok_Sayfasi ss = new Stok_Sayfasi(sube);
            this.Close();
            ss.Show();
        }
        Yazdirma y;
        private void printPictureBox_Click(object sender, EventArgs e)
        {
            y = new Yazdirma(aLIMDataGridView);
            y.Yazdir();
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(y.bmp, 0, 0);
        }

        private void pdfPictureBox_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(aLIMDataGridView.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in aLIMDataGridView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in aLIMDataGridView.Rows)
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
