﻿using System;
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
    public partial class FrmInforme : Form
    {
        public Bar bar { get; set; }

        public FrmInforme(string texto)
        {
            InitializeComponent();
            rtbSalidaDeTest.Text = texto;
        }

        private void FrmInforme_Load(object sender, EventArgs e)
        {
            rtbSalidaDeTest.Text = bar.ToString();
        }
    }
}
