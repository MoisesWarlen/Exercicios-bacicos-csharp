using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio9
{
    public partial class Form1 : Form
    {
        double BaseMaior, BaseMenor, Altura, area;

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseMaior = Convert.ToDouble(txtbaseMaior.Text);
            BaseMenor = Convert.ToDouble(txtBaseMenor.Text);
            Altura = Convert.ToDouble(txtAltura.Text);
            area = ((BaseMaior + BaseMenor) * Altura) / 2;
            lblArea.Text = Convert.ToString(area);
        }
    }
}
