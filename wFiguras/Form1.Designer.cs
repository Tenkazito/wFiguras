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
            this.pictureBoxColor = new System.Windows.Forms.PictureBox();
            this.cmbFigura = new System.Windows.Forms.ComboBox();
            this.txtContador = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.nudXBase = new System.Windows.Forms.NumericUpDown();
            this.nudYBase = new System.Windows.Forms.NumericUpDown();
            this.lblYBase = new System.Windows.Forms.Label();
            this.lblTamaño = new System.Windows.Forms.Label();
            this.nudTamaño = new System.Windows.Forms.NumericUpDown();
            this.lblYDos = new System.Windows.Forms.Label();
            this.nudYSegundaPosicion = new System.Windows.Forms.NumericUpDown();
            this.nudXSegundaPosicion = new System.Windows.Forms.NumericUpDown();
            this.lblXDos = new System.Windows.Forms.Label();
            this.lblSegundaPosicion = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pictureBoxLienzo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamaño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYSegundaPosicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXSegundaPosicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLienzo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFigura
            // 
            this.lblFigura.AutoSize = true;
            this.lblFigura.Location = new System.Drawing.Point(103, 71);
            this.lblFigura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFigura.Name = "lblFigura";
            this.lblFigura.Size = new System.Drawing.Size(45, 16);
            this.lblFigura.TabIndex = 0;
            this.lblFigura.Text = "Figura";
            // 
            // lblPosicionBase
            // 
            this.lblPosicionBase.AutoSize = true;
            this.lblPosicionBase.Location = new System.Drawing.Point(132, 137);
            this.lblPosicionBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosicionBase.Name = "lblPosicionBase";
            this.lblPosicionBase.Size = new System.Drawing.Size(93, 16);
            this.lblPosicionBase.TabIndex = 1;
            this.lblPosicionBase.Text = "Posicion base";
            // 
            // lblXBase
            // 
            this.lblXBase.AutoSize = true;
            this.lblXBase.Location = new System.Drawing.Point(262, 137);
            this.lblXBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXBase.Name = "lblXBase";
            this.lblXBase.Size = new System.Drawing.Size(15, 16);
            this.lblXBase.TabIndex = 2;
            this.lblXBase.Text = "X";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(504, 68);
            this.lblContador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(62, 16);
            this.lblContador.TabIndex = 3;
            this.lblContador.Text = "Contador";
            // 
            // pictureBoxColor
            // 
            this.pictureBoxColor.Location = new System.Drawing.Point(376, 46);
            this.pictureBoxColor.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxColor.Name = "pictureBoxColor";
            this.pictureBoxColor.Size = new System.Drawing.Size(52, 46);
            this.pictureBoxColor.TabIndex = 4;
            this.pictureBoxColor.TabStop = false;
            this.pictureBoxColor.Click += new System.EventHandler(this.pictureBoxColor_Click_1);
            // 
            // cmbFigura
            // 
            this.cmbFigura.FormattingEnabled = true;
            this.cmbFigura.Location = new System.Drawing.Point(159, 68);
            this.cmbFigura.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFigura.Name = "cmbFigura";
            this.cmbFigura.Size = new System.Drawing.Size(160, 24);
            this.cmbFigura.TabIndex = 5;
            this.cmbFigura.SelectedIndexChanged += new System.EventHandler(this.cmbFigura_SelectedIndexChanged);
            // 
            // txtContador
            // 
            this.txtContador.Location = new System.Drawing.Point(579, 65);
            this.txtContador.Margin = new System.Windows.Forms.Padding(4);
            this.txtContador.Name = "txtContador";
            this.txtContador.Size = new System.Drawing.Size(160, 22);
            this.txtContador.TabIndex = 9;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(135, 224);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(133, 36);
            this.btnCrear.TabIndex = 10;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // nudXBase
            // 
            this.nudXBase.Location = new System.Drawing.Point(285, 135);
            this.nudXBase.Name = "nudXBase";
            this.nudXBase.Size = new System.Drawing.Size(120, 22);
            this.nudXBase.TabIndex = 11;
            // 
            // nudYBase
            // 
            this.nudYBase.Location = new System.Drawing.Point(435, 135);
            this.nudYBase.Name = "nudYBase";
            this.nudYBase.Size = new System.Drawing.Size(120, 22);
            this.nudYBase.TabIndex = 12;
            // 
            // lblYBase
            // 
            this.lblYBase.AutoSize = true;
            this.lblYBase.Location = new System.Drawing.Point(412, 137);
            this.lblYBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYBase.Name = "lblYBase";
            this.lblYBase.Size = new System.Drawing.Size(16, 16);
            this.lblYBase.TabIndex = 13;
            this.lblYBase.Text = "Y";
            // 
            // lblTamaño
            // 
            this.lblTamaño.AutoSize = true;
            this.lblTamaño.Location = new System.Drawing.Point(576, 137);
            this.lblTamaño.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTamaño.Name = "lblTamaño";
            this.lblTamaño.Size = new System.Drawing.Size(58, 16);
            this.lblTamaño.TabIndex = 14;
            this.lblTamaño.Text = "Tamaño";
            // 
            // nudTamaño
            // 
            this.nudTamaño.Location = new System.Drawing.Point(641, 135);
            this.nudTamaño.Name = "nudTamaño";
            this.nudTamaño.Size = new System.Drawing.Size(120, 22);
            this.nudTamaño.TabIndex = 15;
            // 
            // lblYDos
            // 
            this.lblYDos.AutoSize = true;
            this.lblYDos.Location = new System.Drawing.Point(412, 174);
            this.lblYDos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYDos.Name = "lblYDos";
            this.lblYDos.Size = new System.Drawing.Size(16, 16);
            this.lblYDos.TabIndex = 20;
            this.lblYDos.Text = "Y";
            // 
            // nudYSegundaPosicion
            // 
            this.nudYSegundaPosicion.Location = new System.Drawing.Point(435, 172);
            this.nudYSegundaPosicion.Name = "nudYSegundaPosicion";
            this.nudYSegundaPosicion.Size = new System.Drawing.Size(120, 22);
            this.nudYSegundaPosicion.TabIndex = 19;
            // 
            // nudXSegundaPosicion
            // 
            this.nudXSegundaPosicion.Location = new System.Drawing.Point(285, 172);
            this.nudXSegundaPosicion.Name = "nudXSegundaPosicion";
            this.nudXSegundaPosicion.Size = new System.Drawing.Size(120, 22);
            this.nudXSegundaPosicion.TabIndex = 18;
            // 
            // lblXDos
            // 
            this.lblXDos.AutoSize = true;
            this.lblXDos.Location = new System.Drawing.Point(262, 174);
            this.lblXDos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXDos.Name = "lblXDos";
            this.lblXDos.Size = new System.Drawing.Size(15, 16);
            this.lblXDos.TabIndex = 17;
            this.lblXDos.Text = "X";
            // 
            // lblSegundaPosicion
            // 
            this.lblSegundaPosicion.AutoSize = true;
            this.lblSegundaPosicion.Location = new System.Drawing.Point(132, 174);
            this.lblSegundaPosicion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSegundaPosicion.Name = "lblSegundaPosicion";
            this.lblSegundaPosicion.Size = new System.Drawing.Size(116, 16);
            this.lblSegundaPosicion.TabIndex = 16;
            this.lblSegundaPosicion.Text = "Segunda posicion";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(295, 224);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(133, 36);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pictureBoxLienzo
            // 
            this.pictureBoxLienzo.Location = new System.Drawing.Point(39, 284);
            this.pictureBoxLienzo.Name = "pictureBoxLienzo";
            this.pictureBoxLienzo.Size = new System.Drawing.Size(993, 258);
            this.pictureBoxLienzo.TabIndex = 22;
            this.pictureBoxLienzo.TabStop = false;
            // 
            // frmFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBoxLienzo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblYDos);
            this.Controls.Add(this.nudYSegundaPosicion);
            this.Controls.Add(this.nudXSegundaPosicion);
            this.Controls.Add(this.lblXDos);
            this.Controls.Add(this.lblSegundaPosicion);
            this.Controls.Add(this.nudTamaño);
            this.Controls.Add(this.lblTamaño);
            this.Controls.Add(this.lblYBase);
            this.Controls.Add(this.nudYBase);
            this.Controls.Add(this.nudXBase);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtContador);
            this.Controls.Add(this.cmbFigura);
            this.Controls.Add(this.pictureBoxColor);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.lblXBase);
            this.Controls.Add(this.lblPosicionBase);
            this.Controls.Add(this.lblFigura);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFormulario";
            this.Text = "Formulario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamaño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYSegundaPosicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXSegundaPosicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLienzo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFigura;
        private System.Windows.Forms.Label lblPosicionBase;
        private System.Windows.Forms.Label lblXBase;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.PictureBox pictureBoxColor;
        private System.Windows.Forms.ComboBox cmbFigura;
        private System.Windows.Forms.TextBox txtContador;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.NumericUpDown nudXBase;
        private System.Windows.Forms.NumericUpDown nudYBase;
        private System.Windows.Forms.Label lblYBase;
        private System.Windows.Forms.Label lblTamaño;
        private System.Windows.Forms.NumericUpDown nudTamaño;
        private System.Windows.Forms.Label lblYDos;
        private System.Windows.Forms.NumericUpDown nudYSegundaPosicion;
        private System.Windows.Forms.NumericUpDown nudXSegundaPosicion;
        private System.Windows.Forms.Label lblXDos;
        private System.Windows.Forms.Label lblSegundaPosicion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.PictureBox pictureBoxLienzo;
    }
}

