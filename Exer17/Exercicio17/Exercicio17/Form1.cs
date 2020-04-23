using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio17
{
    public partial class Form1 : Form
    {
        double comprimento, area, volume,raio;
        double pi = Math.PI;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            raio = Convert.ToDouble(txtRaio.Text);
            comprimento =  2*pi*raio;
            area=(pi*(Math.Pow(raio, 2)));
            volume = (4 * pi * Math.Pow(raio, 3)) / 3;
            lblcomprimento.Text = Convert.ToString(comprimento);
            lblArea.Text = Convert.ToString(area);
            lblVolume.Text = Convert.ToString(volume);
        }
    }
}
