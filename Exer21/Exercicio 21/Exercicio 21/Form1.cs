using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_21
{
    public partial class Form1 : Form
    {
        double valorHoraTrabalhada, totalHoraTrabalhada,totalHoraExtra,  valorHorasExtras, salarioTotal,salarioMinimo;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            salarioMinimo = Convert.ToDouble(txtSalminimo.Text);
            totalHoraExtra = Convert.ToDouble(txtHorasExtras.Text);
            totalHoraTrabalhada = Convert.ToDouble(txtHoraTrabalhada.Text);

            valorHoraTrabalhada = salarioMinimo / 8;
            valorHorasExtras = salarioMinimo / 4;

            salarioTotal = ((totalHoraTrabalhada * valorHoraTrabalhada) + (totalHoraExtra*valorHorasExtras));
            lblResposta.Text = Convert.ToString("Salario Bruto A receber = R$ "+salarioTotal);
     
        }
    }
}
