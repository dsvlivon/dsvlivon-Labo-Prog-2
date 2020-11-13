using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class FormVista : Form
    {
        Curso curso;
        Profesor profesor;
        Alumno alumno;
        public FormVista()
        {
            InitializeComponent();
        }

        private void FormVista_Load(object sender, EventArgs e)
        {
            cmbDivision.DataSource = Enum.GetValues(typeof(Divisiones));
            cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));
            //obtiene la info del enum divisiones y los carga en el cmbx
            //seria igual si quiero mostrar otra cosa en algun elemento d la vista del form
        }    

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);

            alumno = new Alumno(txtNombre.Text, txtApellido.Text, txtDocumento.Text, (short)nudAnio.Value, division);
            curso += alumno;
            //lo agregue p verificar el alumno, pero no t lo pide
        }


        private void nudAnioCurso_SelectedItemChanged(object sender, EventArgs e)
        {
            //nudAnioCurso.TabIndex = 0;
        }
        private void cmbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            //es lo mismo hacerlo aca q en el load
            cmbDivision.DataSource = Enum.GetValues(typeof(Divisiones));
        }
        //Este es el cmbDivsionCurso
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //es lo mismo hacerlo aca q en el load
            //cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));
        }

        private void txtNombreProfe_TextChanged(object sender, EventArgs e)
        {
            //cmbDivisionCurso.TabIndex = 2;
        }

        private void txtApellidoProfe_TextChanged(object sender, EventArgs e)
        {
            //xtApellidoProfe.TabIndex = 3;
        }

        private void txtDocumentoProfe_TextChanged(object sender, EventArgs e)
        {
            //txtDocumentoProfe.TabIndex = 4;
        }

        private void dtpFechaIngreso_ValueChanged(object sender, EventArgs e)
        {
            //dtpFechaIngreso.TabIndex = 5;
        }
        private void btnCrearCurso_Click(object sender, EventArgs e)
        {
            //btnCrearCurso.TabIndex = 6;
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);
            //esto lo paso el profe
            profesor = new Profesor(txtNombreProfe.Text, txtApellidoProfe.Text, txtDocumentoProfe.Text, dtpFechaIngreso.Value);
            //instancio a un profesor con los datos pasados en los txt
            curso = new Curso((short)nudAnioCurso.Value, division, profesor);//instancio un curso año, la division, y el profesor ya instanciado
            //same, instancio un Curso con los datos d los txt
            MessageBox.Show("Curso creado Correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            btnMostrar.TabIndex = 7;
            if (!(curso is null))
            {
                rtbDatos.Text = (string)curso;
            }
            else
            {
                MessageBox.Show("No existe ningun curso", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gpbDAtosAlumnos_Enter(object sender, EventArgs e)
        {

        }

        private void btnMostrarAlumno_Click(object sender, EventArgs e)
        {
           
            if (!(curso is null))
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(string.Format($"{alumno.ExponerDatos()}"));

                rtbDatos.Text = (string)curso + "/n" + (sb);
            }
            else
            {
                MessageBox.Show("No existe ningun curso", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}

        

       
       