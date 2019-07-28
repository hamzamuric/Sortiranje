using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace Sortiranje
{
    class ElementTree
    {
        // jedan cvor u stablu
        class Node
        {
            public Element inner;
            public Node left;
            public Node right;

            public Node(Element e)
            {
                inner = e;
            }
        }

        public Element[] elements; // niz elemenata
        private int middleScreen; // sredina ekrana

        public ElementTree(Element[] elements, int middleScreen)
        {
            this.middleScreen = middleScreen;
            this.elements = elements;
            foreach (Element e in elements)
            {
                insert(e);
            }
        }

        Node root; // koren stabla

        // dodavanje elementa u stablo
        public void insert(Element e)
        {
            if (root == null)
            {
                root = new Node(e);
                return;
            }

            insertRec(e, root);
        }

        // rekurzivno dodavanje elementa u stablo
        private void insertRec(Element e, Node n)
        {
            if (e.Broj > n.inner.Broj)
            {
                if  (n.right == null)
                {
                    n.right = new Node(e);
                    return;
                }
                insertRec(e, n.right);
            }
            else
            {
                if (n.left == null)
                {
                    n.left = new Node(e);
                    return;
                }
                insertRec(e, n.left);
            }
        }

        private int i; // indeks elementa
        // menja koordinata tako da pravi novu (sortiranu) listu od stabla
        public void inOrder()
        {
            i = 0;
            inOrderRec(root);
            ElementList.BSTLines = null;
        }

        // racuna x koordinatu na osnovu indeksa u listi
        private int calcX(int index)
        {
            return (middleScreen + index * 50) - 350;
        }

        // rekurzivni inorder algoritam
        private void inOrderRec(Node n)
        {
            if (n == null) return;

            inOrderRec(n.left);
            n.inner.translateTo(calcX(i) + 10 * i, 100);
            i++;
            inOrderRec(n.right);
        }

        // menja koordinate elementa i postavlja ga na odgovarajucu poziciju
        // pravi stablo od liste
        public void changeCoordinates()
        {
            int startX = elements[5].X + elements[5].Width / 2;
            int startY = elements[5].Y + elements[5].Width + 50;
            foreach (Element e in elements)
            {
                giveCoordinates(root, e, startX, startY);
            }
        }

        // daje koordinate odredjenom elementu
        private void giveCoordinates(Node n, Element e, int x, int y)
        {
            if (n == null) return;
            if (e == n.inner)
            {
                e.translateTo(x, y);
            }
            else if (e.Broj > n.inner.Broj)
            {
                ElementList.BSTLines
                    .Add(new Tuple<Point, Point>(
                        new Point(n.inner.X + n.inner.Width, n.inner.Y + n.inner.Width),
                        new Point(x + (int)(e.Width * 2), y + e.Width + 9)));
                giveCoordinates(n.right, e, x + e.Width + 30, y + e.Width + 10);
            }
            else
            {
                ElementList.BSTLines
                    .Add(new Tuple<Point, Point>(
                        new Point(n.inner.X, n.inner.Y + n.inner.Width),
                        new Point(x - e.Width, y + e.Width + 9)));
                giveCoordinates(n.left, e, x - e.Width - 30, y + e.Width + 10);
            }
        }
    }
}
