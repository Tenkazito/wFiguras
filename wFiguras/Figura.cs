using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public abstract void Dibujar(Graphics g);
    }
}
