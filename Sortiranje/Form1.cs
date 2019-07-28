using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sortiranje
{
    public partial class Form1 : Form
    {
        ElementList elements; // lista elementata
        public static Thread t1, t2; // niti za animacije zamene mesta dva elementa
        public static Thread sortThread; // nit koja izvrsava trenutni algoritam za sortiranje
        public int? pivotX, pivotY; // koordinate pivota (ako postoji)
        public int? iX, iY, jX, jY; // koordinate za I i J u quicksort algoritmu
        public volatile bool sorting = false; // da li se trenutno izvrsava neki algoritam
        public int animationSpeed = 50; // brzina animacija
        private bool guest; // da li je korisnik ulogovan kao gost
        private User korisnik;
        private SortingEntities1 _ctx; // konekcija s bazom

        public Form1(bool guest, User korisnik, SortingEntities1 ctx)
        {
            InitializeComponent();
            elements = new ElementList(this, Width / 2);
            ResizeRedraw = true;
            DoubleBuffered = true;
            this.guest = guest;
            this.korisnik = korisnik;
            _ctx = ctx;
        }

        // iscrtava novo stanje forme
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            elements.drawAll(e.Graphics);

            // crta pivot ako postoji
            if (pivotX != null && pivotY != null)
                DrawPivot(e.Graphics);

            // crta I ako postoji (quicksort)
            if (iX != null && iY != null)
                DrawI(e.Graphics);

            // crta J ako postoji (quicksort)
            if (jX != null && jY != null)
                DrawJ(e.Graphics);
        }

        // postavlja nasumicne brojeve u elemente liste
        private void btnRandomize_Click(object sender, EventArgs e)
        {
            if (sorting)
                cancelThreads();

            iX = iY = jX = jY = pivotX = pivotY = null;
            elements = new ElementList(this, Width / 2);
            elements.randomize();
            Invalidate();
        }

        // postavlja novu x koordinatu sredine ekrana kada forma promeni velicinu
        private void Form1_Resize(object sender, EventArgs e)
        {
            elements.MiddleScreen = (sender as Control).Width / 2;
            Invalidate();
        }

        // izvrsava quicksort
        private void btnQuick_Click(object sender, EventArgs e)
        {
            if (sorting)
                cancelThreads();

            sorting = true;
            sortThread = new Thread(() => elements.QuickSort());
            sortThread.Start();

            if (!guest)
            {
                korisnik.quick++;
                btnQuick.Text = "Quick Sort: " + korisnik.quick.ToString();
                _ctx.SaveChanges();
            }
        }

        // izvrsava bubblesort
        private void btnBubble_Click(object sender, EventArgs e)
        {
            if (sorting)
                cancelThreads();

            sorting = true;
            sortThread = new Thread(() => elements.BubbleSort());
            sortThread.Start();

            if (!guest)
            {
                korisnik.bubble++;
                btnBubble.Text = "Bubble Sort: " + korisnik.bubble.ToString();
                _ctx.SaveChanges();
            }
        }

        // pravi novu listu na osnovu unosa korisnika
        private void btnMakeList_Click(object sender, EventArgs e)
        {
            if (sorting)
                cancelThreads();

            string inputElements = txtMakeList.Text;
            string[] strElements = inputElements.Split(new char[] { ' ', ',', ';' });
            List<int> intElements = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                int intElem;
                try
                {
                    intElem = int.Parse(strElements[i]);
                }
                catch
                {
                    intElem = 0;
                }
                intElements.Add(intElem);
            }
            elements = new ElementList(this, Width / 2, intElements);
            Invalidate();
        }

        // zaustavlja izvrsavanje trenutnog algoritma
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (sorting)
                cancelThreads();
        }

        // zaustavlja niti koje rade kada se forma gasi
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sorting)
                cancelThreads();
        }

        // menja brzinu animacija na osnovu vrednosti slajdera
        private void tbSpeed_Scroll(object sender, EventArgs e)
        {
            animationSpeed = tbSpeed.Value;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            elements = new ElementList(this, Width / 2);
            elements.randomize();
            Invalidate();
        }

        // izvrsava BSTsort
        private void btnBST_Click(object sender, EventArgs e)
        {
            if (sorting)
                cancelThreads();

            sorting = true;
            sortThread = new Thread(() => elements.BSTSort());
            sortThread.Start();

            if (!guest)
            {
                korisnik.bst++;
                btnBST.Text = "BST Sort: " + korisnik.bst.ToString();
                _ctx.SaveChanges();
            }
        }

        // crta pivot ako postoji
        public void DrawPivot(Graphics g)
        {
            StringFormat formatCenter =  new StringFormat();
            Rectangle rectString = new Rectangle((pivotX ?? 0) + 15, (pivotY ?? 0) + 180 / 3, 60, 60);
            Font font = new Font("Arial", 20);
            SolidBrush brush = new SolidBrush(Color.Black);
            g.DrawString("P", font, brush, rectString, formatCenter);
        }

        // crta I ako postoji
        public void DrawI(Graphics g)
        {
            StringFormat formatCenter = new StringFormat();
            Rectangle rectString = new Rectangle((iX ?? 0) + 15, (iY ?? 0) + 180 / 3, 60, 60);
            Font font = new Font("Arial", 20);
            SolidBrush brush = new SolidBrush(Color.Black);
            g.DrawString("i", font, brush, rectString, formatCenter);
        }

        // crta J ako postoji
        public void DrawJ(Graphics g)
        {
            StringFormat formatCenter = new StringFormat();
            Rectangle rectString = new Rectangle((jX ?? 0) + 15, (jY ?? 0) + 180 / 3, 60, 60);
            Font font = new Font("Arial", 20);
            SolidBrush brush = new SolidBrush(Color.Black);
            g.DrawString("j", font, brush, rectString, formatCenter);
        }

        public void EnableButtons(bool toEnable)
        {
            btnBubble.Enabled = toEnable;
            btnQuick.Enabled = toEnable;
            btnRandomize.Enabled = toEnable;
        }

        // zaustavlja niti koje trenutno rade
        private void cancelThreads()
        {
            iX = iY = jX = jY = pivotX = pivotY = null;

            sorting = false;

            if (t1 != null)
            {
                t1.Abort();
            }

            if (t2 != null)
            {
                t1.Abort();
            }

            if (sortThread != null)
            {
                sortThread.Abort();
                sortThread = null;
            }

            elements.randomize();
            Invalidate();
        }
    }
}
