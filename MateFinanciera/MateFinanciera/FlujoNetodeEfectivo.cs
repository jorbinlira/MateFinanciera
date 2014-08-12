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
    public partial class FNE : Form
    {
        public FNE()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            string incremento = cbcrecimientoingre.SelectedItem.ToString();


            if(incremento.Equals("Cantidad")){

                creingrecan.Enabled = true;
                creingrepor.Enabled = false;
            
            }
            else if(incremento.Equals("Porcentual")){


                creingrepor.Enabled = true;
                creingrecan.Enabled = false;
            
            }


        }

        private void cbcrecimientocos_SelectedIndexChanged(object sender, EventArgs e)
        {
           


 string incremento = cbcrecimientocos.SelectedItem.ToString();
            


            if(incremento.Equals("Cantidad")){

                crecoscan.Enabled = true;
                crecospor.Enabled = false;
            
            }
            else if(incremento.Equals("Porcentual")){

                crecospor.Enabled = true;
                crecoscan.Enabled = false;
            
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {



            InversionFija abrir = new InversionFija();

            abrir.Show();

            

        }



        public void cantidad( double x ,double y , int k,int j) {


            double tot = x;


            for (int i = 2; i <=k; i++)
            {
             dataGridView1.Rows[j].Cells[i].Value =   tot = tot + y;
            }

           
        
        }


        public void porcentual(double x , float y , int l ,int j ) {


            double mon = x;
            float tot;

            dataGridView1.Rows[j].Cells[2].Value = x;

            for (int i = 2; i <=l; i++)
            {

                

               dataGridView1.Rows[j].Cells[i+1].Value = mon*(1 + y);


            }

            tot = Convert.ToSingle(x+mon);

            


        }



        private void button1_Click(object sender, EventArgs e)
        {

            int plazo = Convert.ToInt32(Tiempo.Text);

           double costos = Convert.ToDouble(costoanuales.Text);
           double ingresos = Convert.ToDouble( ingreanuales.Text);

           double fijatotal = Convert.ToDouble( inversionfijtotal.Text);







        }
    }
}
