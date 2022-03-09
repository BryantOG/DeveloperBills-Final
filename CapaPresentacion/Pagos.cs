using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Pagos : Form
    {
        public Pagos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        ///PAGOS DE EDEESTE
        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://edeeste.com.do/inicio/servicios/consulta-y-pago-de-factura/");
        }
        ///PAGOS DE LA CAASSD
        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://caasdenlinea.com/");

        }
        ///PAGOS DE IMPUESTO DE RENTA
        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ww3.sunat.gob.pe/sol.html");
        }
        ///PAGOS DE SERVICIOS TELEFONICO E INTERNET
        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://serviciosonline.claro.com.do/vzdom/login.do");

        }
        ///PAGO DE MARBETE
        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bancoademi.com.do/dgii-marbete-2021-2020/");

        }
        ///PAGOS DE PROVEEDORES
        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bancoademi.com.do/transferencias/");

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        ///PAGOS DE PATRIMONIO
        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.bancentral.gov.do/a/d/2550-pagos-al-instante");
        }
    }
}
