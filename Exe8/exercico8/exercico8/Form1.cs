﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercico8
{
    public partial class Form1 : Form
    {
        double pesoKilo, PesoGrama;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            pesoKilo = Convert.ToDouble(txtPesoKilo.Text);
            PesoGrama = pesoKilo * 1000;
            lblKiloGramas.Text = Convert.ToString(PesoGrama);

        }
    }
}