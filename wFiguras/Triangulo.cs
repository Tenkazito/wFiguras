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
        public int Base { get; set; }
        public int Altura { get; set; }

        public Triangulo(Point posicion, Color color, int baseTriangulo, int altura)
            : base(posicion, color)
        {
            Base = baseTriangulo;
            Altura = altura;
        }

        public override void Dibujar(Graphics g)
        {
            Point[] puntos =
            {
                Posicion,
                new Point(Posicion.X + Base, Posicion.Y),
                new Point(Posicion.X + Base / 2, Posicion.Y - Altura)
            };

            using (Brush brocha = new SolidBrush(Color))
                g.FillPolygon(brocha, puntos);
        }
    }
}
