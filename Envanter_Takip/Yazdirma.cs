using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Envanter_Takip
{
     class Yazdirma
    {
        private DataGridView dgv;
        public Bitmap bmp;
        public Yazdirma(DataGridView d)
        {
            dgv = d;
        }

        public void Yazdir()
        {
            dgv.ClearSelection();
            dgv.Height = dgv.RowCount * dgv.Height * 2;
            bmp = new Bitmap(dgv.Width, dgv.Height);
            dgv.DrawToBitmap(bmp, new Rectangle(0, 0, dgv.Width, dgv.Height));
            
        }

    }
}
