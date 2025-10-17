using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wFiguras
{
    public class Linea : Figura
    {
        public Point Fin { get; set; }

        public Linea(Point posicion, Color color, Point posicion2)
            : base(posicion, color)
        {
            Fin = posicion2;
        }

        public override void Dibujar(Graphics g)
        {
            using (Pen lapiz = new Pen(Color, 2))
                g.DrawLine(lapiz, Posicion, Fin);
        }
    }
}
