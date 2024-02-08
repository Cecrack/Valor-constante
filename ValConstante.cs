using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace valor_constante
{
    public partial class ValorConstante : Form
    {
        public ValorConstante()
        {
            InitializeComponent();
        }

        private void btncalculo_Click(object sender, EventArgs e)
        {
            //los valores
            int c = int.Parse(txtcantidad.Text);
            int semilla1 = int.Parse(txtsemilla1.Text);
            int semilla2 = int.Parse(txtsemilla2.Text);

            double s1 = semilla1;
            double s2 = semilla2;

            //se agregan las columnas
            DGVcalculo.Rows.Clear();
            DGVcalculo.Columns.Clear();

            DGVcalculo.Columns.Add("i", "i");
            DGVcalculo.Columns.Add("semilla 1", "semilla 1");
            DGVcalculo.Columns.Add("semilla 2", "semilla 2");
            DGVcalculo.Columns.Add("Producto", "Producto");
            DGVcalculo.Columns.Add("Producto medio", "Producto medio");
            DGVcalculo.Columns.Add("valor 1", "valor 1");
            DGVcalculo.Columns.Add("valor 2", "valor 2");

            int valor2 = 0;

            //entra en el ciclo para calcular
            for (int i = 0; i < c; i++)
            {
                DGVcalculo.Rows.Add(1);
                double R = s1 * s2;
                string ciclo = R.ToString();
                while (ciclo.Length < 5)
                {
                    ciclo = "0" + ciclo;
                }

                //se agregan los valores a la celda              
                DGVcalculo.Rows[i].Cells[0].Value = i + 1;
                DGVcalculo.Rows[i].Cells[1].Value = s2;
                DGVcalculo.Rows[i].Cells[2].Value = s1;
              
                DGVcalculo.Rows[i].Cells[3].Value = R;
                s1 = double.Parse(ciclo.Substring(1, 4));
                DGVcalculo.Rows[i].Cells[4].Value = s1;
                s1 = double.Parse(ciclo.Substring(1, 3));
                
                DGVcalculo.Rows[i].Cells[5].Value = s1;
                if (DGVcalculo.ToString().Length >= 4)
                {
                    DGVcalculo.Rows[i].Cells[6].Value = valor2;
                    valor2 = int.Parse(ciclo.Substring(2, 3));
                }
            }
        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtsemilla2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsemilla1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DGVcalculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
