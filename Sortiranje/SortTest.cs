using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sortiranje
{
    public partial class SortTest : Form
    {
        private SortingEntities1 _ctx;
        private User korisnik;
        private List<Vremena> listaVremena;

        public SortTest(SortingEntities1 ctx, User korisnik)
        {
            InitializeComponent();
            this._ctx = ctx;
            this.korisnik = korisnik;
        }

        private void SortTest_Load(object sender, EventArgs e)
        {
            refreshDGV();
        }

        private void refreshDGV()
        {
            if (korisnik != null)
            {
                string targetUsername = korisnik?.username ?? "Guest";
                listaVremena = _ctx.Vremenas.Where(x => x.username.Equals(targetUsername)).ToList();
                dgvTestVremena.DataSource = listaVremena;
                dgvTestVremena.Columns.Remove(dgvTestVremena.Columns[0]);
                dgvTestVremena.Columns.Remove(dgvTestVremena.Columns[4]);
            }
        }

        private void BtnTestSorts_Click(object sender, EventArgs e)
        {
            try
            {
                int[] brojevi = tbNumbers.Text.Split(',').Select(n => int.Parse(n.Trim())).ToArray();
                int bubbleTime = bubbleSort(brojevi);
                int quickTime = quickSort(brojevi);
                int bstTime = bstSort(brojevi);
                lblBubbleTime.Text = bubbleTime.ToString();
                lblQuickTime.Text = quickTime.ToString();
                lblBstTime.Text = bstTime.ToString();
                if (korisnik != null)
                {
                    Vremena vremena = new Vremena();
                    vremena.username = korisnik.username;
                    vremena.time = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                    vremena.bubble = bubbleTime;
                    vremena.quick = quickTime;
                    vremena.bst = bstTime;
                    vremena.User = korisnik;
                    _ctx.Vremenas.Add(vremena);
                    _ctx.SaveChanges();
                }

                refreshDGV();
            }
            catch (FormatException formatExceptio)
            {
                MessageBox.Show("Wrong input format");
                tbNumbers.Text = "";
            }
        }

        private int bubbleSort(int[] brojevi)
        {
            long start = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            for (int write = 0; write < brojevi.Length; write++)
            {
                for (int sort = 0; sort < brojevi.Length - 1; sort++)
                {
                    if (brojevi[sort] > brojevi[sort + 1])
                    {
                        int temp = brojevi[sort + 1];
                        brojevi[sort + 1] = brojevi[sort];
                        brojevi[sort] = temp;
                    }
                }
            }

            long end = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            return (int)(end - start);
        }

        private int quickSort(int[] brojevi)
        {
            long start = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            quicksort(brojevi, 0, brojevi.Length - 1);

            long end = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            return (int)(end - start);
        }

        private int bstSort(int[] brojevi)
        {
            long start = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            Tree stablo = new Tree();
            foreach (int broj in brojevi)
            {
                stablo.insert(broj);
            }

            int[] sorted = stablo.inrotderArray();

            long end = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            return (int)(end - start);
        }

        private void quicksort(int[] input, int low, int high)
        {
            int pivot_loc = 0;

            if (low < high)
            {
                pivot_loc = partition(input, low, high);
                quicksort(input, low, pivot_loc - 1);
                quicksort(input, pivot_loc + 1, high);
            }
        }

        private int partition(int[] input, int low, int high)
        {
            int pivot = input[high];
            int i = low - 1;

            for (int j = low; j < high - 1; j++)
            {
                if (input[j] <= pivot)
                {
                    i++;
                    swap(input, i, j);
                }
            }
            swap(input, i + 1, high);
            return i + 1;
        }



        private void swap(int[] ar, int a, int b)
        {
            int temp = ar[a];
            ar[a] = ar[b];
            ar[b] = temp;
        }

    }

    internal class Tree
    {
        internal class Node
        {
            public int data;
            public Node left;
            public Node right;

            public Node(int data)
            {
                this.data = data;
            }
        }

        private Node root;
        private int[] sorted;

        public void insert(int data)
        {
            Node n = new Node(data);
            if (root == null)
            {
                root = n;
                return;
            }
            insertRec(root, n);
        }

        private void insertRec(Node root, Node toInsert)
        {
            if (toInsert.data > root.data)
            {
                if (root.right == null)
                {
                    root.right = toInsert;
                }
                else
                {
                    insertRec(root.right, toInsert);
                }
            }
            else
            {
                if (root.left == null)
                {
                    root.left = toInsert;
                }
                else
                {
                    insertRec(root.left, toInsert);
                }
            }
        }

        private int length(Node root)
        {
            if (root == null) return 0;
            return 1 + length(root.left) + length(root.right);
        }

        public int[] inrotderArray()
        {
            int len = length(root);
            sorted = new int[len];
            inorder(root, 0);
            return sorted;
        }

        private void inorder(Node root, int index)
        {
            if (root == null) return;

            inorder(root.left, index + 1);
            sorted[index] = root.data;
            inorder(root.right, index + 1);
        }
    }
}
