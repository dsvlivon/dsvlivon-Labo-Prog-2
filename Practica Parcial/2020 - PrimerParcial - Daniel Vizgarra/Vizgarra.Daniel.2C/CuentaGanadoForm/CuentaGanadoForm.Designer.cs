namespace CuentaGanadoForm
{
    partial class CuentaGanadoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInforme = new System.Windows.Forms.Button();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.nudEmpleados = new System.Windows.Forms.NumericUpDown();
            this.nudGente = new System.Windows.Forms.NumericUpDown();
            this.lblGente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInforme
            // 
            this.btnInforme.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInforme.Location = new System.Drawing.Point(339, 180);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(232, 47);
            this.btnInforme.TabIndex = 0;
            this.btnInforme.Text = "INFORME";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.Location = new System.Drawing.Point(12, 19);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(298, 63);
            this.lblEmpleados.TabIndex = 1;
            this.lblEmpleados.Text = "Empleados";
            // 
            // nudEmpleados
            // 
            this.nudEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEmpleados.Location = new System.Drawing.Point(339, 14);
            this.nudEmpleados.Name = "nudEmpleados";
            this.nudEmpleados.Size = new System.Drawing.Size(232, 68);
            this.nudEmpleados.TabIndex = 2;
            this.nudEmpleados.ValueChanged += new System.EventHandler(this.nudEmpleados_ValueChanged);
            // 
            // nudGente
            // 
            this.nudGente.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGente.Location = new System.Drawing.Point(339, 92);
            this.nudGente.Name = "nudGente";
            this.nudGente.Size = new System.Drawing.Size(232, 68);
            this.nudGente.TabIndex = 4;
            this.nudGente.ValueChanged += new System.EventHandler(this.nudGente_ValueChanged);
            // 
            // lblGente
            // 
            this.lblGente.AutoSize = true;
            this.lblGente.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGente.Location = new System.Drawing.Point(12, 97);
            this.lblGente.Name = "lblGente";
            this.lblGente.Size = new System.Drawing.Size(174, 63);
            this.lblGente.TabIndex = 3;
            this.lblGente.Text = "Gente";
            // 
            // CuentaGanadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(586, 239);
            this.Controls.Add(this.nudGente);
            this.Controls.Add(this.lblGente);
            this.Controls.Add(this.nudEmpleados);
            this.Controls.Add(this.lblEmpleados);
            this.Controls.Add(this.btnInforme);
            this.Name = "CuentaGanadoForm";
            this.Text = "Contador de Daniel Vizgarra";
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.NumericUpDown nudEmpleados;
        private System.Windows.Forms.NumericUpDown nudGente;
        private System.Windows.Forms.Label lblGente;
    }
}