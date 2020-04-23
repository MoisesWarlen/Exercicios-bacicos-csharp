using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio22
{
    public partial class Form1 : Form
    {
        int numeroDeLados,nD;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numeroDeLados = int.Parse(txtNumeoroDeLados.Text);
            if (numeroDeLados <=3 )
            {

                MessageBox.Show("Numerodigitado Não possui  poligono!!");
                
            }

            nD = numeroDeLados * (numeroDeLados - 3) / 2;

            lblResposta.Text= Convert.ToString (nD);

        }
    }
}
