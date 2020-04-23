using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio5
{
    public partial class Form1 : Form
    {
        double PrecoProduto,precoAtualizado,desconto;

        private void button1_Click(object sender, EventArgs e)
        {
            txtDesconto.Clear();
            txtPrecoProduto.Clear();
            txtDesconto.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            PrecoProduto = Convert.ToDouble(txtPrecoProduto.Text);
            desconto = ((PrecoProduto * 10) / 100);
            precoAtualizado = PrecoProduto - desconto;
            txtDesconto.Text = Convert.ToString(desconto + " R$");
            txtPrecoProdutoAtualizado.Text = Convert.ToString(precoAtualizado+" R$");
        }
    }
}
