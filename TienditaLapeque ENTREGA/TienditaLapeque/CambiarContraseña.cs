using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace TienditaLapeque
{
    public partial class CambiarContraseña : Form
    {
        public CambiarContraseña()
        {
            InitializeComponent();

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cancelar el cambio de contraseña?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Form1 frm1 = new Form1();
                frm1.Show();
               
            }
            else
            {

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection(Conexion());
            Conexion();
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuarios WHERE nombre='" + txtUsuario.Text + "'", conexion);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read()) //Si el usuario es correcto nos abrira la otra ventana.
            {
                if(txtNuevaC.Text.Length >= 8)
                {

                    if(txtNuevaC.Text == txtConfirmarC.Text)
                    {
                        conexion.Close();
                        Conexion();
                        conexion.Open();
                        MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM usuarios WHERE contrasena='" + txtContraseñaAdmin.Text + "'", conexion);
                        leer = cmd2.ExecuteReader();
                        if (leer.Read()) //Si el usuario es correcto nos abrira la otra ventana.
                        {

                            if (MessageBox.Show("¿Esta seguro de  cambiar la contraseña de su cuenta " + txtUsuario.Text+ "?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                            {
                                conexion.Close();
                                Conexion();
                                conexion.Open();
                                MySqlCommand cambio = new MySqlCommand("UPDATE usuarios SET contrasena ='"+ txtConfirmarC.Text+"' WHERE nombre='" + txtUsuario.Text + "'", conexion);
                                leer = cambio.ExecuteReader();
                                    MessageBox.Show("La contraseña ha sido cambiada con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                                    btnCancelar.Text = "Salir";
                                    conexion.Close();
                              
                            }

                        }
                        else
                        {
                            MessageBox.Show("La contraseña del administrador no es correcta", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La confirmacion de contraseña no coincide", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                    MessageBox.Show("La contraseña debe ser de mas de 8 caracteres", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("El nombre de usuario no coincide", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            }
          
        }

        private void CambiarContraseña_Load(object sender, EventArgs e)
        {
            txtNuevaC.UseSystemPasswordChar = true;
            txtConfirmarC.UseSystemPasswordChar = true;
            txtContraseñaAdmin.UseSystemPasswordChar = true;
        }
    }
}