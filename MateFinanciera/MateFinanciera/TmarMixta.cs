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
    public partial class TmarMixta : Form
    {
        public TmarMixta()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            double inversion = Convert.ToDouble(masktbinver.Text);
            double prestamo = Convert.ToDouble(masktbpres.Text);

            double inte = Convert.ToDouble(masktbinprest.Text);
            double tmar = Convert.ToDouble(masktbtmar.Text);

            double finan = inversion - prestamo;

            float contribfinan = (float)(finan / inversion);
            float contriinver = (float)(prestamo / inversion);

            float contritotal = contribfinan + contriinver;


            float i = (float)(inte / 100);
            float j = (float)(tmar / 100);
            float n = i + j;

            float tmarfinan = contribfinan * j;
            float tmarinver = contriinver * i;

            float total = tmarfinan + tmarinver;
            float total2 = total * 100;

            dataGridView1.Rows.Add();

            dataGridView1.Rows[0].Cells[0].Value = "INSTITUCION FINANCIERA";
            dataGridView1.Rows[0].Cells[1].Value = finan;
            dataGridView1.Rows[0].Cells[2].Value = contribfinan;
            dataGridView1.Rows[0].Cells[3].Value = i + "%";
            dataGridView1.Rows[0].Cells[4].Value = tmarfinan+"%";

            dataGridView1.Rows.Add();

            dataGridView1.Rows[1].Cells[0].Value = "INVERSIONISTA";
            dataGridView1.Rows[1].Cells[1].Value = prestamo;
            dataGridView1.Rows[1].Cells[2].Value = contriinver;
            dataGridView1.Rows[1].Cells[3].Value = j + "%";
            dataGridView1.Rows[1].Cells[4].Value = tmarinver+"%";

            dataGridView1.Rows.Add();

            dataGridView1.Rows[2].Cells[0].Value = "TOTAL";
            dataGridView1.Rows[2].Cells[1].Value = inversion;
            dataGridView1.Rows[2].Cells[2].Value = contritotal;
            dataGridView1.Rows[2].Cells[3].Value = n + "%";
            dataGridView1.Rows[2].Cells[4].Value = total2 + "%";


        }
    }
}
