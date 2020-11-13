namespace VistaForm
{
    partial class FormVista
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
            this.gpbDAtosCurso = new System.Windows.Forms.GroupBox();
            this.nudAnioCurso = new System.Windows.Forms.NumericUpDown();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.btnCrearCurso = new System.Windows.Forms.Button();
            this.txtDocumentoProfe = new System.Windows.Forms.TextBox();
            this.lblAnioCurso = new System.Windows.Forms.Label();
            this.txtApellidoProfe = new System.Windows.Forms.TextBox();
            this.lblDivisionCurso = new System.Windows.Forms.Label();
            this.txtNombreProfe = new System.Windows.Forms.TextBox();
            this.lblNombreProfe = new System.Windows.Forms.Label();
            this.lblApellidoProfe = new System.Windows.Forms.Label();
            this.cmbDivisionCurso = new System.Windows.Forms.ComboBox();
            this.lblDocumentoProfe = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.gpbDAtosAlumnos = new System.Windows.Forms.GroupBox();
            this.btnMostrarAlumno = new System.Windows.Forms.Button();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.lblDivision = new System.Windows.Forms.Label();
            this.cmbDivision = new System.Windows.Forms.ComboBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.rtbDatos = new System.Windows.Forms.RichTextBox();
            this.gpbDAtosCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCurso)).BeginInit();
            this.gpbDAtosAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbDAtosCurso
            // 
            this.gpbDAtosCurso.Controls.Add(this.nudAnioCurso);
            this.gpbDAtosCurso.Controls.Add(this.btnMostrar);
            this.gpbDAtosCurso.Controls.Add(this.dtpFechaIngreso);
            this.gpbDAtosCurso.Controls.Add(this.btnCrearCurso);
            this.gpbDAtosCurso.Controls.Add(this.txtDocumentoProfe);
            this.gpbDAtosCurso.Controls.Add(this.lblAnioCurso);
            this.gpbDAtosCurso.Controls.Add(this.txtApellidoProfe);
            this.gpbDAtosCurso.Controls.Add(this.lblDivisionCurso);
            this.gpbDAtosCurso.Controls.Add(this.txtNombreProfe);
            this.gpbDAtosCurso.Controls.Add(this.lblNombreProfe);
            this.gpbDAtosCurso.Controls.Add(this.lblApellidoProfe);
            this.gpbDAtosCurso.Controls.Add(this.cmbDivisionCurso);
            this.gpbDAtosCurso.Controls.Add(this.lblDocumentoProfe);
            this.gpbDAtosCurso.Controls.Add(this.lblFechaIngreso);
            this.gpbDAtosCurso.Location = new System.Drawing.Point(12, 12);
            this.gpbDAtosCurso.Name = "gpbDAtosCurso";
            this.gpbDAtosCurso.Size = new System.Drawing.Size(313, 248);
            this.gpbDAtosCurso.TabIndex = 0;
            this.gpbDAtosCurso.TabStop = false;
            this.gpbDAtosCurso.Text = "Datos del Curso";
            // 
            // nudAnioCurso
            // 
            this.nudAnioCurso.Location = new System.Drawing.Point(96, 19);
            this.nudAnioCurso.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudAnioCurso.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAnioCurso.Name = "nudAnioCurso";
            this.nudAnioCurso.Size = new System.Drawing.Size(120, 20);
            this.nudAnioCurso.TabIndex = 0;
            this.nudAnioCurso.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(185, 202);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(109, 40);
            this.btnMostrar.TabIndex = 7;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(93, 176);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaIngreso.TabIndex = 5;
            this.dtpFechaIngreso.ValueChanged += new System.EventHandler(this.dtpFechaIngreso_ValueChanged);
            // 
            // btnCrearCurso
            // 
            this.btnCrearCurso.Location = new System.Drawing.Point(16, 202);
            this.btnCrearCurso.Name = "btnCrearCurso";
            this.btnCrearCurso.Size = new System.Drawing.Size(109, 40);
            this.btnCrearCurso.TabIndex = 6;
            this.btnCrearCurso.Text = "Crear Curso";
            this.btnCrearCurso.UseVisualStyleBackColor = true;
            this.btnCrearCurso.Click += new System.EventHandler(this.btnCrearCurso_Click);
            // 
            // txtDocumentoProfe
            // 
            this.txtDocumentoProfe.Location = new System.Drawing.Point(94, 147);
            this.txtDocumentoProfe.Name = "txtDocumentoProfe";
            this.txtDocumentoProfe.Size = new System.Drawing.Size(199, 20);
            this.txtDocumentoProfe.TabIndex = 4;
            this.txtDocumentoProfe.TextChanged += new System.EventHandler(this.txtDocumentoProfe_TextChanged);
            // 
            // lblAnioCurso
            // 
            this.lblAnioCurso.AutoSize = true;
            this.lblAnioCurso.Location = new System.Drawing.Point(15, 26);
            this.lblAnioCurso.Name = "lblAnioCurso";
            this.lblAnioCurso.Size = new System.Drawing.Size(26, 13);
            this.lblAnioCurso.TabIndex = 8;
            this.lblAnioCurso.Text = "Año";
            // 
            // txtApellidoProfe
            // 
            this.txtApellidoProfe.Location = new System.Drawing.Point(95, 115);
            this.txtApellidoProfe.Name = "txtApellidoProfe";
            this.txtApellidoProfe.Size = new System.Drawing.Size(199, 20);
            this.txtApellidoProfe.TabIndex = 3;
            this.txtApellidoProfe.TextChanged += new System.EventHandler(this.txtApellidoProfe_TextChanged);
            // 
            // lblDivisionCurso
            // 
            this.lblDivisionCurso.AutoSize = true;
            this.lblDivisionCurso.Location = new System.Drawing.Point(13, 54);
            this.lblDivisionCurso.Name = "lblDivisionCurso";
            this.lblDivisionCurso.Size = new System.Drawing.Size(44, 13);
            this.lblDivisionCurso.TabIndex = 9;
            this.lblDivisionCurso.Text = "División";
            // 
            // txtNombreProfe
            // 
            this.txtNombreProfe.Location = new System.Drawing.Point(95, 84);
            this.txtNombreProfe.Name = "txtNombreProfe";
            this.txtNombreProfe.Size = new System.Drawing.Size(199, 20);
            this.txtNombreProfe.TabIndex = 2;
            this.txtNombreProfe.TextChanged += new System.EventHandler(this.txtNombreProfe_TextChanged);
            // 
            // lblNombreProfe
            // 
            this.lblNombreProfe.AutoSize = true;
            this.lblNombreProfe.Location = new System.Drawing.Point(15, 87);
            this.lblNombreProfe.Name = "lblNombreProfe";
            this.lblNombreProfe.Size = new System.Drawing.Size(44, 13);
            this.lblNombreProfe.TabIndex = 10;
            this.lblNombreProfe.Text = "Nombre";
            // 
            // lblApellidoProfe
            // 
            this.lblApellidoProfe.AutoSize = true;
            this.lblApellidoProfe.Location = new System.Drawing.Point(15, 118);
            this.lblApellidoProfe.Name = "lblApellidoProfe";
            this.lblApellidoProfe.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoProfe.TabIndex = 11;
            this.lblApellidoProfe.Text = "Apellido";
            // 
            // cmbDivisionCurso
            // 
            this.cmbDivisionCurso.FormattingEnabled = true;
            this.cmbDivisionCurso.Location = new System.Drawing.Point(95, 51);
            this.cmbDivisionCurso.Name = "cmbDivisionCurso";
            this.cmbDivisionCurso.Size = new System.Drawing.Size(121, 21);
            this.cmbDivisionCurso.TabIndex = 1;
            this.cmbDivisionCurso.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblDocumentoProfe
            // 
            this.lblDocumentoProfe.AutoSize = true;
            this.lblDocumentoProfe.Location = new System.Drawing.Point(17, 150);
            this.lblDocumentoProfe.Name = "lblDocumentoProfe";
            this.lblDocumentoProfe.Size = new System.Drawing.Size(26, 13);
            this.lblDocumentoProfe.TabIndex = 12;
            this.lblDocumentoProfe.Text = "DNI";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(17, 182);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(42, 13);
            this.lblFechaIngreso.TabIndex = 13;
            this.lblFechaIngreso.Text = "Ingreso";
         
            // 
            // gpbDAtosAlumnos
            // 
            this.gpbDAtosAlumnos.Controls.Add(this.btnMostrarAlumno);
            this.gpbDAtosAlumnos.Controls.Add(this.nudAnio);
            this.gpbDAtosAlumnos.Controls.Add(this.lblDivision);
            this.gpbDAtosAlumnos.Controls.Add(this.cmbDivision);
            this.gpbDAtosAlumnos.Controls.Add(this.lblAnio);
            this.gpbDAtosAlumnos.Controls.Add(this.btnAgregar);
            this.gpbDAtosAlumnos.Controls.Add(this.txtDocumento);
            this.gpbDAtosAlumnos.Controls.Add(this.txtApellido);
            this.gpbDAtosAlumnos.Controls.Add(this.txtNombre);
            this.gpbDAtosAlumnos.Controls.Add(this.lblNombre);
            this.gpbDAtosAlumnos.Controls.Add(this.lblApellido);
            this.gpbDAtosAlumnos.Controls.Add(this.lblDocumento);
            this.gpbDAtosAlumnos.Location = new System.Drawing.Point(334, 12);
            this.gpbDAtosAlumnos.Name = "gpbDAtosAlumnos";
            this.gpbDAtosAlumnos.Size = new System.Drawing.Size(313, 248);
            this.gpbDAtosAlumnos.TabIndex = 1;
            this.gpbDAtosAlumnos.TabStop = false;
            this.gpbDAtosAlumnos.Text = "Datos del Alumno";
            this.gpbDAtosAlumnos.Enter += new System.EventHandler(this.gpbDAtosAlumnos_Enter);
            // 
            // btnMostrarAlumno
            // 
            this.btnMostrarAlumno.Location = new System.Drawing.Point(186, 202);
            this.btnMostrarAlumno.Name = "btnMostrarAlumno";
            this.btnMostrarAlumno.Size = new System.Drawing.Size(109, 40);
            this.btnMostrarAlumno.TabIndex = 21;
            this.btnMostrarAlumno.Text = "Mostrar";
            this.btnMostrarAlumno.UseVisualStyleBackColor = true;
            this.btnMostrarAlumno.Click += new System.EventHandler(this.btnMostrarAlumno_Click);
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(96, 118);
            this.nudAnio.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudAnio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(120, 20);
            this.nudAnio.TabIndex = 3;
            this.nudAnio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(19, 154);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(44, 13);
            this.lblDivision.TabIndex = 20;
            this.lblDivision.Text = "División";
            // 
            // cmbDivision
            // 
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(96, 151);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(126, 21);
            this.cmbDivision.TabIndex = 4;
            this.cmbDivision.SelectedIndexChanged += new System.EventHandler(this.cmbDivision_SelectedIndexChanged);
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(19, 122);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(26, 13);
            this.lblAnio.TabIndex = 19;
            this.lblAnio.Text = "Año";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(20, 202);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 40);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(96, 86);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(199, 20);
            this.txtDocumento.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(97, 54);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(199, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(199, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(17, 57);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 11;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(19, 89);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(26, 13);
            this.lblDocumento.TabIndex = 12;
            this.lblDocumento.Text = "DNI";
            // 
            // rtbDatos
            // 
            this.rtbDatos.Location = new System.Drawing.Point(1, 267);
            this.rtbDatos.Name = "rtbDatos";
            this.rtbDatos.Size = new System.Drawing.Size(657, 216);
            this.rtbDatos.TabIndex = 21;
            this.rtbDatos.Text = "";
            // 
            // FormVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(659, 484);
            this.Controls.Add(this.rtbDatos);
            this.Controls.Add(this.gpbDAtosAlumnos);
            this.Controls.Add(this.gpbDAtosCurso);
            this.Name = "FormVista";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista del Curso";
            this.Load += new System.EventHandler(this.FormVista_Load);
            this.gpbDAtosCurso.ResumeLayout(false);
            this.gpbDAtosCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCurso)).EndInit();
            this.gpbDAtosAlumnos.ResumeLayout(false);
            this.gpbDAtosAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDAtosCurso;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Button btnCrearCurso;
        private System.Windows.Forms.TextBox txtDocumentoProfe;
        private System.Windows.Forms.Label lblAnioCurso;
        private System.Windows.Forms.TextBox txtApellidoProfe;
        private System.Windows.Forms.Label lblDivisionCurso;
        private System.Windows.Forms.TextBox txtNombreProfe;
        private System.Windows.Forms.Label lblNombreProfe;
        private System.Windows.Forms.Label lblApellidoProfe;
        private System.Windows.Forms.ComboBox cmbDivisionCurso;
        private System.Windows.Forms.Label lblDocumentoProfe;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.GroupBox gpbDAtosAlumnos;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.ComboBox cmbDivision;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.RichTextBox rtbDatos;
        private System.Windows.Forms.NumericUpDown nudAnioCurso;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.Button btnMostrarAlumno;
    }
}

