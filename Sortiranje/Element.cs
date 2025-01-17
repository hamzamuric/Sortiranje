﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Sortiranje
{
    /*
     * Klasa koja predstavlja jedan element liste.
     */
    class Element
    {
        public int Broj { get; set; } // broj unutar elementa
        public int Width { get; set; } // sirina elementa
        public int X { get; set; } // x koordinata
        public int Y { get; set; } // y koordinata
        public bool Moving { get; set; } // da li se element krece
        private Form1 context; // referenca na formu
        private Pen pen;
        private Font font;
        private SolidBrush brush;
        private StringFormat formatCenter;
        private Rectangle rect; // pravougaonik za crtanje elementa
        private Rectangle rectString; // tekst u elementu

        /* 
         * Konstruktor koji prima referencu na glavnu formu, broj u elementu,
         * koordinate elementa i sirinu.
         */
        public Element(Form1 context, int broj, int x, int y, int width)
        {
            this.context = context;
            Broj = broj;
            Width = width;
            X = x;
            Y = y;
            Moving = false;
            
            pen = new Pen(Color.Black, 2);
            font = new Font("Arial", Width / 4);
            brush = new SolidBrush(Color.Black);
            formatCenter = new StringFormat();
            formatCenter.Alignment = StringAlignment.Center;
        }

        // iscrtava element
        public void draw(Graphics g)
        {
            rect = new Rectangle(X, Y, Width, Width);
            g.DrawRectangle(pen, rect); // crtanje okvira elementa
            g.FillRectangle(Brushes.Yellow, rect); // farbanje unutrasnjosti elementa
            rectString = new Rectangle(X, Y + Width / 3, Width, Width); // tekst u elementu
            g.DrawString(Broj.ToString(), font, brush, rectString, formatCenter);
        }

        // animirano transliranje elementa odozgo udesno/ulevo
        public void translateFromUp(int x, int y)
        {
            // pomeranje elementa na gore
            while (Y >= y - 60)
            {
                Y -= 7;
                Thread.Sleep(150 - context.animationSpeed);
                context.Invalidate();
            }

            // pomeranje udesno ili ulevo
            if (X < x)
            {
                while (x >= X)
                {
                    X += 7;
                    Thread.Sleep(150 - context.animationSpeed);
                    context.Invalidate();
                }
            }
            else
            {
                while (x <= X)
                {
                    X -= 7;
                    Thread.Sleep(150 - context.animationSpeed);
                    context.Invalidate();
                }
            }
            X = x; // ako se promeniza x koordinata vise nego sto je potrebno, vrati je na x iz argumenta

            // pomeranje na dole
            while (Y <= y)
            {
                Y += 7;
                Thread.Sleep(150 - context.animationSpeed);
                context.Invalidate();
            }
            Y = y; // ako se promeniza y koordinata vise nego sto je potrebno, vrati je na y iz argumenta
            context.Invalidate();
        }

        // animirano transliranje odozdo na levo/desno
        public void translateFromDown(int x, int y)
        {
            // pomeranje na dole
            while (Y <= y + 60)
            {
                Y += 7;
                Thread.Sleep(150 - context.animationSpeed);
                context.Invalidate();
            }

            // pomeranje na levo/desno
            if (X < x)
            {
                while (x >= X)
                {
                    X += 7;
                    Thread.Sleep(150 - context.animationSpeed);
                    context.Invalidate();
                }
            }
            else
            {
                while (x <= X)
                {
                    X -= 7;
                    Thread.Sleep(150 - context.animationSpeed);
                    context.Invalidate();
                }
            }
            X = x; // ako se promeniza x koordinata vise nego sto je potrebno, vrati je na x iz argumenta

            // pomeranje na gore
            while (Y >= y)
            {
                Y -= 7;
                Thread.Sleep(150 - context.animationSpeed);
                context.Invalidate();
            }
            Y = y; // ako se promeniza y koordinata vise nego sto je potrebno, vrati je na y iz argumenta
            context.Invalidate();
        }

        // pomeranje elementa na date koordinate
        public void translateTo(int x, int y)
        {
            int changeY;

            if (y > this.Y)
            {
                changeY = 5;
            }
            else
            {
                changeY = -5;
            }

            while (y != this.Y)
            {
                this.Y += changeY;
                Thread.Sleep(150 - context.animationSpeed);
                context.Invalidate();
            }

            if (this.Y != y) this.Y = y;

            int changeX;

            if (x > this.X)
            {
                changeX = 5;
            }
            else
            {
                changeX = -5;
            }

            while (x != this.X)
            {
                this.X += changeX;
                Thread.Sleep(150 - context.animationSpeed);
                context.Invalidate();
            }

            if (this.X != x) this.X = x;
        }
    }
}
