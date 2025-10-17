using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wFiguras
{
    public class Triangulo : Figura
    {
        public int Tamaño { get; set; }

        public Triangulo(Point posicion, Color color, int tamaño)
            : base(posicion, color)
        {
            Tamaño = tamaño;
        }

        public override void Dibujar(Graphics g)
        {
            Point[] puntos =
            {
                Posicion,
                new Point(Posicion.X + Tamaño, Posicion.Y),
                new Point(Posicion.X + Tamaño / 2, Posicion.Y - Tamaño)
            };

            using (Brush brocha = new SolidBrush(Color))
                g.FillPolygon(brocha, puntos);
        }
    }
}
