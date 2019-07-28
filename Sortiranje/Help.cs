using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sortiranje
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            Image slika = null;
            try
            {
                slika = Image.FromFile("..\\..\\slike\\slika.jpg");
            }
            catch { }

            if (slika != null)
            {
                pictureBox.Image = slika;
                Size = new Size(740, 740);
            }
        }

        // stampanje dokumentacije
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += printanje;
            pd.Print();
        }

        private void printanje(object sender, PrintPageEventArgs e)
        {
            try
            {
                Image slika = Image.FromFile("..\\..\\slike\\slika.jpg");
                e.Graphics.DrawImage(slika, new Point(0, 0));
            }
            catch
            {
                MessageBox.Show("Problem printing documentation");
            }
        }
    }
}
