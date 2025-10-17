using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wFiguras
{
    public class Rectangulo : Figura
    {
        public int Tamaño { get; set; }

        public Rectangulo(Point posicion, Color color, int tamaño)
            : base(posicion, color)
        {
            Tamaño = tamaño;
        }

        public override void Dibujar(Graphics g)
        {
            using (Brush brocha = new SolidBrush(Color))
                g.FillRectangle(brocha, Posicion.X, Posicion.Y, Tamaño / 2, Tamaño);
        }
    }
}
