namespace MyForm
{
    partial class Form1
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
            this.btnConvertF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFValue = new System.Windows.Forms.TextBox();
            this.txtFF = new System.Windows.Forms.TextBox();
            this.txtFC = new System.Windows.Forms.TextBox();
            this.txtFK = new System.Windows.Forms.TextBox();
            this.txtCK = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.txtCF = new System.Windows.Forms.TextBox();
            this.txtCValue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConvertC = new System.Windows.Forms.Button();
            this.txtKK = new System.Windows.Forms.TextBox();
            this.txtKC = new System.Windows.Forms.TextBox();
            this.txtKF = new System.Windows.Forms.TextBox();
            this.txtKValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnConvertK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvertF
            // 
            this.btnConvertF.Location = new System.Drawing.Point(186, 61);
            this.btnConvertF.Name = "btnConvertF";
            this.btnConvertF.Size = new System.Drawing.Size(75, 23);
            this.btnConvertF.TabIndex = 0;
            this.btnConvertF.Text = "->";
            this.btnConvertF.UseVisualStyleBackColor = true;
            this.btnConvertF.Click += new System.EventHandler(this.btnConvertF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Farhenheit";
            // 
            // txtFValue
            // 
            this.txtFValue.Location = new System.Drawing.Point(80, 63);
            this.txtFValue.Name = "txtFValue";
            this.txtFValue.Size = new System.Drawing.Size(100, 20);
            this.txtFValue.TabIndex = 2;
            // 
            // txtFF
            // 
            this.txtFF.Location = new System.Drawing.Point(267, 63);
            this.txtFF.Name = "txtFF";
            this.txtFF.Size = new System.Drawing.Size(100, 20);
            this.txtFF.TabIndex = 3;
            // 
            // txtFC
            // 
            this.txtFC.Location = new System.Drawing.Point(373, 63);
            this.txtFC.Name = "txtFC";
            this.txtFC.Size = new System.Drawing.Size(100, 20);
            this.txtFC.TabIndex = 4;
            // 
            // txtFK
            // 
            this.txtFK.Location = new System.Drawing.Point(479, 63);
            this.txtFK.Name = "txtFK";
            this.txtFK.Size = new System.Drawing.Size(100, 20);
            this.txtFK.TabIndex = 5;
            // 
            // txtCK
            // 
            this.txtCK.Location = new System.Drawing.Point(479, 93);
            this.txtCK.Name = "txtCK";
            this.txtCK.Size = new System.Drawing.Size(100, 20);
            this.txtCK.TabIndex = 14;
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(373, 93);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(100, 20);
            this.txtCC.TabIndex = 13;
            // 
            // txtCF
            // 
            this.txtCF.Location = new System.Drawing.Point(267, 93);
            this.txtCF.Name = "txtCF";
            this.txtCF.Size = new System.Drawing.Size(100, 20);
            this.txtCF.TabIndex = 12;
            // 
            // txtCValue
            // 
            this.txtCValue.Location = new System.Drawing.Point(80, 93);
            this.txtCValue.Name = "txtCValue";
            this.txtCValue.Size = new System.Drawing.Size(100, 20);
            this.txtCValue.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Celsius";
            // 
            // btnConvertC
            // 
            this.btnConvertC.Location = new System.Drawing.Point(186, 91);
            this.btnConvertC.Name = "btnConvertC";
            this.btnConvertC.Size = new System.Drawing.Size(75, 23);
            this.btnConvertC.TabIndex = 9;
            this.btnConvertC.Text = "->";
            this.btnConvertC.UseVisualStyleBackColor = true;
            this.btnConvertC.Click += new System.EventHandler(this.btnConvertC_Click);
            // 
            // txtKK
            // 
            this.txtKK.Location = new System.Drawing.Point(478, 123);
            this.txtKK.Name = "txtKK";
            this.txtKK.Size = new System.Drawing.Size(100, 20);
            this.txtKK.TabIndex = 20;
            // 
            // txtKC
            // 
            this.txtKC.Location = new System.Drawing.Point(372, 123);
            this.txtKC.Name = "txtKC";
            this.txtKC.Size = new System.Drawing.Size(100, 20);
            this.txtKC.TabIndex = 19;
            // 
            // txtKF
            // 
            this.txtKF.Location = new System.Drawing.Point(266, 123);
            this.txtKF.Name = "txtKF";
            this.txtKF.Size = new System.Drawing.Size(100, 20);
            this.txtKF.TabIndex = 18;
            // 
            // txtKValue
            // 
            this.txtKValue.Location = new System.Drawing.Point(79, 123);
            this.txtKValue.Name = "txtKValue";
            this.txtKValue.Size = new System.Drawing.Size(100, 20);
            this.txtKValue.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Kelvin";
            // 
            // btnConvertK
            // 
            this.btnConvertK.Location = new System.Drawing.Point(185, 121);
            this.btnConvertK.Name = "btnConvertK";
            this.btnConvertK.Size = new System.Drawing.Size(75, 23);
            this.btnConvertK.TabIndex = 15;
            this.btnConvertK.Text = "->";
            this.btnConvertK.UseVisualStyleBackColor = true;
            this.btnConvertK.Click += new System.EventHandler(this.btnConvertK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Farhenheit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Celsius";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Kelvin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 154);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKK);
            this.Controls.Add(this.txtKC);
            this.Controls.Add(this.txtKF);
            this.Controls.Add(this.txtKValue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnConvertK);
            this.Controls.Add(this.txtCK);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.txtCF);
            this.Controls.Add(this.txtCValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnConvertC);
            this.Controls.Add(this.txtFK);
            this.Controls.Add(this.txtFC);
            this.Controls.Add(this.txtFF);
            this.Controls.Add(this.txtFValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvertF);
            this.Name = "Form1";
            this.Text = "Conversor de Temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFValue;
        private System.Windows.Forms.TextBox txtFF;
        private System.Windows.Forms.TextBox txtFC;
        private System.Windows.Forms.TextBox txtFK;
        private System.Windows.Forms.TextBox txtCK;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.TextBox txtCF;
        private System.Windows.Forms.TextBox txtCValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConvertC;
        private System.Windows.Forms.TextBox txtKK;
        private System.Windows.Forms.TextBox txtKC;
        private System.Windows.Forms.TextBox txtKF;
        private System.Windows.Forms.TextBox txtKValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnConvertK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

