using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wFiguras
{
    public abstract class Figura
    {
        public Color Color { get; set; }
        public Point Posicion { get; set; }

        public Figura(Point posicion, Color color)
        {
            Posicion = posicion;
            Color = color;
        }
        protected bool EstaDentroDeLimites(Rectangle area, PictureBox pb)
        {
            return pb.ClientRectangle.Contains(area);
        }
        protected bool EstaDentroDeLimites(Point p1, Point p2, PictureBox pb)
        {
            return pb.ClientRectangle.Contains(p1) && pb.ClientRectangle.Contains(p2);
        }

        public abstract bool Dibujar(Graphics g, PictureBox pb);

    }
}
