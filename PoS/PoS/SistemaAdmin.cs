using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoS
{
    public partial class SistemaAdmin : Form
    {
        public SistemaAdmin()
        {
            InitializeComponent();
            tabla.Visible = false;
        }

        private void productoMasVendidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=verificador_de_precios_2; SSL mode=none");
                mySqlConnection.Open();
                String query = "SELECT ventas_detalle.id_producto, producto_nombre,COUNT(ventas_detalle.id_producto) as cantidad FROM productos INNER JOIN ventas_detalle USING (id_producto) GROUP BY ventas_detalle.id_producto HAVING cantidad = ( SELECT COUNT(ventas_detalle.id_producto) FROM ventas_detalle INNER JOIN productos USING (id_producto) GROUP BY ventas_detalle.id_producto ORDER BY COUNT(ventas_detalle.id_producto)DESC LIMIT 1) ORDER BY cantidad;";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                tabla.Rows.Clear();
                tabla.Columns["Column3"].Visible = true;

                while (mySqlDataReader.Read()){
                    info.Text = "A continación se muestra el producto más vendido";
                    info2.Visible = false;
                    tabla.Visible = true;
                    
                    tabla.Columns["Column1"].HeaderText = "Id:";
                    tabla.Columns["Column2"].HeaderText = "Nombre:";
                    tabla.Columns["Column3"].HeaderText = "Cantidad vendida:";
                    tabla.Rows.Add(mySqlDataReader.GetString(0), mySqlDataReader.GetString(1), mySqlDataReader.GetString(2));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SistemaAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabla.Visible = false;

            this.Hide();

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabla.Visible = false;
            info2.Visible = true;
            info2.Text = "Proyecto para Administración de Proyectos Informaticos II\nDesarollado por:\n-Salma Iturbe\n-Yesica Jacobo\n-Denia Lomas\n\n\nPunto de ventas para \"Super del Sur\"";
        }

        private void productoMenosVendidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=verificador_de_precios_2; SSL mode=none");
                mySqlConnection.Open();
                String query = "SELECT ventas_detalle.id_producto, producto_nombre, COUNT(ventas_detalle.id_producto) as cantidad FROM productos INNER JOIN ventas_detalle USING (id_producto) GROUP BY ventas_detalle.id_producto HAVING cantidad = ( SELECT COUNT(ventas_detalle.id_producto) FROM ventas_detalle INNER JOIN productos USING (id_producto) GROUP BY ventas_detalle.id_producto ORDER BY COUNT(ventas_detalle.id_producto) LIMIT 1) ORDER BY cantidad;";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                tabla.Rows.Clear();
                tabla.Columns["Column3"].Visible = true;

                while (mySqlDataReader.Read())
                {
                    info.Text = "A continación se muestra el producto menos vendido";
                    info2.Visible = false;
                    tabla.Visible = true;
                    
                    tabla.Columns["Column1"].HeaderText = "Id:";
                    tabla.Columns["Column2"].HeaderText = "Nombre:";
                    tabla.Columns["Column3"].HeaderText = "Cantidad vendida:";
                    tabla.Rows.Add(mySqlDataReader.GetString(0), mySqlDataReader.GetString(1), mySqlDataReader.GetString(2));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void vendedorMásProductivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=verificador_de_precios_2; SSL mode=none");
                mySqlConnection.Open();
                String query = "SELECT nombre, apellido, COUNT(id_usuario) AS numero_ventas FROM `usuarios` INNER JOIN ventas ON id_usuario = operadorVenta WHERE permisosUsuario = 1 GROUP BY id_usuario HAVING numero_ventas = ( SELECT COUNT(ventas.operadorVenta) FROM ventas INNER JOIN usuarios ON id_usuario = operadorVenta GROUP BY ventas.operadorVenta ORDER BY COUNT(ventas.operadorVenta) DESC LIMIT 1) ORDER BY numero_ventas;";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                tabla.Rows.Clear();
                tabla.Columns["Column3"].Visible = true;

                while (mySqlDataReader.Read())
                {
                    info.Text = "A continación se muestra el vendedor más productivo";
                    info2.Visible = false;
                    tabla.Visible = true;

                    tabla.Columns["Column1"].HeaderText = "Nombre:";
                    tabla.Columns["Column2"].HeaderText = "Apellidos:";
                    tabla.Columns["Column3"].HeaderText = "Ventas Realizadas:";
                    tabla.Rows.Add(mySqlDataReader.GetString(0), mySqlDataReader.GetString(1), mySqlDataReader.GetString(2));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void vendedorMenosProductivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=verificador_de_precios_2; SSL mode=none");
                mySqlConnection.Open();
                String query = "SELECT nombre, apellido, COUNT(id_usuario) AS numero_ventas FROM `usuarios` INNER JOIN ventas ON id_usuario = operadorVenta WHERE permisosUsuario = 1 GROUP BY id_usuario HAVING numero_ventas = ( SELECT COUNT(ventas.operadorVenta) FROM ventas INNER JOIN usuarios ON id_usuario = operadorVenta GROUP BY ventas.operadorVenta ORDER BY COUNT(ventas.operadorVenta) LIMIT 1) ORDER BY numero_ventas;";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                tabla.Rows.Clear();
                tabla.Columns["Column3"].Visible = true;

                while (mySqlDataReader.Read())
                {
                    info.Text = "A continación se muestra el vendedor menos productivo";
                    info2.Visible = false;
                    tabla.Visible = true;

                    tabla.Columns["Column1"].HeaderText = "Nombre:";
                    tabla.Columns["Column2"].HeaderText = "Apellidos:";
                    tabla.Columns["Column3"].HeaderText = "Ventas Realizadas:";
                    tabla.Rows.Add(mySqlDataReader.GetString(0), mySqlDataReader.GetString(1), mySqlDataReader.GetString(2));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ventasPorDíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=verificador_de_precios_2; SSL mode=none");
                mySqlConnection.Open();
                String query = "SELECT fechaventa, COUNT(*) FROM ventas GROUP BY fechaventa;";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                tabla.Rows.Clear();
                tabla.Columns["Column3"].Visible = false;

                while (mySqlDataReader.Read())
                {
                    info.Text = "A continación se muestrn las ventas por día";
                    info2.Visible = false;
                    tabla.Visible = true;

                    tabla.Columns["Column1"].HeaderText = "Día:";
                    tabla.Columns["Column2"].HeaderText = "Ventas hechas en ese día:";
                    tabla.Rows.Add(mySqlDataReader.GetString(0), mySqlDataReader.GetString(1));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
