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

        public Linea(Point posicion, Color color)
            : base(posicion, color)
        {
            Fin = new Point(posicion.X + 50, posicion.Y);
        }

        public override void Dibujar(Graphics g)
        {
            using (Pen lapiz = new Pen(Color, 2))
                g.DrawLine(lapiz, Posicion, Fin);
        }
    }
}
