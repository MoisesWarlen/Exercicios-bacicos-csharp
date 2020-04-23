using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio19
{
    public partial class Exercicio19 : Form
    {
        double largura, comprimento, luminosidsde, watts,tamanho;
        public Exercicio19()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)

        {
            watts= 18;
            largura = Convert.ToDouble(txtLargura.Text);
            comprimento = Convert.ToDouble(txtComprimento.Text);
            tamanho = largura * comprimento;
            luminosidsde = tamanho * watts;
            lbliluminacao.Text = Convert.ToString(luminosidsde);
            lblTamanho.Text = Convert.ToString(tamanho);
        }
    }
}
