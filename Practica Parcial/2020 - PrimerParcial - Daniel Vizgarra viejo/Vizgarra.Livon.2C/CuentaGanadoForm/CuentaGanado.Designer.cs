namespace CuentaGanadoForm
{
    partial class CuentaGanadoForm
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
            this.lblEmbpleados = new System.Windows.Forms.Label();
            this.nudEmpleados = new System.Windows.Forms.NumericUpDown();
            this.btnInforme = new System.Windows.Forms.Button();
            this.nudGente = new System.Windows.Forms.NumericUpDown();
            this.lblGente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmbpleados
            // 
            this.lblEmbpleados.AutoSize = true;
            this.lblEmbpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmbpleados.ForeColor = System.Drawing.Color.Black;
            this.lblEmbpleados.Location = new System.Drawing.Point(11, 22);
            this.lblEmbpleados.Name = "lblEmbpleados";
            this.lblEmbpleados.Size = new System.Drawing.Size(177, 37);
            this.lblEmbpleados.TabIndex = 0;
            this.lblEmbpleados.Text = "Empleados";
            // 
            // nudEmpleados
            // 
            this.nudEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEmpleados.Location = new System.Drawing.Point(258, 12);
            this.nudEmpleados.Name = "nudEmpleados";
            this.nudEmpleados.Size = new System.Drawing.Size(126, 53);
            this.nudEmpleados.TabIndex = 1;
            this.nudEmpleados.ValueChanged += new System.EventHandler(this.nudEmpleados_ValueChanged);
            // 
            // btnInforme
            // 
            this.btnInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInforme.ForeColor = System.Drawing.Color.Black;
            this.btnInforme.Location = new System.Drawing.Point(258, 146);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(126, 33);
            this.btnInforme.TabIndex = 2;
            this.btnInforme.Text = "INFORME";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // nudGente
            // 
            this.nudGente.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGente.Location = new System.Drawing.Point(258, 76);
            this.nudGente.Name = "nudGente";
            this.nudGente.Size = new System.Drawing.Size(126, 53);
            this.nudGente.TabIndex = 3;
            this.nudGente.ValueChanged += new System.EventHandler(this.nudGente_ValueChanged);
            // 
            // lblGente
            // 
            this.lblGente.AutoSize = true;
            this.lblGente.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGente.ForeColor = System.Drawing.Color.Black;
            this.lblGente.Location = new System.Drawing.Point(12, 86);
            this.lblGente.Name = "lblGente";
            this.lblGente.Size = new System.Drawing.Size(103, 37);
            this.lblGente.TabIndex = 4;
            this.lblGente.Text = "Gente";
            // 
            // CuentaGanadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(396, 191);
            this.Controls.Add(this.lblGente);
            this.Controls.Add(this.nudGente);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.nudEmpleados);
            this.Controls.Add(this.lblEmbpleados);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "CuentaGanadoForm";
            this.Text = "Contador de Daniel Vizgarra";
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmbpleados;
        private System.Windows.Forms.NumericUpDown nudEmpleados;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.NumericUpDown nudGente;
        private System.Windows.Forms.Label lblGente;
    }
}

