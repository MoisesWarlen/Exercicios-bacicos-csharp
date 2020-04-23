using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio4
{
    public partial class Form1 : Form
    {
        double nota1,nota2,media;

        private void button1_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtMedia.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularMedia_Click(object sender, EventArgs e)
        {

            nota1 = Convert.ToDouble(txtNota1.Text);
            nota2 = Convert.ToDouble(txtNota2.Text);
            media =(((nota1*2)+(nota2*3))/5);
            txtMedia.Text = Convert.ToString(media);


        }
    }
}
