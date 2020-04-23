using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio16
{
    public partial class Form1 : Form
    {
        int cateto_A, cateto_B;
          double c,hipotenusa;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            cateto_A = Convert.ToInt16(txtcatetoA.Text);
            cateto_B = Convert.ToInt16(txtcatetoB.Text);
            hipotenusa = (Math.Sqrt( (cateto_A*cateto_A)+(cateto_B*cateto_B)));
            txtHipotenusa.Text = Convert.ToString(hipotenusa);



        }
    }
}
