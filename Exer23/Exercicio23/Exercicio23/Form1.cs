using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio23
{
    public partial class Exercicio23 : Form
    {
        int angulo1, angulo2, angulo3, triangulo=180;
        public Exercicio23()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            angulo1 = Convert.ToInt16(txtAngulo1.Text);
            angulo2 = Convert.ToInt16(txtAngulo2.Text);
            if (angulo1 <=0 || angulo2 <=0)
            {

                MessageBox.Show("Valor informado não forma o 3º  ângulo !! Digite outro valor valido");
            }


            if (angulo1>angulo2)
            {
                angulo3 =( triangulo - (angulo1 - angulo2));
                
            }
            else
            {
                angulo3 = (triangulo - (angulo2 - angulo1));
            }
            lblResultado.Text = Convert.ToString(angulo3);
        }
    }
}
