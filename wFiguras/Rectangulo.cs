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
        public int Ancho { get; set; }
        public int Largo { get; set; }

        public Rectangulo(Point posicion, Color color, int ancho, int largo)
            : base(posicion, color)
        {
            Ancho = ancho;
            Largo = largo;
        }

        public override void Dibujar(Graphics g)
        {
            using (Brush brocha = new SolidBrush(Color))
                g.FillRectangle(brocha, Posicion.X, Posicion.Y, Ancho, Largo);
        }
    }
}
