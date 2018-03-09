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
    public partial class borrar : Form
    {
        public borrar()
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
                    MessageBox.Show("PRODUCTO ELIMINADO");
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
        private void aGREGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar frmagregar = new Agregar();
            frmagregar.Show();
            this.Hide();
        }

        private void mODIFICARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificar frmodificar = new modificar();
            frmodificar.Show();
            this.Hide();
        }


        private void vERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ver frver = new ver();
            frver.Show();
            this.Hide();
        }
      
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != ""){
                if (MessageBox.Show("¿Esta seguro de ELIMINAR este producto?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    string deleteQuery = "DELETE FROM productos WHERE id_producto=" + int.Parse(textBox4.Text) + "";
                    executeMyQuery(deleteQuery);
                    populateDGV();
                }
            }
            else
            {
                MessageBox.Show("Por favor llena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }
        private void borrar_Load(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM productos";
            DataTable tabla = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de salir de la pantalla de Borrar Productos?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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
