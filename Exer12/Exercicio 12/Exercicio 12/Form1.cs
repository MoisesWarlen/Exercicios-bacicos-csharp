using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_12
{
    public partial class Form1 : Form
    {
        double salMinimo, salFuncionario;
      double qtdeSalarioMinimo;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            salMinimo = Convert.ToDouble(txtsalMinimo.Text);
            salFuncionario = Convert.ToDouble(txtsalFuncionario.Text);
            qtdeSalarioMinimo = salFuncionario / salMinimo;

            lblQtdSalariominimo.Text = Convert.ToString(qtdeSalarioMinimo);
    
        }
    }
}
