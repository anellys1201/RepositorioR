using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using variablesGlobales;
using System.Windows.Forms;

namespace TienditaLapeque
{
    public partial class CalculoVenta : Form
    {
        public CalculoVenta()
        {
            InitializeComponent();
            textBox1.Text = Globales.totalventas;
            Globales.totalventa = Convert.ToDouble(Globales.totalventas);
          //  textBox2.Text = "0";

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
           if (textBox2.Text != "")
            {

            Globales.cambio =  Convert.ToDouble(textBox2.Text) - Globales.totalventa;
            textBox3.Text = Convert.ToString(Globales.cambio);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
