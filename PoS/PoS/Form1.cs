﻿using System;
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
    public partial class Form1 : Form
    {
        public String nombre;
        public int id;


        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            alerta.Text = "Datos incompletos";
            usuario.BackColor = System.Drawing.ColorTranslator.FromHtml("#90EE90");
            contraseña.BackColor = System.Drawing.ColorTranslator.FromHtml("#90EE90");

            if (usuario.Text == "")
            {
                alerta.Visible = true;
                usuario.BackColor = Color.Salmon;
                contraseña.BackColor = System.Drawing.ColorTranslator.FromHtml("#90EE90");
            }
            else if (contraseña.Text == "")
            {
                alerta.Visible = true;
                contraseña.BackColor = Color.Salmon;
                usuario.BackColor = System.Drawing.ColorTranslator.FromHtml("#90EE90");
            }
            else
            {
                alerta.Visible = false;
                usuario.BackColor = System.Drawing.ColorTranslator.FromHtml("#90EE90");
                contraseña.BackColor = System.Drawing.ColorTranslator.FromHtml("#90EE90");
                String query = "SELECT * FROM usuarios WHERE numero_de_empleado ="+usuario.Text+" AND pws ="+contraseña.Text;

                    try
                    {
                        MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=verificador_de_precios_2; SSL mode=none");
                        mySqlConnection.Open();
                        MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                        MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();


                        if (mySqlDataReader.HasRows)
                        {

                            while (mySqlDataReader.Read()) {

                                nombre = mySqlDataReader.GetString(1) + " " + mySqlDataReader.GetString(2) + " " + mySqlDataReader.GetString(3);
                                id = Convert.ToInt32(mySqlDataReader.GetString(0));
                                MessageBox.Show(id+" "+nombre);

                                PuntoDeVenta PV = new PuntoDeVenta();                        
                                PV.leatiende.Text="Le atiende: "+nombre;

                                PV.Show();
                                this.Hide();
                                
                            }
                            
                        }
                        else
                        {
                            usuario.BackColor = Color.Salmon;
                            contraseña.BackColor = Color.Salmon;
                            alerta.Text = "Datos incorrectos";
                            alerta.Visible = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

            }

            void Form1_Load(object sender, EventArgs e)
            {
                Application.Exit();
            }
        }

        public Form1(String nomUsuario)
        {
            nomUsuario = nombre;
        }
    }
}
