using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio3
{
    public partial class Form1 : Form
    {
        double n1, n2;
        double resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNumero2.Clear();
            txtNumero1.Clear();
            txtResultado.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {

            n1 = Convert.ToDouble(txtNumero1.Text);
            n2 = Convert.ToDouble(txtNumero2.Text);
            resultado =( n1 / n2);
            txtResultado.Text = Convert.ToString(resultado);

        }
    }
}
