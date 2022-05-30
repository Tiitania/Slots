using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Slots
{
    class Randomizar
    {
        public int X { 
            get; set; }
        public int Y { 
            get; set; }
        public int Pos{ 
            get;  set;}

        public Graphics Gps { get; set; }
        private List<Bitmap> img;


        public Randomizar(Graphics gps,int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.Gps = gps;
            //agregar las imagenes para nuestros slots
            img = new List<Bitmap>();
            img.Add(Properties.Resources.cereza);
            img.Add(Properties.Resources.platano);
            img.Add(Properties.Resources.images);
            img.Add(Properties.Resources.san);
        }

        public void girar()
        {
            int gira;
            Random Nalazar = new Random();
            //asignar valor para el cambio de imagen
            int numeros = 0;
            numeros = Nalazar.Next(1, 50);
            gira = 0;

            for (int i = 0; i < numeros; i++)
            {
                //dibujar imagen
                Bitmap slots = new Bitmap(img[gira],new Size(109, 124));

                Gps.DrawImage(slots, X, Y);
                Pos = gira;
                Thread.Sleep(100);
                if (gira < (img.Count - 1))
                {
                    gira++;
                }
                else
                {
                    gira = 0;
                }
            }
            
        }
    }
}
