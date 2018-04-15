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
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
            timer1.Enabled = true;
            if (Globales.idrango == 2)
            {
                btnProductos.Enabled = false;
                btnUsuarios.Enabled = false;
            }
            else if (Globales.idrango == 1)
            {
                btnProductos.Enabled = true;
                btnUsuarios.Enabled = true;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
           
            this.Close();
            Agregar fagregar = new Agregar();
            fagregar.Show();
           
        }

        private void index_Load(object sender, EventArgs e)
        {
            lblrango.Text = Convert.ToString(Globales.idventa);
            if (Globales.idrango == 2)
            {
                btnProductos.Enabled = false;
                btnUsuarios.Enabled = false;
            }
            else if(Globales.idrango == 1)
            {
                btnProductos.Enabled = true;
                btnUsuarios.Enabled =  true;
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Close();
            usuarios frmusuarios = new usuarios();
            frmusuarios.Show();
            //this.WindowState = FormWindowState.Minimized;
            
        }


        private void btnVentas_Click(object sender, EventArgs e)
        {
            Globales.idventa += 1;
            this.Close();
            Ventas frmventas = new Ventas();
            frmventas.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cerrar sesion?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {

                this.Close();
                Form1 frmlogin = new Form1();
                frmlogin.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToShortTimeString();
        }

        private void lblhora_Click(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.Close();
            Reportes frmreportes = new Reportes();
            frmreportes.Show();
        }
    }
}
