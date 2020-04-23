using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_18
{
    public partial class Form1 : Form
    {
        double celsius, firenich;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            celsius = Convert.ToDouble(txtCelsius.Text);
            firenich =(celsius * 9 / 5) + 32;
            lblfarenich.Text = Convert.ToString(firenich);
        } 
    }
}
