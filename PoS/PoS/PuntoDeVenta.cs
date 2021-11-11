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

namespace PoS
{
    public partial class PuntoDeVenta : Form
    {
        Form2 F2 = new Form2();
        Form1 F1 = new Form1();
        private double total = 0.0;
        private double cambio =0.0;
        private int segundos = 0;
        private int timer = 0;
        private int index = -1;
        private Boolean bandera = false;
        public PuntoDeVenta()
        {
            InitializeComponent();
        }


        private void PuntoDeVenta_Load(object sender, EventArgs e)
        {
            labelBienvenida.Location = new Point(this.Width / 2 - labelBienvenida.Width / 2, 15);

            logo.Width = 400;
            logo.Height = 400;
            logo.Location = new Point(this.Width / 2 - logo.Width/2, labelBienvenida.Height+labelHoraFecha.Height+80);

            perdido.Width = 400;
            perdido.Height = 400;
            perdido.Location = new Point(this.Width / 2 - logo.Width / 2, labelBienvenida.Height + labelHoraFecha.Height + 80);

            labelHoraFecha.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
            labelHoraFecha.Location = new Point(this.Width / 2 - labelHoraFecha.Width / 2, labelBienvenida.Height+40);

            labelPaseCodigo.Location = new Point(this.Width/2 - labelPaseCodigo.Width/2, labelBienvenida.Height + labelHoraFecha.Height + logo.Height +120);

            tablaProductos.Visible = false;
            tablaProductos.Location = new Point(20, labelHoraFecha.Location.Y + labelHoraFecha.Height+10);
            tablaProductos.Width = this.Width - 40;
            tablaProductos.Height = (this.Height / 4) * 3;
            tablaProductos.Columns[0].Width = tablaProductos.Width * 15 / 100;
            tablaProductos.Columns[1].Width = tablaProductos.Width * 45 / 100;
            tablaProductos.Columns[2].Width = tablaProductos.Width * 20 / 100;
            tablaProductos.Columns[3].Width = tablaProductos.Width * 20 / 100;
            tablaProductos.RowTemplate.Height = 60;
            tablaProductos.Columns[2].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            tablaProductos.Columns[3].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            leatiende.Visible = false;

            //codigo.Visible = false;
            //codigo.Location = new Point(10, this.Height - codigo.Height);
            codigo.Location = new Point(this.Width / 2 - 150, this.Height/2+this.Height/4+100);
            codigo.Width = 300;

            labelTotal.Visible = false;
            labelTotal.Location = new Point(this.Width - labelTotal.Width - 250, tablaProductos.Location.Y + tablaProductos.Height + 10);

            menuCaf.Visible = false;
            menuCaf.Location = new Point(150,10);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHoraFecha.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27 && tablaProductos.Rows.Count > 0)
            {
                if (MessageBox.Show("¿Seguro de que quiere eliminar este producto?", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    tablaProductos.Rows.RemoveAt(tablaProductos.Rows.Count - 1);
                    CalcularTotal();
                }

            }
            if (e.KeyChar == 13)
            {

                String query = "SELECT * FROM productos WHERE producto_codigo =" + codigo.Text;
                codigo.Text = "";
                try
                {
                    MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=verificador_de_precios_2; SSL mode=none");
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                    if (mySqlDataReader.HasRows)
                    {     
                        leatiende.Visible = true;
                        leatiende.Location = new Point(200, tablaProductos.Location.Y + tablaProductos.Height + 15);
                        
                        bandera = true;
                        tablaProductos.Visible = true;
                        labelTotal.Visible = true;

                        labelPaseCodigo.Visible = false;

                        codigo.Location = new Point(20, tablaProductos.Location.Y + tablaProductos.Height+15);
                        codigo.Width = 150;

                        logo.Width = 100;
                        logo.Height = 100;
                        logo.Location = new Point(15,10);

                        menuCaf.Visible = true;

                        mySqlDataReader.Read();
                        Boolean producto_rep = false;
                        foreach (DataGridViewRow row in tablaProductos.Rows)
                        {
                            if (mySqlDataReader.GetString(1) == Convert.ToString(row.Cells[1].Value))
                            {
                                producto_rep = true;
                                row.Cells[0].Value = Convert.ToInt32(row.Cells[0].Value) + 1;
                                
                                row.Cells[3].Value = String.Format("{0:0.00}", Convert.ToDouble(row.Cells[0].Value) * Convert.ToDouble(row.Cells[2].Value));
                                break;
                            }
                            else {
                                producto_rep = false;
                            }
                        }
                        if (!producto_rep)
                        {
                            tablaProductos.Rows.Add("1", mySqlDataReader.GetString(1), String.Format("{0:0.00}", mySqlDataReader.GetDouble(3)), String.Format("{0:0.00}", mySqlDataReader.GetDouble(3)), mySqlDataReader.GetDouble(0));
                        }
                        
                        CalcularTotal();
                        codigo.Clear();
                        codigo.Focus();
                    }
                    else
                    {
                        if (bandera)
                        {
                            MessageBox.Show($"Producto no encontrado. Intente nuevamente");
                        }
                        else
                        {
                            logo.Width = 100;
                            logo.Height = 100;
                            logo.Location = new Point(15, 20);

                            codigo.Visible = false;
                            perdido.Visible = true;

                            labelPaseCodigo.Text = "Producto no encontrado. Intente nuevamente";

                            segundos = 0;
                            timer = 15;
                            timer2.Enabled = true;
                        }
                        
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            if (e.KeyChar == 'P' || e.KeyChar == 'p')
            {
                e.Handled = true;

                if (Convert.ToDouble(codigo.Text)>= total)
                {
                    cambio = Math.Round(Convert.ToDouble(codigo.Text) - total, 2);
                    labelTotal.Text = $"Cambio: {cambio}";
                    
                    try
                    {
                        MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=verificador_de_precios_2; SSL mode=none");
                        mySqlConnection.Open();
                        String query = "INSERT INTO ventas VALUES (NULL, CURRENT_DATE(), CURRENT_TIME(), " + F1.id + ")";
                        MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                        mySqlCommand.ExecuteNonQuery();

                        //obtenemos ultimo id de la venta
                        query = "SELECT LAST_INSERT_ID()";
                        mySqlCommand = new MySqlCommand(query, mySqlConnection);
                        MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                        int idVenta = 0;
                        if (mySqlDataReader.HasRows)
                        {
                            mySqlDataReader.Read();
                            idVenta = mySqlDataReader.GetInt32(0);
                        }
                        //insertamos los detalles en venta detalles

                        mySqlConnection.Close();
                        mySqlConnection.Open();

                        for (int i = 0; i < tablaProductos.Rows.Count; i++)
                        {
                            query = "INSERT INTO ventas_detalle (id_venta, id_producto, cantidad, precio_producto) VALUES " +
                                "(" + idVenta + "," + tablaProductos[4, i].Value.ToString() + "," + tablaProductos[0, i].Value.ToString() +
                                "," + tablaProductos[2, i].Value.ToString() + " ) ";
                            mySqlCommand = new MySqlCommand(query, mySqlConnection);
                            mySqlCommand.ExecuteNonQuery();
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Error añadiendo venta a la tabla " + error.ToString());
                    }

                    MessageBox.Show("\n|---------------------------------------------------------------|" +
                                   $"\n|                              Total: {total}                                     |"+
                                   $"\n|                              Cambio: {cambio}                                  |"+ 
                                   $"\n| Gracias por su compra vuelva pronto (^-^)/           |"+
                                    "\n|---------------------------------------------------------------|");

                    tablaProductos.Rows.Clear();
                    codigo.Clear();
                    codigo.Focus();

                    bandera = false; 

                    segundos = 0;
                    timer = 20;
                    timer2.Enabled = true;
                }
                else
                {
                    MessageBox.Show($"Cantidad introducida insuficiente!!!");
                }
                
            }
        }

        private void CalcularTotal()
        {
            total = 0;
            for (int i = 0; i < tablaProductos.Rows.Count; i++)
            {
                total += Double.Parse(tablaProductos[3,i].Value.ToString());
            }
            labelTotal.Text = "Total: " + String.Format("{0:0.00}",total);
        }

		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
    
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            switch (timer)
            {
                case 15:
                    segundos++;
                    if (segundos == timer)
                    {
                        
                        timer2.Enabled = false;

                        labelPaseCodigo.Text = "Por favor pase el codigo del producto en elescaner";

                        codigo.Text = "";
                        perdido.Visible = false;
                        codigo.Visible = true;

                        logo.Width = 400;
                        logo.Height = 400;
                        logo.Location = new Point(this.Width / 2 - logo.Width / 2, labelBienvenida.Height + labelHoraFecha.Height + 80);

                        segundos = 0;
                        timer = 0;
                    }
                        break;
                case 20:
                    segundos++;
                    if (segundos == timer)
                    {
                        timer2.Enabled = false;

                        tablaProductos.Visible = false;
                        labelTotal.Visible = false;
                        labelTotal.Text = "";
                        leatiende.Visible = false;
                        menuCaf.Visible = false;

                        labelPaseCodigo.Visible = true;

                        logo.Width = 400;
                        logo.Height = 400;
                        logo.Location = new Point(this.Width / 2 - logo.Width / 2, labelBienvenida.Height + labelHoraFecha.Height + 80);

                        codigo.Location = new Point(this.Width / 2 - 150, this.Height / 2 + this.Height / 4 + 100);
                        codigo.Width = 300;

                        segundos = 0;
                        timer = 0;
                    }
                        break;
                default:
                    break;
            }
        }

        private void tablaProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27 && tablaProductos.Rows.Count > 0)
            {
                if (MessageBox.Show("¿Seguro de que quiere eliminar este producto?", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int index = tablaProductos.CurrentCell.RowIndex;
                    tablaProductos.Rows.RemoveAt(index);
                   
                    CalcularTotal();
                }
            }
        }

        private void menuCaf_Click(object sender, EventArgs e)
        {

        }
    }
}
