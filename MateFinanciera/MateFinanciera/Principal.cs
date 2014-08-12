using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateFinanciera
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            TmarMixta abrir = new TmarMixta();


            abrir.Show();



        }

        private void button6_Click(object sender, EventArgs e)
        {


            Calendario_de_pagos abrir = new Calendario_de_pagos();

            abrir.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            TMAR abrir = new TMAR();
            abrir.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FlujoNetodeEfectivo abrir = new FlujoNetodeEfectivo();
            abrir.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            TIR a = new TIR();
            a.Show();
        }
    }
}
