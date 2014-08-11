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
    public partial class Calendario_de_pagos : Form
    {
        public Calendario_de_pagos()
        {
            InitializeComponent();
        }




        public float pago( float x,int p) {


            float total;
            float n1 =1;
            float n2 =1;

            for (int i = 1; i <= p; i++)
            {
                n1 =n1* (1 + x);
                n2 =n2*((x + 1));
                
            }

            float n3 = n2 - 1;
            float n4 = n1 * x;

            total = n4/ n3;

            return total;




        }

        private void button1_Click(object sender, EventArgs e)
        {


           string metodo = cbmetodo.SelectedItem.ToString();


           if (metodo.Equals("METODO DE CUOTA NIVELADA"))
           {


               double prestamo = Convert.ToDouble(tbmaskprestamo.Text);
               float tasa = Convert.ToSingle(tbmaskinteres.Text);
               int plazo = Convert.ToInt32(tbmaskplazo.Text);
               tasa = tasa / 100;
               double nunca = prestamo;

               dataGridView1.Rows.Add();

               dataGridView1.Rows.Add();
               dataGridView1.Rows[0].Cells[0].Value = 0;
               dataGridView1.Rows[0].Cells[1].Value = 0;
               dataGridView1.Rows[0].Cells[2].Value = 0;
               dataGridView1.Rows[0].Cells[3].Value = 0;
               dataGridView1.Rows[0].Cells[4].Value = prestamo;



               for (int i = 1; i <= plazo; i++)
               {


                   double saldo = prestamo;
                   float cuota = (float)nunca * pago(tasa, plazo);
                   double interes = saldo * tasa;
                   double abono = cuota - interes;

                   saldo = prestamo - abono;

                   if (saldo < 1)
                   {

                       saldo = 0;
                   }


                   dataGridView1.Rows.Add();

                   dataGridView1.Rows.Add();
                   dataGridView1.Rows[i].Cells[0].Value = i;
                   dataGridView1.Rows[i].Cells[1].Value = abono.ToString("0.00");
                   dataGridView1.Rows[i].Cells[2].Value = interes.ToString("0.00");
                   dataGridView1.Rows[i].Cells[3].Value = cuota.ToString("0.00");
                   dataGridView1.Rows[i].Cells[4].Value = saldo.ToString("0.00");

                   prestamo = prestamo - abono;

               } }

               else if (metodo.Equals("METODO DE CUOTA PROPORCIONAL"))
               {

                   double prestamo1 = Convert.ToDouble(tbmaskprestamo.Text);
                   float tasa1 = Convert.ToSingle(tbmaskinteres.Text);
                   int plazo1 = Convert.ToInt32(tbmaskplazo.Text);
                   tasa1 = tasa1 / 100;
                   double nunca1 = prestamo1;

                   dataGridView1.Rows.Add();

                   dataGridView1.Rows.Add();
                   dataGridView1.Rows[0].Cells[0].Value = 0;
                   dataGridView1.Rows[0].Cells[1].Value = 0;
                   dataGridView1.Rows[0].Cells[2].Value = 0;
                   dataGridView1.Rows[0].Cells[3].Value = 0;
                   dataGridView1.Rows[0].Cells[4].Value = prestamo1;



                   for (int i = 1; i <= plazo1; i++)
                   {


                       double saldo1 = prestamo1;
                       double abono1 = nunca1 / plazo1;
                       double interes1 = saldo1 * tasa1;
                       double cuota1 = abono1 + interes1;



                       saldo1 = prestamo1 - abono1;

                       if (saldo1 < 1)
                       {

                           saldo1 = 0;
                       }


                       dataGridView1.Rows.Add();

                       dataGridView1.Rows.Add();
                       dataGridView1.Rows[i].Cells[0].Value = i;
                       dataGridView1.Rows[i].Cells[1].Value = abono1.ToString("0.00");
                       dataGridView1.Rows[i].Cells[2].Value = interes1.ToString("0.00");
                       dataGridView1.Rows[i].Cells[3].Value = cuota1.ToString("0.00");
                       dataGridView1.Rows[i].Cells[4].Value = saldo1.ToString("0.00");

                       prestamo1 = prestamo1 - abono1;




                   }




               }

               else {

                   MessageBox.Show("Por favor elija un metodo ","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
               
               }
           }



        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Calendario_de_pagos_Load(object sender, EventArgs e)
        {

        }
    }
}
