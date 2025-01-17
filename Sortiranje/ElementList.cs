﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sortiranje
{
    /*
     * Klasa koja predstavlja listu elemenata
     */
    class ElementList
    {
        Element[] elements; // niz elemenata koji predstavlja listu
        public int Length { get { return elements.Length; } } // duzina liste
        private Form1 context; // referenca na glavnu formu

        public static List<Tuple<Point, Point>> BSTLines; // lista linija (pocetna tacka, krajnja tacka

        private int _middleScreen; // x koordinata sredine ekrana
        public int MiddleScreen {
            get { return _middleScreen; }
            set
            {
                if (elements == null) return;
                for (int i = 0; i < elements.Length; i++)
                {
                    // pomeranje liste na novu sredinu ekrana
                    elements[i].X = calcX(i) + 10 * i;
                }
            }
        }

        // pristupanje elementu unutar liste
        public Element this[int i]
        {
            get
            {
                return elements[i];
            }

            set
            {
                elements[i] = value;
            }
        }

        private static readonly Random rnd = new Random();

        // daje x koordinatu elementa na osnovu indeksa u listi
        private int calcX(int index)
        {
            return (MiddleScreen + index * 50) - 350;
        }

        public ElementList(Form1 context, int middle, List<int> intElements = null)
        {
            this.context = context;
            _middleScreen = middle;
            elements = new Element[10];
            if (intElements == null)
            {
                randomize();
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    elements[i] = new Element(context, intElements[i], calcX(i) + 10 * i, 100, 50);
                }
            }
                
        }

        // postavlja nasumicne brojeve u elemente liste
        public void randomize()
        {
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = new Element(context, rnd.Next(0, 99), calcX(i) + 10 * i, 100, 50);
            }
        }

        // iscrtava sve elemente liste
        public void drawAll(Graphics g)
        {
            foreach (var el in elements)
            {
                el.draw(g);
            }

            // crtanje linija za stablo ako postoje
            if (BSTLines != null)
            {
                foreach (var line in BSTLines)
                {
                    g.DrawLine(Pens.Black, line.Item1, line.Item2);
                }
            }
        }

        // menja mesto dva elementa
        private void swap(int i1, int i2)
        {
            int x1 = elements[i1].X, y1 = elements[i1].Y;
            int x2 = elements[i2].X, y2 = elements[i2].Y;
            Thread up = new Thread(() =>
            {
                elements[i1].translateFromUp(x2, y2);
            });
            Thread down = new Thread(() =>
            {
                elements[i2].translateFromDown(x1, y1);
            });

            Form1.t1 = up;
            Form1.t2 = down;

            up.Start();
            down.Start();
            up.Join();
            down.Join();

            Element temp = elements[i1];
            elements[i1] = elements[i2];
            elements[i2] = temp;
        }

        public void BubbleSort()
        {
            bool swapped = false;
            for (int i = 0; i < elements.Length - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < elements.Length - i - 1; j++)
                {
                    if (elements[j].Broj > elements[j + 1].Broj)
                    {
                        swap(j, j + 1);
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }

            context.sorting = false;
        }

        public void QuickSort()
        {
            _qsort(0, elements.Length - 1);
            context.pivotX = context.pivotY = null;
            context.sorting = false;
            context.iX = context.iY = context.jX = context.jY = null;
        }

        private void _qsort(int left, int right)
        {
            if (left >= right) return;

            int pivotIndex = partition(left, right);
            if (pivotIndex > 1)
            {
                _qsort(left, pivotIndex - 1);
            }
            if (pivotIndex + 1 < right)
            {
                _qsort(pivotIndex + 1, right);
            }
        }

        private int partition(int left, int right)
        {
            Element pivot = elements[left];
            context.pivotX = pivot.X;
            context.pivotY = pivot.Y + 50;

            while (true)
            {
                while (elements[left].Broj  < pivot.Broj)
                {
                    left++;
                    
                }
                while (elements[right].Broj > pivot.Broj)
                {
                    right--;
                    
                }
                if (left < right)
                {
                    context.iX = elements[left].X;
                    context.iY = elements[left].Y;
                    context.jX = elements[right].X;
                    context.jY = elements[right].Y;
                    swap(left, right);
                }
                else
                {
                    return right;
                }
            }
            
        }

        public void BSTSort()
        {
            BSTLines = new List<Tuple<Point, Point>>();
            ElementTree tree = new ElementTree(elements, MiddleScreen);
            tree.changeCoordinates();
            tree.inOrder();
        }
    }
}
