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
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(161, 229);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(164, 247);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 1;
            // 
            // nudCapacidad
            // 
            this.nudCapacidad.Location = new System.Drawing.Point(164, 308);
            this.nudCapacidad.Name = "nudCapacidad";
            this.nudCapacidad.Size = new System.Drawing.Size(70, 20);
            this.nudCapacidad.TabIndex = 2;
            // 
            // cmbBotellaTipo
            // 
            this.cmbBotellaTipo.FormattingEnabled = true;
            this.cmbBotellaTipo.Location = new System.Drawing.Point(339, 246);
            this.cmbBotellaTipo.Name = "cmbBotellaTipo";
            this.cmbBotellaTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbBotellaTipo.TabIndex = 3;
            
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(368, 290);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 38);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // rdbCerveza
            // 
            this.rdbCerveza.AutoSize = true;
            this.rdbCerveza.Location = new System.Drawing.Point(25, 227);
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
            this.rdbAgua.Location = new System.Drawing.Point(24, 290);
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
            this.lblBotellaTipo.Location = new System.Drawing.Point(337, 231);
            this.lblBotellaTipo.Name = "lblBotellaTipo";
            this.lblBotellaTipo.Size = new System.Drawing.Size(63, 13);
            this.lblBotellaTipo.TabIndex = 7;
            this.lblBotellaTipo.Text = "Botella Tipo";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(161, 292);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lblCapacidad.TabIndex = 8;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(266, 292);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(55, 13);
            this.lblContenido.TabIndex = 9;
            this.lblContenido.Text = "Contenido";
            // 
            // nudContenido
            // 
            this.nudContenido.Location = new System.Drawing.Point(269, 308);
            this.nudContenido.Name = "nudContenido";
            this.nudContenido.Size = new System.Drawing.Size(70, 20);
            this.nudContenido.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 137);
            this.panel1.TabIndex = 11;
            // 
            // FrmCantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 354);
            this.Controls.Add(this.nudContenido);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.lblBotellaTipo);
            this.Controls.Add(this.rdbAgua);
            this.Controls.Add(this.rdbCerveza);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbBotellaTipo);
            this.Controls.Add(this.nudCapacidad);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCantina";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormCantina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContenido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

