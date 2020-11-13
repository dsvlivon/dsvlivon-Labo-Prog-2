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
using ControlCantina;

namespace FrmCantina
{
    public partial class FrmCantina : Form
    {
        public FrmCantina()
        {
            InitializeComponent();
        }
               
        private void FormCantina_Load(object sender, EventArgs e)
        {
            //this.barra1.SetCantina = Cantina.GetCantina(10);
            cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Botella.Tipo tipo;
            Enum.TryParse<Botella.Tipo>(cmbBotellaTipo.SelectedValue.ToString(), out tipo);

            if (this.rdbCerveza.Checked == true)
            {
               // this.barra.AgregarBotella(new Cerveza(this.txtMarca.Text, (int)this.nudCapacidad.Value, (int)this.nudContenido.Value));
            }

            if (this.rdbAgua.Checked == true)
            {
                //this.barra.AgregarBotella(new Agua(this.txtMarca.Text, (int)this.nudCapacidad.Value, (int)this.nudContenido.Value));
            }
        }
    }
}
