using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_25
{
    public partial class Form1 : Form
    {
        int horas, minutos,segundos,MinutosConvertidos,totalMinutos;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            horas = Int16.Parse(txtHora.Text);
            minutos = Int16.Parse(txtMinutos.Text);
            MinutosConvertidos = horas * 60;
            totalMinutos = minutos + MinutosConvertidos;
            segundos = totalMinutos * 60;
            lblHoraMinutos.Text = Convert.ToString(MinutosConvertidos);
            lblMinutos.Text = Convert.ToString(totalMinutos);
            lblSegundo.Text = Convert.ToString(segundos);

        }
    }
}
