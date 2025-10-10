using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wFiguras
{
    public class Circulo : Figura
    {
        public int Radio { get; set; }

        public Circulo(Point posicion, Color color, int radio)
            : base(posicion, color)
        {
            Radio = radio;
        }

        public override void Dibujar(Graphics g)
        {
            using (Pen lapiz = new Pen(Color))
            {
                g.DrawEllipse(lapiz, Posicion.X, Posicion.Y, Radio * 2, Radio * 2);
            }
        }
    }
}
