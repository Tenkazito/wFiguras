using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wFiguras
{
    public class Circulo : Figura
    {
        public int Tamaño { get; set; }

        public Circulo(Point posicion, Color color, int tamaño)
            : base(posicion, color)
        {
            Tamaño = tamaño;
        }

        public override bool Dibujar(Graphics g, PictureBox pb)
        {
            Rectangle area = new Rectangle(Posicion.X - Tamaño / 2, Posicion.Y - Tamaño / 2, Tamaño, Tamaño);

            if (!EstaDentroDeLimites(area, pb))
            {
                MessageBox.Show("Error: Posición/Tamaño fuera de rango.",
                                "Error de límites", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            using (Brush brocha = new SolidBrush(Color))
                g.FillEllipse(brocha, area);

            return true;
        }

    }
}
