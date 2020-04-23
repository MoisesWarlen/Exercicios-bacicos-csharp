using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio14
{
    public partial class Form1 : Form

    {
   
        DateTime dataInicial, dataFinal;
        TimeSpan resposta, teste;
        int incremento=0,Dias=0,Meses=0,Anos=0,bissexto;
        double semana;

        int[] diasDoMes = new int [12] { 31, -1, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 } ;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataInicial = DateTime.Parse(dateTimePicker1.Text);
            dataFinal = DateTime.Parse(dateTimePicker2.Text);
            resposta = dataFinal - dataInicial;


            

            if (dataInicial.Day > dataFinal.Day)
            {
                incremento = diasDoMes[dataInicial.Month - 1];

            }

            /// se for fevereiro
            /// se odia for menor que o dia de  hoje
            if (incremento == -1)
            {
            if (DateTime.IsLeapYear(dataInicial.Year))
            {
                // ano bissexto -> fevereiro contém 29 dias
                incremento = 29;
            }
            else
            {
                incremento = 28;
                }
            }
            if (incremento != 0)
            {
                Dias = (dataFinal.Day + incremento) - dataInicial.Day;
                incremento = 1;
            }
            else
            {
                Dias = dataFinal.Day - dataInicial.Day;
            }

          

            ///
            ///calculo do mês
            ///
            if ((dataInicial.Month + incremento) > dataFinal.Month)
            {
                Meses = (dataFinal.Month + 12) - (dataInicial.Month + incremento);
                incremento = 1;
            }
            else
            {
                Meses = (dataFinal.Month) - (dataInicial.Month + incremento);
                incremento = 0;
            }


            ///
            /// calculo do ano
            ///
            Anos = dataFinal.Year - (dataInicial.Year + incremento);

            Meses += Anos * 12;

            teste = dataFinal - dataInicial;
            semana = (teste.Days / 7);

            lblResposta.Text = Convert.ToString(Anos + " Anos(s), " + Meses + " mes(es), " + semana + "semana(s)," + teste.Days + " dia(s)");
        }
    }
}
