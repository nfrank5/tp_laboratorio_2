using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            Numero numeroA = new Numero(txtNumero1.Text);
            Numero numeroB = new Numero(txtNumero2.Text);
            resultado = Calculadora.operar(numeroA, numeroB, cmbOperacion.Text);
            lblResultado.Text = resultado.ToString();

        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperacion.Text = "";
            this.lblResultado.Text = "0";
            
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
