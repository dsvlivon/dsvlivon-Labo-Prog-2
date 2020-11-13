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

namespace CuentaGanadoForm
{
    public partial class CuentaGanadoForm : Form
    {
        private Bar bar;
        public Empleado empleado;
        public Gente gente;

        public CuentaGanadoForm()
        {
            InitializeComponent();
            bar = Bar.GetBar();
        }

        private void nudEmpleados_ValueChanged(object sender, EventArgs e)
        {
            if (int.TryParse(nudEmpleados.Value.ToString(), out int value))
            {
                if (bar.Empleados.Count < value)
                {
                    FrmDatos frm = new FrmDatos();
                    DialogResult resultado = frm.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {

                        empleado = new Empleado(frm.Nombre, frm.Edad, frm.Dni);
                        bool rta = bar + empleado;

                        if (rta)
                        {
                            MessageBox.Show("Se AGREGO un empleado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No cumple los requisitos!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    //nudEmpleados.Value = bar.Empleados.Count;
                }
                else if (bar.Empleados.Count > value)
                {
                    MessageBox.Show("Se QUITO un empleado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bar.Empleados.RemoveAt(bar.Empleados.Count - 1);               
                }
            }
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            FrmInforme formulario = new FrmInforme(bar.ToString());
            formulario.bar = bar;
            formulario.ShowDialog();
        }

        private void nudGente_ValueChanged(object sender, EventArgs e)
        {
            if (int.TryParse(nudGente.Value.ToString(), out int value))
            {
                if (value != 0 && value > 0)
                {
                    if (bar.Gentes.Count < value)
                    {
                        FrmDatos frm = new FrmDatos();
                        DialogResult resultado = frm.ShowDialog();
                        if (resultado == DialogResult.OK)
                        {
                            gente = new Gente(frm.Edad);
                            bool rta = bar + gente;

                            if (rta)
                            {
                                MessageBox.Show("Se AGREGO una gentuza!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No cumple los requisitos!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        nudGente.Value = bar.Gentes.Count;
                    }
                    else if (bar.Gentes.Count > value)
                    {
                        FrmDatos frm = new FrmDatos();
                        bar.Gentes.Remove(bar.Gentes.First());
                        MessageBox.Show("Se QUITO una gentuza!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        nudGente.Value = bar.Gentes.Count;
                    }
                }
            }
        }
    }
}
