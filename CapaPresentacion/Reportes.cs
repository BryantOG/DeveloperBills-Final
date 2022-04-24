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
        Negocio negocio = new Negocio();

        public Reportes()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            cancelarBtn.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            cancelarBtn.Visible = false;
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            try
            {
                // Carga de datos a grafico de barras
                List<string> productos;
                List<int> cantidad;
                (productos, cantidad) = negocio.getReport();
                chart1.Series[0].Points.DataBindXY(productos, cantidad);

                // Carga de datos a widgets
                List<string> values = negocio.DetalleReporte();
                ttlClientes.Text = values[0];
                ttlProductos.Text = values[1];
                ttlStock.Text = values[2];
                ttlVentas.Text = values[3];

                DataTable topProducts = negocio.TopProducts();
                top1.Text = $"{topProducts.Rows[0]["Producto"]}";
                top2.Text = $"{topProducts.Rows[1]["Producto"]}";
                top3.Text = $"{topProducts.Rows[2]["Producto"]}";
            }
            catch(IndexOutOfRangeException error) {
                Console.WriteLine(error.ToString());
                MessageBox.Show("Al parecer no esta disponible el top 3 de productos debido a la ausencia de ventas de los productos."); 
            }

        }

        private void getReportWithDate(DateTime date1, DateTime date2)
        {
            List<string> productos;
            List<int> cantidad;
            (productos, cantidad) = negocio.getReport(date1, date2);
            if (productos.Count == 0)
                MessageBox.Show("No se han encontrado datos en este periodo");
            else
                chart1.Series[0].Points.DataBindXY(productos, cantidad);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getReportWithDate(DateTime.Today, DateTime.Now);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getReportWithDate(DateTime.Today.AddDays(-7), DateTime.Now);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getReportWithDate(DateTime.Today.AddDays(-30), DateTime.Now);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getReportWithDate(DateTime.Today.AddYears(-1), DateTime.Now);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            getReportWithDate(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value < dateTimePicker1.Value)
                MessageBox.Show("Debe ingresar un rango de fechas correcto:\n\n" +
                    "1 - Ingrese la fecha desde la cual desea visualizar los datos en la primera entrada que lleva por nombre Desde.\n\n" +
                    "2 - Ingrese la fecha hasta  que fecha desea obtener los datos en la segunda entrada que lleva por nombre Hasta.");
            getReportWithDate(dateTimePicker1.Value, dateTimePicker2.Value);
        }
    }
}
