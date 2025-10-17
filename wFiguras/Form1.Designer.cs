namespace wFiguras
{
    partial class frmFormulario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFigura = new System.Windows.Forms.Label();
            this.lblPosicionBase = new System.Windows.Forms.Label();
            this.lblXBase = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.cmbFigura = new System.Windows.Forms.ComboBox();
            this.txtContador = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.lblYBase = new System.Windows.Forms.Label();
            this.lblTamaño = new System.Windows.Forms.Label();
            this.nudTamaño = new System.Windows.Forms.NumericUpDown();
            this.lblYDos = new System.Windows.Forms.Label();
            this.nudY2 = new System.Windows.Forms.NumericUpDown();
            this.nudX2 = new System.Windows.Forms.NumericUpDown();
            this.lblXDos = new System.Windows.Forms.Label();
            this.lblSegundaPosicion = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pbLienzo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamaño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLienzo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFigura
            // 
            this.lblFigura.AutoSize = true;
            this.lblFigura.Location = new System.Drawing.Point(77, 58);
            this.lblFigura.Name = "lblFigura";
            this.lblFigura.Size = new System.Drawing.Size(36, 13);
            this.lblFigura.TabIndex = 0;
            this.lblFigura.Text = "Figura";
            // 
            // lblPosicionBase
            // 
            this.lblPosicionBase.AutoSize = true;
            this.lblPosicionBase.Location = new System.Drawing.Point(99, 111);
            this.lblPosicionBase.Name = "lblPosicionBase";
            this.lblPosicionBase.Size = new System.Drawing.Size(73, 13);
            this.lblPosicionBase.TabIndex = 1;
            this.lblPosicionBase.Text = "Posicion base";
            // 
            // lblXBase
            // 
            this.lblXBase.AutoSize = true;
            this.lblXBase.Location = new System.Drawing.Point(196, 111);
            this.lblXBase.Name = "lblXBase";
            this.lblXBase.Size = new System.Drawing.Size(14, 13);
            this.lblXBase.TabIndex = 2;
            this.lblXBase.Text = "X";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(378, 55);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(50, 13);
            this.lblContador.TabIndex = 3;
            this.lblContador.Text = "Contador";
            // 
            // pbColor
            // 
            this.pbColor.Location = new System.Drawing.Point(282, 37);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(39, 37);
            this.pbColor.TabIndex = 4;
            this.pbColor.TabStop = false;
            this.pbColor.Click += new System.EventHandler(this.pbColor_Click);
            // 
            // cmbFigura
            // 
            this.cmbFigura.FormattingEnabled = true;
            this.cmbFigura.Location = new System.Drawing.Point(119, 55);
            this.cmbFigura.Name = "cmbFigura";
            this.cmbFigura.Size = new System.Drawing.Size(121, 21);
            this.cmbFigura.TabIndex = 5;
            this.cmbFigura.SelectedIndexChanged += new System.EventHandler(this.cmbFigura_SelectedIndexChanged);
            // 
            // txtContador
            // 
            this.txtContador.Location = new System.Drawing.Point(434, 53);
            this.txtContador.Name = "txtContador";
            this.txtContador.Size = new System.Drawing.Size(121, 20);
            this.txtContador.TabIndex = 9;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(101, 182);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(100, 29);
            this.btnCrear.TabIndex = 10;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(214, 110);
            this.nudX.Margin = new System.Windows.Forms.Padding(2);
            this.nudX.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(90, 20);
            this.nudX.TabIndex = 11;
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(326, 110);
            this.nudY.Margin = new System.Windows.Forms.Padding(2);
            this.nudY.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(90, 20);
            this.nudY.TabIndex = 12;
            // 
            // lblYBase
            // 
            this.lblYBase.AutoSize = true;
            this.lblYBase.Location = new System.Drawing.Point(309, 111);
            this.lblYBase.Name = "lblYBase";
            this.lblYBase.Size = new System.Drawing.Size(14, 13);
            this.lblYBase.TabIndex = 13;
            this.lblYBase.Text = "Y";
            // 
            // lblTamaño
            // 
            this.lblTamaño.AutoSize = true;
            this.lblTamaño.Location = new System.Drawing.Point(432, 111);
            this.lblTamaño.Name = "lblTamaño";
            this.lblTamaño.Size = new System.Drawing.Size(46, 13);
            this.lblTamaño.TabIndex = 14;
            this.lblTamaño.Text = "Tamaño";
            // 
            // nudTamaño
            // 
            this.nudTamaño.Location = new System.Drawing.Point(481, 110);
            this.nudTamaño.Margin = new System.Windows.Forms.Padding(2);
            this.nudTamaño.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nudTamaño.Name = "nudTamaño";
            this.nudTamaño.Size = new System.Drawing.Size(90, 20);
            this.nudTamaño.TabIndex = 15;
            // 
            // lblYDos
            // 
            this.lblYDos.AutoSize = true;
            this.lblYDos.Location = new System.Drawing.Point(309, 141);
            this.lblYDos.Name = "lblYDos";
            this.lblYDos.Size = new System.Drawing.Size(14, 13);
            this.lblYDos.TabIndex = 20;
            this.lblYDos.Text = "Y";
            // 
            // nudY2
            // 
            this.nudY2.Location = new System.Drawing.Point(326, 140);
            this.nudY2.Margin = new System.Windows.Forms.Padding(2);
            this.nudY2.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudY2.Name = "nudY2";
            this.nudY2.Size = new System.Drawing.Size(90, 20);
            this.nudY2.TabIndex = 19;
            // 
            // nudX2
            // 
            this.nudX2.Location = new System.Drawing.Point(214, 140);
            this.nudX2.Margin = new System.Windows.Forms.Padding(2);
            this.nudX2.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudX2.Name = "nudX2";
            this.nudX2.Size = new System.Drawing.Size(90, 20);
            this.nudX2.TabIndex = 18;
            // 
            // lblXDos
            // 
            this.lblXDos.AutoSize = true;
            this.lblXDos.Location = new System.Drawing.Point(196, 141);
            this.lblXDos.Name = "lblXDos";
            this.lblXDos.Size = new System.Drawing.Size(14, 13);
            this.lblXDos.TabIndex = 17;
            this.lblXDos.Text = "X";
            // 
            // lblSegundaPosicion
            // 
            this.lblSegundaPosicion.AutoSize = true;
            this.lblSegundaPosicion.Location = new System.Drawing.Point(99, 141);
            this.lblSegundaPosicion.Name = "lblSegundaPosicion";
            this.lblSegundaPosicion.Size = new System.Drawing.Size(92, 13);
            this.lblSegundaPosicion.TabIndex = 16;
            this.lblSegundaPosicion.Text = "Segunda posicion";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(221, 182);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 29);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pbLienzo
            // 
            this.pbLienzo.Location = new System.Drawing.Point(29, 231);
            this.pbLienzo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLienzo.Name = "pbLienzo";
            this.pbLienzo.Size = new System.Drawing.Size(745, 210);
            this.pbLienzo.TabIndex = 22;
            this.pbLienzo.TabStop = false;
            // 
            // frmFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbLienzo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblYDos);
            this.Controls.Add(this.nudY2);
            this.Controls.Add(this.nudX2);
            this.Controls.Add(this.lblXDos);
            this.Controls.Add(this.lblSegundaPosicion);
            this.Controls.Add(this.nudTamaño);
            this.Controls.Add(this.lblTamaño);
            this.Controls.Add(this.lblYBase);
            this.Controls.Add(this.nudY);
            this.Controls.Add(this.nudX);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtContador);
            this.Controls.Add(this.cmbFigura);
            this.Controls.Add(this.pbColor);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.lblXBase);
            this.Controls.Add(this.lblPosicionBase);
            this.Controls.Add(this.lblFigura);
            this.Name = "frmFormulario";
            this.Text = "Formulario";
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamaño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLienzo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFigura;
        private System.Windows.Forms.Label lblPosicionBase;
        private System.Windows.Forms.Label lblXBase;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.PictureBox pbColor;
        private System.Windows.Forms.ComboBox cmbFigura;
        private System.Windows.Forms.TextBox txtContador;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.Label lblYBase;
        private System.Windows.Forms.Label lblTamaño;
        private System.Windows.Forms.NumericUpDown nudTamaño;
        private System.Windows.Forms.Label lblYDos;
        private System.Windows.Forms.NumericUpDown nudY2;
        private System.Windows.Forms.NumericUpDown nudX2;
        private System.Windows.Forms.Label lblXDos;
        private System.Windows.Forms.Label lblSegundaPosicion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.PictureBox pbLienzo;
    }
}

