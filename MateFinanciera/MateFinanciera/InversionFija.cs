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
    public partial class InversionFija : Form
    {
        public InversionFija()
        {
            InitializeComponent();
        }


        public float depreciacion( double x , double y , int k) {


            float depre = (float)(x - y) / k;


            return depre;
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

     //   Industriales
     // Comerciales
     //Residencia



//        Colectivo o de carga
//vehiculos de empresas
//otros equipos de transporte

//        Industriales en general
//Agricolas
//otros bienes inmuebles

        private void button1_Click(object sender, EventArgs e)
        {


           

           if (cbedificios.SelectedItem != null && cbtransporte.SelectedItem != null && cbmaquinaria.SelectedItem != null){


               if (montoedificios.Text.Replace("_","").Equals("") || montomaquinaria.Text.Replace("_","").Equals("")  || montotransporte.Text.Replace("_","").Equals("") || montoterreno.Text.Replace("_","").Equals("") || resiedificios.Text.Replace("_","").Equals("") ||
                   resimaquinaria.Text.Replace("_","").Equals("") || resitransporte.Text.Replace("_","").Equals(""))
               {


                   MessageBox.Show(" por favor llene todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

               }
               else {

                  



                   string tipoedificios = cbedificios.SelectedItem.ToString();
                   string tipotransporte = cbtransporte.SelectedItem.ToString();
                   string tipomaquinaria = cbmaquinaria.SelectedItem.ToString();


                   int vidautil = 0;
                   int vidautil2 = 0;
                   int vidautil3 = 0;

                   float totaldepre = 0;
                   double inverfijt = 0;
                   double residual = 0;

                   if (tipoedificios.Equals("Industriales"))
                   {

                       vidautil = 10;

                   }
                   else if (tipoedificios.Equals("Comerciales"))
                   {

                       vidautil = 20;
                   }
                   else if (tipoedificios.Equals("Residencia"))
                   {

                       vidautil = 10;
                   }

                   double montoedi = Convert.ToDouble(montoedificios.Text);
                   double resiedi = Convert.ToDouble(resiedificios.Text);

                   float depreedi = depreciacion(montoedi, resiedi, vidautil);



                   if (tipotransporte.Equals("Colectivo o de carga"))
                   {
                       vidautil2 = 5;


                   }
                   else if (tipotransporte.Equals("vehiculos de empresas"))
                   {
                       vidautil2 = 3;

                   }
                   else if (tipotransporte.Equals("otros equipos de transporte"))
                   {

                       vidautil2 = 8;
                   }

                   double montotrans = Convert.ToDouble(montotransporte.Text);
                   double residtrans = Convert.ToDouble(resitransporte.Text);

                   float depretranspor = depreciacion(montotrans, residtrans, vidautil2);



                   if (tipomaquinaria.Equals("Industriales en general"))
                   {
                       vidautil3 = 7;

                   }
                   else if (tipomaquinaria.Equals("Agricolas"))
                   {
                       vidautil3 = 5;

                   }
                   else if (tipomaquinaria.Equals("otros bienes inmuebles"))
                   {

                       vidautil3 = 5;

                   }

                   double montomaqui = Convert.ToDouble(montomaquinaria.Text);
                   double resimaqui = Convert.ToDouble(resimaquinaria.Text);

                   float depremaqui = depreciacion(montomaqui, resimaqui, vidautil3);


                   totaldepre = depreedi + depretranspor + depremaqui;

                   double terreno = Convert.ToDouble(montoterreno.Text);

                   inverfijt = montoedi + montotrans + montomaqui + terreno;

                   residual = resiedi + residtrans + resimaqui;

                   FNE add = new FNE();

   


                   add.depreciacion.Text = totaldepre.ToString();

                   add.inversionfijtotal.ReadOnly = true;
                   add.inversionfijtotal.Text = inverfijt.ToString();

                   add.Valorresidual.Text = residual.ToString();

                   add.Show();

                   

               }

           }

           else {

               MessageBox.Show("debe especificar el tipo de los activos ","ERROR",MessageBoxButtons.OK , MessageBoxIcon.Error);
               
           }


          














        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
