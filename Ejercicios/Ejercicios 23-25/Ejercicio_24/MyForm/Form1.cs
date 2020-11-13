using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnidadesMedidas;

namespace MyForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertF_Click(object sender, EventArgs e)
        {
            Fahrenheit value = new Fahrenheit(Convert.ToDouble(txtFValue.Text));
            txtFF.Text = txtFValue.Text;
            txtFC.Text = ((Celsius)value).GetGrados().ToString("0.00");
            txtFK.Text = ((Kelvin)value).GetGrados().ToString("0.00");
        }
        private void btnConvertC_Click(object sender, EventArgs e)
        {
            Celsius value = new Celsius(Convert.ToDouble(txtFValue.Text));
            txtCF.Text = ((Fahrenheit)value).GetGrados().ToString("0.00");
            txtCC.Text = txtFValue.Text;
            txtCK.Text = ((Kelvin)value).GetGrados().ToString("0.00");
        }
        private void btnConvertK_Click(object sender, EventArgs e)
        {
            Kelvin value = new Kelvin(Convert.ToDouble(txtFValue.Text));
            txtKF.Text = ((Fahrenheit)value).GetGrados().ToString("0.00");
            txtKC.Text = ((Celsius)value).GetGrados().ToString("0.00");
            txtKK.Text = txtFValue.Text;
        }
        


    }
}
