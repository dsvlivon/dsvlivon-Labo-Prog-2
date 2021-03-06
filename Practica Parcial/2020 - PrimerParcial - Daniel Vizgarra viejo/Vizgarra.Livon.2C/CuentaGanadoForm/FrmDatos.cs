﻿using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentaGanadoForm
{
    public partial class FrmDatos : Form
    {
        private short edad;
        private int dni;
        private string nombre;

        //public Empleado frmEmpleado;
        //public Gente frmGente;
        public FrmDatos()
        {
            InitializeComponent();
        }

        public short Edad { get => edad;  }
        public int Dni { get => dni; }
        public string Nombre { get => nombre; }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
            if(short.TryParse(txtEdad.Text, out short auXedad))
            {
                edad = auXedad;
                if (txtNombre.Text != null)
                {
                    nombre = txtNombre.Text;         
                }

                if (int.TryParse(txtDni.Text, out int auxDni))
                {
                    dni = auxDni;
                }
            }
        }
    }
}
