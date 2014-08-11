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
    public partial class TMAR : Form
    {
        public TMAR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float n = Convert.ToSingle(TB1.Text);
            float m = Convert.ToSingle(TB2.Text);

            n = n / 100;
            m = m / 100;


            float resultado = n + m;
            resultado = resultado * 100;

            textBox1.Text = resultado.ToString("0.00") +"%";
        }
    }
}
