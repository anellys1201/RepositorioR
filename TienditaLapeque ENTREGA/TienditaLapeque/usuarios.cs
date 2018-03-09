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
    public partial class usuarios : Form
    {
        public usuarios()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=sistema;User Id=root;password='1234';");
        MySqlCommand command;

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public void executeMyQuery(string query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    
                }
                else
                {
                    MessageBox.Show("Query No Ejecutado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }
        public void populateDGV()
        {
            string selectQuery = "SELECT * FROM usuarios";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void usuarios_Load(object sender, EventArgs e)
        {
            populateDGV();
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text != " " && comboBox1.Text != "" && txtAM.Text != "" && txtAP.Text != "" && txtPass.Text != " ")
            {
                //Convert.ToString(txtPass.Text);
                if (txtPass.TextLength < 8)
                {
                    MessageBox.Show("Tu contraseña es demaciado corta, ingresa mas de 8 carateres");
                }else 
                if (MessageBox.Show("¿Esta seguro de agregar a este usuario?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    string insertQuery = "INSERT INTO usuarios( nombre, apepat, apemat, id_rango, contrasena)VALUES('" + txtnombre.Text + "','" + txtAP.Text + "','" + txtAM.Text + "','" + comboBox1.Text + "','" + txtPass.Text + "' )";
                    executeMyQuery(insertQuery);
                    populateDGV();
                    MessageBox.Show("Usuario agregado");
                    populateDGV();
                    button1_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Por favor llena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult boton = MessageBox.Show("¿Esta seguro de eliminar este usuario?", "Advertencia", MessageBoxButtons.YesNo);
            if (boton == DialogResult.Yes)
            {

                string deleteQuery = "DELETE FROM usuarios WHERE id_usuario =" + int.Parse(txtID.Text) + "";
                executeMyQuery(deleteQuery);
                populateDGV();
                MessageBox.Show("Usuario Eliminado");
                populateDGV();
                button1_Click(sender,e);
            }
            else
            {
                MessageBox.Show("Usuario no eliminado");
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtAP.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtAM.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
              txtPass.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtAM.Text != "" && txtAP.Text != ""  && txtnombre.Text != "" && txtPass.Text != "" && comboBox1.Text != "")
            {
                DialogResult boton = MessageBox.Show("¿Esta seguro de modificar este usuario?", "Advertencia", MessageBoxButtons.YesNo);

                if (txtPass.TextLength < 8)
                {
                    MessageBox.Show("Tu contraseña es demaciado corta, ingresa mas de 8 carateres");
                }
                else

                   if (boton == DialogResult.Yes)
               {

                   string insertQuery = "UPDATE  usuarios SET nombre= '" + txtnombre.Text + "', apepat='" + txtAP.Text + "', apemat='" + txtAM.Text + "',id_rango='" + comboBox1.Text + "', contrasena='" + txtPass.Text + "' WHERE id_usuario =" + int.Parse(txtID.Text) + "";
                   executeMyQuery(insertQuery);
                   populateDGV();
                   MessageBox.Show("Usuario Modificado");
                    button1_Click(sender, e);
                }
               else
               {
                   MessageBox.Show("Usuario no modificado");
               }
            }
            else
            {
                MessageBox.Show("Por favor llena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtAM.Text = "";
            txtAP.Text = "";
            txtnombre.Text = "";
            txtPass.Text = "";
            comboBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de salir de la pantalla de Usuarios?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                index frmindex = new index();
                frmindex.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
