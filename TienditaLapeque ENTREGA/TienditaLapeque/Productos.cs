using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TienditaLapeque
{
  
    public partial class Productos : Form
                    
    {
        public Productos()
        {

            InitializeComponent();
            //MySqlConnection conexion;
        }
        private string Conexion()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "administrador";
            builder.Password = "";
            builder.Database = "sistema";
            return builder.ToString();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            // string selectQuery = ""
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        private void mODIFICARToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            modificar frmodificar = new modificar();
            frmodificar.Show();
           
        }

        private void bORRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
          borrar frmborrar = new borrar();
            frmborrar.Show();
          
        }

        private void vERToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ver frver = new ver();
               frver.Show();
          
        }

        private void aGREGARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {

        }
    }

}
