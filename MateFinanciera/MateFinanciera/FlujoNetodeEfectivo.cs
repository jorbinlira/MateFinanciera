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
    public partial class FlujoNetodeEfectivo : Form
    {
        public FlujoNetodeEfectivo()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            string incremento = cbcrecimientoingre.SelectedItem.ToString();


            if(incremento.Equals("Cantidad")){

                creingrecan.Enabled = true;
            
            }
            else if(incremento.Equals("Porcentual")){

                creingrepor.Enabled = true;
            
            }


        }

        private void cbcrecimientocos_SelectedIndexChanged(object sender, EventArgs e)
        {
           


 string incremento = cbcrecimientocos.SelectedItem.ToString();
            


            if(incremento.Equals("Cantidad")){

                crecoscan.Enabled = true;
            
            }
            else if(incremento.Equals("Porcentual")){

                crecospor.Enabled = true;

            
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            InversionFija abrir = new InversionFija();

            abrir.Show();

        }
    }
}
