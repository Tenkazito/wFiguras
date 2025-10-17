using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public override bool Dibujar(Graphics g, PictureBox pb)
        {
            Point pTop = Posicion;
            Point pLeft = new Point(Posicion.X - Tamaño / 2, Posicion.Y + Tamaño);
            Point pRight = new Point(Posicion.X + Tamaño / 2, Posicion.Y + Tamaño);

            Point[] puntos = { pTop, pLeft, pRight };
            Rectangle area = Rectangle.FromLTRB(
                Math.Min(pTop.X, Math.Min(pLeft.X, pRight.X)),
                Math.Min(pTop.Y, Math.Min(pLeft.Y, pRight.Y)),
                Math.Max(pTop.X, Math.Max(pLeft.X, pRight.X)),
                Math.Max(pTop.Y, Math.Max(pLeft.Y, pRight.Y))
            );

            if (!EstaDentroDeLimites(area, pb))
            {
                MessageBox.Show("Error: Posición/Tamaño fuera de rango.",
                                "Error de límites", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            using (Brush brocha = new SolidBrush(Color))
                g.FillPolygon(brocha, puntos);

            return true;
        }
    }
}

