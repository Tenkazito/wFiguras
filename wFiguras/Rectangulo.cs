using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public override bool Dibujar(Graphics g, PictureBox pb)
        {
            Rectangle area = new Rectangle(Posicion.X, Posicion.Y, Tamaño, Tamaño);

            if (!EstaDentroDeLimites(area, pb))
            {
                MessageBox.Show("Error: Posición/Tamaño fuera de rango.",
                                "Error de límites", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            using (Brush brocha = new SolidBrush(Color))
                g.FillRectangle(brocha, area);

            return true;
        }
    }
}

