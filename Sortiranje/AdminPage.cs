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
    public partial class AdminPage : Form
    {
        private SortingEntities1 _ctx;

        public AdminPage(SortingEntities1 ctx)
        {
            InitializeComponent();
            _ctx = ctx;
            dgvUsers.DataSource = _ctx.Users.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // new user
        private void button1_Click(object sender, EventArgs e)
        {
            User korisnik = new User();
            korisnik.username = txtUsernameAdmin.Text;
            korisnik.password = txtPasswordAdmin.Text;
            _ctx.Users.Add(korisnik);
            _ctx.SaveChanges();
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = _ctx.Users.ToList();
        }

        // delete user
        private void button2_Click(object sender, EventArgs e)
        {
            User korisnik = _ctx.Users.Find(txtUsernameAdmin.Text);

            if (korisnik == null)
            {
                MessageBox.Show("User does not exist");
                return;
            }

            _ctx.Users.Remove(korisnik);
            _ctx.SaveChanges();
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = _ctx.Users.ToList();
        }
    }
}
