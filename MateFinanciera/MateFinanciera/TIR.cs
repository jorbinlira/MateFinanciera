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
    public partial class TIR : Form
    {
        double[] q;
        public TIR()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            int x = 0;
            if (int.TryParse(textBox1.Text,out x)==true) {

                for (int i = 0; i < Convert.ToInt32(textBox1.Text)+1;i++ )
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = i;
                   



                }
          
            }
        }
        public  double evaluar(double x)
        {
            double a=-q[0];
            
            for (int i = 1; i < q.Length; i++) {
                a = a + q[i] / Math.Pow(1 + x/100, i);
            
            
            }
                return a;
        }

        
        public double secante(double x1, double x2){
      double x3, fx1, fx2, fx3;
            double error=0;
 
      //string que contendra lal tabla de valores
     
 
      if ( Math.Abs( evaluar( x1 ) ) < Math.Abs( evaluar ( x2 ) ) ){
         double aux = x1;
         x1 = x2;
         x2 = aux;
      } 
 
      fx1 = evaluar( x1 ); 
      fx2 = evaluar( x2 ); 
 
      do{ 
         x3 = x2 - ( fx2 * ( x1 - x2 ) ) / ( fx1 - fx2 );
         fx3 = evaluar( x3 );
         error = 100 * (x2 - x1) / x2;

         x1 = x2;
         x2 = x3;
         fx1 = evaluar( x1 );
         fx2 = evaluar( x2 );
         fx3 = evaluar( x3 );

      } while (Math.Abs(error)<0.1);
    
      return x3; 
   }

        private void button1_Click(object sender, EventArgs e)
        {
            q = new double[dataGridView1.Rows.Count-1];
            MessageBox.Show(q.Length.ToString());
            for(int i=0;i<q.Length;i++){
              
              q[i]=  Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
            
            }
            
            textBox2.Text = secante(1,21).ToString();

        }
    }
}
