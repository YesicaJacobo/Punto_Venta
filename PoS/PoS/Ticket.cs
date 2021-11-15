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
    public partial class Ticket : Form
    {
        public double Ttotal;
        public double Tefectivo;
        public double Tcambio;
        public String Tcajero;
        public Ticket()
        {
            InitializeComponent();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {

            total.Text = String.Format("{0:0.00}", "Total: " +Ttotal);
            efectivo.Text = "Efectivo: " + Tefectivo;
            cambio.Text = "Cambio: " + Tcambio;
            cajero.Text = Tcajero;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        
        }
    }
}
