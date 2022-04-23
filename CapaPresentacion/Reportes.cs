using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Reportes : Form
    {
        Entidad entidad = new Entidad();
        Negocio negocio = new Negocio();

        public Reportes()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            gridReportes.DataSource = negocio.N_listarFactura();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                entidad.FechaF = textBox3.Text;
                DataTable dt2 = new DataTable();
                dt2 = negocio.N_buscarFactura(entidad);
                gridReportes.DataSource = dt2;

            }
            else
            {
                gridReportes.DataSource = negocio.N_listarFactura();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                entidad.IdC= textBox1.Text;
                DataTable dt2 = new DataTable();
                dt2 = negocio.N_buscarFacturaCli(entidad);
                gridReportes.DataSource = dt2;

            }
            else
            {
                gridReportes.DataSource = negocio.N_listarFactura();
            }
        }
    }
}
