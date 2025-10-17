using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public override bool Dibujar(Graphics g, PictureBox pb)
        {
            if (!EstaDentroDeLimites(Posicion, Fin, pb))
            {
                MessageBox.Show("Error: Puntos de la línea fuera del lienzo.",
                                "Error de límites", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            using (Pen lapiz = new Pen(Color, 2))
                g.DrawLine(lapiz, Posicion, Fin);

            return true;
        }
    }
}
