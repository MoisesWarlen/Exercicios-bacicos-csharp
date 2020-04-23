using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio7
{
    public partial class Form1 : Form
    {
        double engordar,emagrecer,novoPesoGordo,novoPesoMagro, pesoAtual;

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            pesoAtual = Convert.ToDouble(txtPesoAtual.Text);
            engordar = ((pesoAtual * 15) / 100);
            emagrecer = ((pesoAtual * 20) / 100);
            novoPesoGordo = pesoAtual + engordar;
            novoPesoMagro = pesoAtual - emagrecer;
            lblNovoPesomaisGordo.Text = Convert.ToString(novoPesoGordo);
            lblNovoPeso_.Text = Convert.ToString(novoPesoMagro);

        }
    }
}
