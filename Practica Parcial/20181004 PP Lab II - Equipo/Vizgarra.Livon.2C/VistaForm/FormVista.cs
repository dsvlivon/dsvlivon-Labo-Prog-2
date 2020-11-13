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
        private DirectorTecnico dt;
        
        public FormVista()
        {
            InitializeComponent();
        }

        private void FormVista_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            dt = new DirectorTecnico(txtNombre.Text, txtApellido.Text, (int)nudEdad.Value, (int)nudDni.Value, (int)nudExperiencia.Value);
            MessageBox.Show("se ha creado el dt");
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if(dt is null)
            {
                MessageBox.Show("Aún no se ha creado el DT del formulario");
            }
            else if(dt.ValidarAptitud())
            {
                MessageBox.Show("El DT es apto","error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("El DT es un viejo meado");
            }
        }
    }
}
