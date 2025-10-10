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

        private void pictureBoxColor_Click(object sender, EventArgs e)
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

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtX.Text, out int x) || !int.TryParse(txtY.Text, out int y))
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos para X e Y.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string tipo = cmbFigura.SelectedItem.ToString();
                Figura figura = FiguraFactory.CrearFigura(tipo, new Point(x, y), colorSeleccionado);

                if (figura != null)
                {
                    figuras.Add(figura);
                    contador++;
                    txtContador.Text = contador.ToString();

                    txtX.Clear();
                    txtY.Clear();
                    cmbFigura.SelectedIndex = 0;
                    txtX.Focus();

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
    }
}