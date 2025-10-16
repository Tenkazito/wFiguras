using System;
using System.Collections.Generic;
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
            this.Paint += frmFormulario_Paint;
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
            int valorBaseX = (int)nudXBase.Value;
            int valorBaseY = (int)nudYBase.Value;
            if (valorBaseX < 0 || valorBaseY < 0)
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos para X e Y.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string tipo = cmbFigura.SelectedItem.ToString();
                Figura figura = FiguraFactory.CrearFigura(tipo, new Point(valorBaseX, valorBaseY), colorSeleccionado);

                if (figura != null)
                {
                    figuras.Add(figura);
                    contador++;
                    txtContador.Text = contador.ToString();

                    cmbFigura.SelectedIndex = 0;

                    this.Invalidate();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFormulario_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figura figura in figuras)
            {
                figura.Dibujar(e.Graphics);
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
    }
}