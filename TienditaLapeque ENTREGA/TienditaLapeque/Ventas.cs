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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.fonts;
using System.IO;
using variablesGlobales;
namespace TienditaLapeque
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
            PDF();
            timer1.Enabled = true;
            lblus.Text = Globales.usuario;
           
        }
        public void PDF()
        {
            Globales.document = new Document();
            PdfWriter.GetInstance(Globales.document, new FileStream("Ticket.pdf", FileMode.OpenOrCreate));
            iTextSharp.text.Rectangle docSize = new iTextSharp.text.Rectangle(200f,300f);
            Globales.document.SetPageSize(docSize);
            Globales.document.Open();
            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance("C:/Users/Jose Antonio/Desktop/8vo Cuatrimestre/REINGENIERÍA/RepoTienda/RepositorioR/TienditaLapeque ENTREGA/TienditaLapeque/img/imagenPDF.png");
            imagen.BorderWidth = 0;
            imagen.Alignment = Element.ALIGN_CENTER;
            float percentage = 0.0f;
            percentage = 100 / imagen.Width;
            imagen.ScalePercent(percentage * 100);
            Globales.document.Add(imagen);
            iTextSharp.text.Paragraph parrafo1 = new Paragraph("/Tienda de Abarrotes la peque/");
            parrafo1.Alignment = Element.ALIGN_CENTER;
            Globales.document.Add(parrafo1);
            Globales.document.Add(new Paragraph("Lo atendio: " + Globales.usuario));
            Globales.document.Add(new Paragraph("Fecha de compra: " + DateTime.Now.ToLongDateString()));
            Globales.document.Add(new Paragraph("Ticket de compra"));
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
                    if(idmensaje == 1)
                    {
                          MessageBox.Show("Producto Agregado a la Compra", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (idmensaje == 2)
                    {
                        MessageBox.Show("Producto Eliminado de la Compra", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (idmensaje == 3)
                    {
                        MessageBox.Show("Compra Cancelada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else
                {
                 // MessageBox.Show("Query No Ejecutado");
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
           

            this.lblus.Text = Globales.usuario;
            string selectQuery = "SELECT v.producto, v.precio, v.cp_vendidos as Cantidad_de_Productos, v.nombre_usuario as usuario FROM venta as v where id_venta=" + Globales.auxiliarid+"";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridVenta.DataSource = table;
            

        }
        public void actualizacionbuscar()
        {
            this.lblus.Text = Globales.usuario;
            string selectQuery = "SELECT* FROM productos";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridbuscar.DataSource = table;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
          
        }
    
        int idmensaje=1;
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            closeConnection();
            MySqlDataReader mrd;
            string selectQuery = "SELECT * FROM productos where nom_producto like '" + txtbuscar.Text + "%'";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridbuscar.DataSource = table;
            command = new MySqlCommand(selectQuery, connection);
            openConnection();
            mrd = command.ExecuteReader();
            if (mrd.Read())
            {
              
             //   txtbuscar.Text = "";
            }
            else
            {
                MessageBox.Show("Producto inexistente");
            }

            closeConnection();
        }

        private void dataGridbuscar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         Globales.producto =  txtnombre.Text = dataGridbuscar.CurrentRow.Cells[1].Value.ToString();
            txtprecio.Text = dataGridbuscar.CurrentRow.Cells[2].Value.ToString();
        }
        
        public void valorcantidad()
        {

            openConnection();
            //GUARDAR VALOR DE LA CANTIDAD EN PRODUCTOS
            command = new MySqlCommand("SELECT  cantidad as cant  from productos where nom_producto='" + txtnombre.Text+"'", connection);
            MySqlDataReader leer2 = command.ExecuteReader();
            if (leer2.Read())
            {
                if (leer2["cant"].ToString() != "")
                    Globales.cantidad = Convert.ToString(leer2["cant"]);
            }
        
            closeConnection();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            valorcantidad();
            if (txtcantidad.Text != "")
            {


                if ((Convert.ToInt16(txtcantidad.Text)) <= (Convert.ToInt16(Globales.cantidad)))
                {
                    idmensaje = 1;
                    Globales.precioproducto = Convert.ToDouble(txtprecio.Text) * Convert.ToDouble(txtcantidad.Text);
                    string insertQuery = "INSERT INTO venta VALUES('" + Globales.auxiliarid + "', '" + lblf.Text + "', '" + txtnombre.Text + "', '" + txtprecio.Text + "', '" + txtcantidad.Text + "','" + Globales.usuario + "','" + Globales.precioproducto + "')";
                    executeMyQuery(insertQuery);
                    populateDGV();
                    int a= Convert.ToInt32(Globales.cantidad) - Convert.ToInt32(txtcantidad.Text);
                    string updateQuery = "UPDATE productos SET cantidad=" +a +" WHERE nom_producto = '" + txtnombre.Text + "'";
                    idmensaje = 0;
                    Globales.document.Add(new Paragraph("Producto:     " + txtnombre.Text + "   Precio: " + txtprecio.Text));
                    executeMyQuery(updateQuery);
                    actualizacionbuscar();
                }
                else
                {
                    MessageBox.Show("No hay la cantidad ingresada en el inventario, Por favor ingrese una menor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Por favor ingresa la cantidad de productos a comprar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
           //
           
            if (dataGridVenta.Rows.Count == 0)
            {
                MessageBox.Show("¡Error! No hay ningun producto en la venta actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            valorcantidad();


                if (MessageBox.Show("¿Esta seguro de eliminar este producto de la compra actual?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                        idmensaje = 2;
                    if(Convert.ToString(dataGridVenta.CurrentRow.Cells[0].Value) == "")
                    {
                        MessageBox.Show("¡Error! No hay ningun producto en la venta actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {

                    string deleteQuery = "DELETE FROM venta WHERE producto like'" + dataGridVenta.CurrentRow.Cells[0].Value + "%'";
                        executeMyQuery(deleteQuery);
                        int b = Convert.ToInt32(Globales.cantidad) + Convert.ToInt32(dataGridVenta.CurrentRow.Cells[2].Value);
                        string updateQuery = "UPDATE productos SET cantidad=" + b + " WHERE nom_producto = '" + dataGridVenta.CurrentRow.Cells[0].Value.ToString() + "'";
                        idmensaje = 0;
                        executeMyQuery(updateQuery);
                        populateDGV();
                    }
                   
                }
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            index f = new index();
            f.Show();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de Finalizar la compra?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                openConnection();
              
                command = new MySqlCommand("SELECT sum(subtotal) as sub from venta where id_venta="+ Globales.auxiliarid+"" , connection);
                MySqlDataReader leer = command.ExecuteReader();
                Globales.auxiliarid += 1;
                if (leer.Read())
                {
                    if (leer["sub"].ToString() != "")
                        Globales.totalventas = Convert.ToString(leer["sub"]);
                }
                closeConnection();

                CalculoVenta frmventa = new CalculoVenta();
                frmventa.Show();
                dataGridbuscar.ClearSelection();
                dataGridVenta.ClearSelection();   
                  txtbuscar.Text = "";
                txtcantidad.Text = "";
                  txtnombre.Text = "";
                txtprecio.Text = "";
                populateDGV();
                actualizacionbuscar();
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cancelar la compra?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                idmensaje = 3;
                string deleteQuery = "DELETE FROM venta WHERE id_venta=" + Globales.auxiliarid+"";
                executeMyQuery(deleteQuery);

                populateDGV();
            }
            else
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToLongDateString();
            lblf.Text = DateTime.Now.ToShortDateString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de salir de la pantalla de ventas?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Globales.document.CloseDocument();
                this.Close();
                index frmindex = new index();
                frmindex.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("¡Error! solo se aceptan numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcantidad.Text = "";
            }
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            Globales.document.Add(new Paragraph("Total de la compra:" + Globales.totalventas));
            Globales.document.Close();
            System.Diagnostics.Process.Start("Ticket.pdf");
        }
    }
}
