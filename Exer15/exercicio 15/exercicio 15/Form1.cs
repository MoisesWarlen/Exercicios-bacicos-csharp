using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_15
{
    public partial class Exercicio15 : Form
    {

        double salario, dividas, salarioRestante;
        public Exercicio15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            salario = Convert.ToDouble(txtsalario);
            dividas = Convert.ToDouble(txtDividas);


        }
    }
}
