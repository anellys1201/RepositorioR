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
    public partial class Reportes : Form
    {
        public Reportes()
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
                    MessageBox.Show("Producto modificado");
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de salir de la pantalla de Reportes?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                index frmindex = new index();
                frmindex.Show();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            closeConnection();
            MySqlDataReader mrd;
            string selectQuery = "SELECT * FROM venta where fecha_venta like '" + comboBox1.Text + "/" + comboBox2.Text + "%'";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            command = new MySqlCommand(selectQuery, connection);
            openConnection();
            mrd = command.ExecuteReader();
            if (mrd.Read())
            {

                //   txtbuscar.Text = "";
            }
            else
            {
                MessageBox.Show("No hay ventas con la fecha ingresada", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            closeConnection();
        }
        //   MySqlDataReader mdr;
        //   string select = "SELECT * FROM venta WHERE fecha_venta like'" + comboBox1.Text + "%'";
        //   command = new MySqlCommand(select, connection);
        //   openConnection();
        //   mdr = command.ExecuteReader();
        //
        //   closeConnection();
    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        } 
    }
}
