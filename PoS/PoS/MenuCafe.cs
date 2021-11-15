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
    public partial class MenuCafe : Form

    {
        public String codCafe="";

        public MenuCafe()
        {
            InitializeComponent();
            ToolTip tipoCafe = new ToolTip();
            tipoCafe.SetToolTip(cafeCH, "Chico(12oz)");
            tipoCafe.SetToolTip(cafeM, "Mediano(20oz)");
            tipoCafe.SetToolTip(cafeG, "Grande(30oz)");
        }

        public void button1_Click(object sender, EventArgs e)
        {
            codCafe = "101";
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            codCafe = "102";
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            codCafe = "103";
            this.Close();
        }
    }
}
