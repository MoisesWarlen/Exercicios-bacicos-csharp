using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio2
{
    public partial class Form1 : Form
    {   //declaração de variaveis
        int n1, n2, n3, resultado;

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero3.Clear();
            txtResultado.Clear();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToInt32(txtNumero1.Text);
            n2 = Convert.ToInt32(txtNumero2.Text);
            n3 = Convert.ToInt32(txtNumero3.Text);
            resultado = (n1 * n2 * n3);
            txtResultado.Text = Convert.ToString(resultado);


        }
    }
}
