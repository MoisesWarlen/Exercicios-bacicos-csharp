using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_24
{
    public partial class Form1 : Form
    {
        double qtdDeDinheiroEmReal, valorConvertido;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rbtDolar_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtlibraEstelina_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            qtdDeDinheiroEmReal = Double.Parse(txtQtdDinheiro.Text);

            if (rbtDolar.Checked == true)
            {
                valorConvertido = (qtdDeDinheiroEmReal * 1.80);

            }
            else if (rbtlibraEstelina.Checked == true)
            {
                valorConvertido = (qtdDeDinheiroEmReal * 1.57);

            }
            else if (rbtmarcoAlemao.Checked == true)
            {
                valorConvertido = (qtdDeDinheiroEmReal * 2.00);

            }
            if (qtdDeDinheiroEmReal == 0)
            {
                MessageBox.Show("Digite o a quantidade de dinheiro para continuar.");
            }

            lblValorConvertido.Text = valorConvertido.ToString("N2");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


        }
    }
}
