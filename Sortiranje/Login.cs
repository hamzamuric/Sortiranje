using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sortiranje
{
    public partial class Login : Form
    {
        SortingEntities1 _ctx; // konekcija s bazom
        public Login()
        {
            InitializeComponent();
            _ctx = new SortingEntities1();
        }

        // korisnik se ulogovao kao obicni korisnik
        private void btnUser_Click(object sender, EventArgs e)
        {
            if (txtUsername.Equals(""))
            {
                MessageBox.Show("Username should not be empty");
                return;
            }
            if (txtPassword.Equals(""))
            {
                MessageBox.Show("Password should not be empty");
                return;
            }

            User korisnik = _ctx.Users.Find(txtUsername.Text);

            if (korisnik == null)
            {
                MessageBox.Show("User does not exist");
                return;
            }

            if (korisnik.password != txtPassword.Text)
            {
                MessageBox.Show("Invalid password");
                return;
            }

            Form1 f = new Form1(false, korisnik, _ctx);

            f.Show();
        }

        // korisnik se ulogovao kao gost
        private void btnGuest_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(true, null, null);
            f.Show();
        }

        // korisnik se ulogovao kao admin
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("admin") && txtPassword.Text.Equals("admin"))
            {
                AdminPage ap = new AdminPage(_ctx);
                ap.Show();
            }
        }

        // pomoc (uputstvo za upotrebu)
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Show();
        }
    }
}
