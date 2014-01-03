using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intereses_de_un_banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        static double calcular(double a, double b, double c)
        {
            double total, total1 = 0;
            double t = b / 100;
            for (int d = 0; d < c ; d++)
            {
                total = a * t;
                total1 = total1 + total;
            }
            return total1;
        }
        public void Capital()
        {
            double capital;
            double interes;
            double mes;

            capital = Convert.ToDouble(textBox_Inicial.Text);
            if (capital < 500)
            {
                MessageBox.Show(capital + " Capital erroneo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                interes = Convert.ToDouble(textBox_Interes.Text);
                if (interes > 8 || interes < 1)
                {
                    MessageBox.Show(interes + " Taza de interes erronea", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    mes = Convert.ToDouble(textBox_Invesion.Text);
                    if (mes > 12 || mes < 1)
                    {
                        MessageBox.Show(mes + " Numeros de meses erroneo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        double x = calcular(capital, interes, mes);
                        MessageBox.Show(" Su interes generado en " + mes + " meses es " + x);
                        double capt = x + capital;
                        MessageBox.Show("Su capital total es " + capt);
                    }
                }
            }
        }

        private void button_Run_Click(object sender, EventArgs e)
        {
            Capital();
        }
    }
}
