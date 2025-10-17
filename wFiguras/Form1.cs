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
            pictureBoxColor.BackColor = colorSeleccionado;
            configurarVisibilidad(false);
            pictureBoxLienzo.Paint += pictureBoxLienzo_Paint;
            pictureBoxLienzo.BackColor = Color.White;
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
            int valorBaseX = (int)nudXBase.Value;
            int valorBaseY = (int)nudYBase.Value;
            int tamaño = (int)nudTamaño.Value;
            int valorExtraX = (int)nudXSegundaPosicion.Value;
            int valorExtraY = (int)nudYSegundaPosicion.Value;
            if (tipo == "Linea" && (valorExtraX == 0 || valorExtraY == 0))
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos para los campos de la segunda posicion.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (valorBaseX < 0 || valorBaseY < 0 || (tipo != "Linea" && tamaño == 0))
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos para los campos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Figura figura = FiguraFactory.CrearFigura(tipo, new Point(valorBaseX, valorBaseY), colorSeleccionado, new Point(valorExtraX, valorExtraY), tamaño);

                if (figura != null)
                {
                    figuras.Add(figura);
                    contador++;
                    txtContador.Text = contador.ToString();

                    cmbFigura.SelectedIndex = 0;
                    limpiarCampos();
                    pictureBoxLienzo.Invalidate();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxColor_Click_1(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    colorSeleccionado = colorDialog.Color;
                    pictureBoxColor.BackColor = colorSeleccionado;
                }
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
            nudXSegundaPosicion.Visible = activo;
            lblYDos.Visible = activo;
            nudYSegundaPosicion.Visible = activo;
        }

        private void pictureBoxLienzo_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figura figura in figuras)
            {
                figura.Dibujar(e.Graphics);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            figuras.Clear();
            contador = 0;
            txtContador.Text = "0";
            pictureBoxLienzo.Invalidate();
        }

        private void limpiarCampos()
        {
            nudXBase.Value = 0;
            nudYBase.Value = 0;
            nudTamaño.Value = 0;
            nudXSegundaPosicion.Value = 0;
            nudYSegundaPosicion.Value = 0;
        }
    }
}