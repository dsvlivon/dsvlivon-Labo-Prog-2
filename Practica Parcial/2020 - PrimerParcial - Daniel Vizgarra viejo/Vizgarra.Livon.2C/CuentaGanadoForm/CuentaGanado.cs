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

        private void btnInforme_Click(object sender, EventArgs e)
        {
            FrmInforme formulario = new FrmInforme();
            formulario.bar = bar;
            formulario.ShowDialog();
        }

        private void nudEmpleados_ValueChanged(object sender, EventArgs e)
        {
            if (int.TryParse(nudEmpleados.Value.ToString(), out int value))
            {
                if(value !=  0 && value >0)
                { 
                    if (bar.Empleados.Count < value)
                    {
                        FrmDatos frm = new FrmDatos();
                        DialogResult resultado = frm.ShowDialog();
                        if(resultado == DialogResult.OK)
                        {
                            if(frm.Dni >0)
                            {
                                empleado = new Empleado(frm.Nombre, frm.Edad, frm.Dni);
                            }
                            else
                            {
                                empleado = new Empleado(frm.Nombre, frm.Edad);
                            }

                            if(empleado.Validar())
                            { 
                                bool rta = bar + empleado;
                                MessageBox.Show("Se AGREGO un empleado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No cumple los requisitos!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        nudEmpleados.Value = bar.Empleados.Count;
                    }
                    else if(bar.Empleados.Count > value)
                    {
                        FrmDatos frm = new FrmDatos();
                        bar.Empleados.Remove(bar.Empleados.First());
                        MessageBox.Show("Se QUITO un empleado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        nudEmpleados.Value = bar.Empleados.Count;
                    }
                }
            }
        }

        private void nudGente_ValueChanged(object sender, EventArgs e)
        {
            if (int.TryParse(nudGente.Value.ToString(), out int value))
            {
                if (value != 0 && value > 0)
                {
                    if (bar.Gente.Count < value)
                    {
                        FrmDatos frm = new FrmDatos();
                        DialogResult resultado = frm.ShowDialog();
                        if (resultado == DialogResult.OK)
                        {
                            if (frm.Edad > 0)
                            {
                                gente = new Gente(frm.Nombre, frm.Edad);
                            }
                            else
                            {
                                gente = new Gente(frm.Edad);
                            }

                            if (gente.Validar())
                            {
                                bool rta = bar + gente;
                                MessageBox.Show("Se AGREGO una gentuza!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No cumple los requisitos!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        nudGente.Value = bar.Gente.Count;
                    }
                    else if (bar.Gente.Count > value)
                    {
                        FrmDatos frm = new FrmDatos();
                        bar.Gente.Remove(bar.Gente.First());
                        MessageBox.Show("Se QUITO una gentuza!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        nudGente.Value = bar.Gente.Count;
                    }
                }
            }
        }
    }
}

