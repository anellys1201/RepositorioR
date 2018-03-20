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
using variablesGlobales;
namespace TienditaLapeque
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=sistema;User Id=administrador;password='';");
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
                    MessageBox.Show("Producto agregado");
                }
                else
                {
                    MessageBox.Show("Operacion No Ejecutada");
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
            string selectQuery = "SELECT * FROM productos";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void vERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ver frver = new ver();
            frver.Show();
            this.Hide();
        }

        private void bORRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrar frmborrar = new borrar();
            frmborrar.Show();
            this.Hide();
        }

        private void mODIFICARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificar frmodificar = new modificar();
            frmodificar.Show();
            this.Hide();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (MessageBox.Show("¿Esta seguro de agregar este producto?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    string insertQuery = "INSERT INTO productos(nom_producto, precio, cantidad)VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "')";
                    executeMyQuery(insertQuery);
                    populateDGV();
                }
            }
            else
            {
                MessageBox.Show("Por favor llena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            populateDGV();
        }

        private void RegresartoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de salir de la pantalla de Agregar Productos?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("¡Error! solo se aceptan numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = "";
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("¡Error! solo se aceptan numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Text = "";
            }
        }
    }
}
