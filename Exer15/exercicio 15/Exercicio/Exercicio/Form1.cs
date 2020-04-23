using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio
{
    public partial class Form1 : Form
    {

        double salario, valorDividas, salarioRestante ,multa;

        private void button2_Click(object sender, EventArgs e)
        {
            txtContaAtrasada.Clear();
            txtSalario.Clear();
           
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            salario = Convert.ToDouble(txtSalario.Text);
            valorDividas = Convert.ToDouble(txtContaAtrasada.Text);
            if (salario < valorDividas)
            {
                    MessageBox.Show("Salario insuficiente para quitar Divida!");
            }
            else
            {
                    multa = (valorDividas * 2) / 100; ;
                    lblMulta.Text = Convert.ToString(multa);
                    salarioRestante = salario - valorDividas - multa;
                    lblSalarioRestante.Text = Convert.ToString(salarioRestante);
            }

        }
    }
}
