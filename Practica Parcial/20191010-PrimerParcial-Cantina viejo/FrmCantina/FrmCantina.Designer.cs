namespace FrmCantina
{
    partial class FrmCantina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCantina));
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.nudCapacidad = new System.Windows.Forms.NumericUpDown();
            this.cmbBotellaTipo = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rdbCerveza = new System.Windows.Forms.RadioButton();
            this.rdbAgua = new System.Windows.Forms.RadioButton();
            this.lblBotellaTipo = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            this.nudContenido = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.barra1 = new ControlCantina.Barra();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContenido)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(174, 22);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(177, 40);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 1;
            // 
            // nudCapacidad
            // 
            this.nudCapacidad.Location = new System.Drawing.Point(177, 101);
            this.nudCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCapacidad.Name = "nudCapacidad";
            this.nudCapacidad.Size = new System.Drawing.Size(70, 20);
            this.nudCapacidad.TabIndex = 2;
            this.nudCapacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // cmbBotellaTipo
            // 
            this.cmbBotellaTipo.FormattingEnabled = true;
            this.cmbBotellaTipo.Location = new System.Drawing.Point(352, 39);
            this.cmbBotellaTipo.Name = "cmbBotellaTipo";
            this.cmbBotellaTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbBotellaTipo.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(381, 83);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 38);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // rdbCerveza
            // 
            this.rdbCerveza.AutoSize = true;
            this.rdbCerveza.Location = new System.Drawing.Point(38, 20);
            this.rdbCerveza.Name = "rdbCerveza";
            this.rdbCerveza.Size = new System.Drawing.Size(64, 17);
            this.rdbCerveza.TabIndex = 5;
            this.rdbCerveza.TabStop = true;
            this.rdbCerveza.Text = "Cerveza";
            this.rdbCerveza.UseVisualStyleBackColor = true;
            // 
            // rdbAgua
            // 
            this.rdbAgua.AutoSize = true;
            this.rdbAgua.Location = new System.Drawing.Point(37, 83);
            this.rdbAgua.Name = "rdbAgua";
            this.rdbAgua.Size = new System.Drawing.Size(50, 17);
            this.rdbAgua.TabIndex = 6;
            this.rdbAgua.TabStop = true;
            this.rdbAgua.Text = "Agua";
            this.rdbAgua.UseVisualStyleBackColor = true;
            // 
            // lblBotellaTipo
            // 
            this.lblBotellaTipo.AutoSize = true;
            this.lblBotellaTipo.Location = new System.Drawing.Point(350, 24);
            this.lblBotellaTipo.Name = "lblBotellaTipo";
            this.lblBotellaTipo.Size = new System.Drawing.Size(63, 13);
            this.lblBotellaTipo.TabIndex = 7;
            this.lblBotellaTipo.Text = "Botella Tipo";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(174, 85);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lblCapacidad.TabIndex = 8;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(279, 85);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(55, 13);
            this.lblContenido.TabIndex = 9;
            this.lblContenido.Text = "Contenido";
            // 
            // nudContenido
            // 
            this.nudContenido.Location = new System.Drawing.Point(282, 101);
            this.nudContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudContenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudContenido.Name = "nudContenido";
            this.nudContenido.Size = new System.Drawing.Size(70, 20);
            this.nudContenido.TabIndex = 10;
            this.nudContenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.rdbCerveza);
            this.panel1.Controls.Add(this.nudContenido);
            this.panel1.Controls.Add(this.lblMarca);
            this.panel1.Controls.Add(this.lblContenido);
            this.panel1.Controls.Add(this.txtMarca);
            this.panel1.Controls.Add(this.lblCapacidad);
            this.panel1.Controls.Add(this.nudCapacidad);
            this.panel1.Controls.Add(this.lblBotellaTipo);
            this.panel1.Controls.Add(this.cmbBotellaTipo);
            this.panel1.Controls.Add(this.rdbAgua);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Location = new System.Drawing.Point(12, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 137);
            this.panel1.TabIndex = 11;
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.Location = new System.Drawing.Point(12, -4);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(554, 293);
            this.barra1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "KK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 444);
            this.Controls.Add(this.barra1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCantina";
            this.Text = "Vizgarra.livon.2c";
            this.Load += new System.EventHandler(this.FormCantina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContenido)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.NumericUpDown nudCapacidad;
        private System.Windows.Forms.ComboBox cmbBotellaTipo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton rdbCerveza;
        private System.Windows.Forms.RadioButton rdbAgua;
        private System.Windows.Forms.Label lblBotellaTipo;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.NumericUpDown nudContenido;
        private System.Windows.Forms.Panel panel1;
        private ControlCantina.Barra barra1;
        private System.Windows.Forms.Button button1;
    }
}

