using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio20
{
    public partial class Form1 : Form
    {

        double angulo,distanciaParedeEscada,altura,x,divisor,divisorRaiz,raizDe3,hip;

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

                  if ((rbtAngulo30.Checked == false && rbtAngulo45.Checked == false && rbtAngulo60.Checked == false) || (txtDistancia.Text == ""))
            {
                MessageBox.Show("Informe os dados  para continuar!");
            }
     
            distanciaParedeEscada = Convert.ToDouble(txtDistancia.Text);

            if (rbtAngulo30.Checked== true)
            {
                
                raizDe3 = 1.7;
                divisorRaiz = 3;
                x = 1;

               altura = (raizDe3 * distanciaParedeEscada) / (divisorRaiz*x);
                                     
            }

            else if (rbtAngulo45.Checked == true)
            {

                raizDe3 = 1;
                divisorRaiz = 1;
                x = 1;

                altura = (raizDe3 * distanciaParedeEscada) / (divisorRaiz * x);

            }
            else if(rbtAngulo60.Checked == true)
            {
              
                raizDe3 = 1.7;
                divisorRaiz = 1;
                x = 1;

                altura = (raizDe3 * distanciaParedeEscada) / (divisorRaiz * x);

            }
       
            hip = (Math.Pow(altura,2) + Math.Pow(distanciaParedeEscada,2));
            hip = Math.Round(Math.Sqrt(hip));

            lblResultado.Text = Convert.ToString(hip);
        }
    }
}
