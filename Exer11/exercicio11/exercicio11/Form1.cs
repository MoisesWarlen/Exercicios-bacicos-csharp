using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio11
{
    public partial class Form1 : Form

    {
        double diagonalMaior, diagonalMenor, Area;

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
            diagonalMaior = Convert.ToDouble(txtDmaior.Text);
            diagonalMenor = Convert.ToDouble(txtDmenor.Text);
            Area = (diagonalMaior*diagonalMenor) / 2;
            lblArea.Text = Convert.ToString(Area);

        }
    }
}
