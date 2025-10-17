using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace wFiguras
{
    public partial class frmFormulario : Form
    {
        private Color colorSeleccionado = Color.Black;
        private int contador = 0;
        private List<Figura> figuras = new List<Figura>();

        public frmFormulario()
        {
            InitializeComponent();
            crearComboBox();
            txtContador.ReadOnly = true;
            pbColor.BackColor = colorSeleccionado;
            configurarVisibilidad(false);
            pbLienzo.Paint += pbLienzo_Paint;
            pbLienzo.BackColor = Color.White;
            cmbFigura.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void crearComboBox()
        {
            cmbFigura.Items.Clear();
            cmbFigura.Items.Add("Rectangulo");
            cmbFigura.Items.Add("Circulo");
            cmbFigura.Items.Add("Triangulo");
            cmbFigura.Items.Add("Linea");
            cmbFigura.SelectedIndex = 0;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string tipo = cmbFigura.SelectedItem.ToString();
            int valorBaseX = (int)nudX.Value;
            int valorBaseY = (int)nudY.Value;
            int tamaño = (int)nudTamaño.Value;
            int valorExtraX = (int)nudX2.Value;
            int valorExtraY = (int)nudY2.Value;

            if (valorBaseX < 0 || valorBaseY < 0)
            {
                MessageBox.Show("Las coordenadas deben ser mayores o iguales a 0.",
                                "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tipo != "Linea" && tamaño <= 0)
            {
                MessageBox.Show("El tamaño debe ser mayor que 0.",
                                "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tipo == "Linea" && (valorExtraX == 0 && valorExtraY == 0))
            {
                MessageBox.Show("La línea necesita una segunda posición (X2, Y2).",
                                "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Figura figura = FiguraFactory.CrearFigura(tipo, new Point(valorBaseX, valorBaseY), colorSeleccionado,
                    new Point(valorExtraX, valorExtraY), tamaño);

                using (Graphics g = pbLienzo.CreateGraphics())
                {
                    if (figura.Dibujar(g, pbLienzo))
                    {
                        figuras.Add(figura);
                        contador++;
                        txtContador.Text = contador.ToString();
                        limpiarCampos();
                        pbLienzo.Invalidate();
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbFigura_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cmbFigura.SelectedItem.ToString();
            if (tipo == "Linea")
            {
                configurarVisibilidad(true);
                lblTamaño.Visible = false;
                nudTamaño.Visible = false;
            }
            else
            {
                configurarVisibilidad(false);
                lblTamaño.Visible = true;
                nudTamaño.Visible = true;
            }
        }

        private void configurarVisibilidad(bool activo)
        {
            lblSegundaPosicion.Visible = activo;
            lblXDos.Visible = activo;
            nudX2.Visible = activo;
            lblYDos.Visible = activo;
            nudY2.Visible = activo;
        }

        private void pbLienzo_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Red, 0, 0, pbLienzo.Width - 1, pbLienzo.Height - 1);
            e.Graphics.DrawString(
                $"Área real: {pbLienzo.ClientSize.Width} x {pbLienzo.ClientSize.Height}",
                this.Font,
                Brushes.Black,
                new PointF(5, 5)
            );
            foreach (Figura figura in figuras)
            {
                figura.Dibujar(e.Graphics, pbLienzo);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            figuras.Clear();
            contador = 0;
            txtContador.Text = "0";
            pbLienzo.Invalidate();
        }

        private void limpiarCampos()
        {
            nudX.Value = 0;
            nudY.Value = 0;
            nudTamaño.Value = 0;
            nudX2.Value = 0;
            nudY2.Value = 0;
        }

        private void pbColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    colorSeleccionado = colorDialog.Color;
                    pbColor.BackColor = colorSeleccionado;
                }
            }
        }
    }
}