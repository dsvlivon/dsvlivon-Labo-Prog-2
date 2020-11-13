using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace ConversorMoneda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCotDolar.Text = Dolar.GetCotizacion().ToString();
            txtCotEuro.Text = Euro.GetCotizacion().ToString();
            txtCotPeso.Text = Pesos.GetCotizacion().ToString();
            //cargo los textbox d cada tipo c los getters q m devuelven la cotizacion c respecto al dolar.ToString
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            Euro value = new Euro(Convert.ToDouble(txtEuroValue.Text));
            txtEuroEuro.Text = value.GetCantidad().ToString("0.00");
            txtEuroDolar.Text = ((Dolar)value).GetCantidad().ToString("0.00");
            txtEuroPeso.Text = ((Pesos)value).GetCantidad().ToString("0.00");
        }

        private void btnConvertirDolar_Click(object sender, EventArgs e)
        {
            Dolar value = new Dolar(Convert.ToDouble(txtDolarValue.Text));
            txtDolarEuro.Text = ((Euro)value).GetCantidad().ToString("0.00");
            txtDolarDolar.Text = value.GetCantidad().ToString("0.00");
            txtDolarPeso.Text = ((Pesos)value).GetCantidad().ToString("0.00");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if(btnLock.ImageIndex == 1)
            {
                btnLock.ImageIndex = 0;
                txtCotDolar.Enabled = true;
                txtCotEuro.Enabled = true;
                txtCotPeso.Enabled = true;
            }else if(btnLock.ImageIndex == 0)
            {
                btnLock.ImageIndex = 1;
                txtCotDolar.Enabled = false;
                txtCotEuro.Enabled = false;
                txtCotPeso.Enabled = false;
            }
        }

        private void txtCotEuro_Leave(object sender, EventArgs e)
        {
            double cotiz;
            if (Double.TryParse(txtCotEuro.Text, out cotiz))
                Euro.SetCotizacion(cotiz);
            else
                txtCotEuro.Focus();
        }

        private void txtCotizDolar_leave(object sender, EventArgs e)
        {
            double cotiz;
            if (Double.TryParse(txtCotEuro.Text, out cotiz))
                Euro.SetCotizacion(cotiz);
            else
                txtCotEuro.Focus();
        }

        private void txtCotizPesos_Leave(object sender, EventArgs e)
        {
            double cotiz;
            if (Double.TryParse(txtCotEuro.Text, out cotiz))
                Euro.SetCotizacion(cotiz);
            else
                txtCotEuro.Focus();
        }

        private void BtnConvertirPeso_Click(object sender, EventArgs e)
        {
            Pesos input = new Pesos(Convert.ToDouble(txtPesosValue.Text));
            txtPesoPeso.Text = input.GetCantidad().ToString("0.00");
            txtPesoDolar.Text = ((Dolar)input).GetCantidad().ToString("0.00");
            txtPesoEuro.Text = ((Euro)input).GetCantidad().ToString("0.00");
        }
    }
}
