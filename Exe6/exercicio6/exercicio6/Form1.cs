using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio6
{
    public partial class Form1 : Form
    {

        double salarioFixo, comissao, valorVendas, salarioFinal;

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSalarioFixo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            txtSalarioFixo.Clear();
            txtTotalVendas.Clear();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            salarioFixo = Convert.ToDouble(txtSalarioFixo.Text);
            valorVendas = Convert.ToDouble(txtTotalVendas.Text);
            comissao = (valorVendas * 4) / 100;
            salarioFinal = comissao + salarioFixo;
            lblComicao.Text = Convert.ToString(comissao);
            lblSalarioFinal.Text = Convert.ToString(salarioFinal);

        }
    }
}
