using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidad;
using CapaNegocio;



namespace CapaPresentacion
{
    
    public partial class Facturacion : Form
    {
        
        Negocio negocio = new Negocio();
        Entidad entidad = new Entidad();
       

 

        public Facturacion()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("server=DESKTOP-VQDU39N\\SQLEXPRESS;integrated security = yes;Database=Facturacion");
         void GestionFa(String accion)
         {
            
            entidad.IdC= cbbCodigoCliente.Text;
            entidad.NombreC2 = nomcliF.Text;
            entidad.CodigoP2 = cbbCodigoProducto.Text;
            entidad.NombreP2 = textnomp2.Text;
            entidad.DetalleP2 = textDetaP2.Text;
            entidad.PreciopP2 = textPrecioP2.Text;
            entidad.CantidadP2 = CantidaP2.ToString();
            entidad.totalf = txtTotalPago.Text;
            entidad.CodigoEm2 = cbbCodigoEmpleado.Text;
            entidad.FechaF = fechaF.Text;


            entidad.accion = accion;


             String v = negocio.N_gestionFactura(entidad);
             MessageBox.Show(v, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }

        void Inventario(String accion)
        {
            entidad.CantidadP = CantidaP2.Text;
            entidad.CodigoP = cbbCodigoCliente.Text;

            entidad.accion = accion;

            String vv = negocio.inventario(entidad);
            //MessageBox.Show(vv, "Message". MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
            
        void CargarBox()
        {
            cbbCodigoCliente.DataSource = negocio.N_cargarboxcli();
            cbbCodigoCliente.DisplayMember = "Codigo_Cliente";

            cbbCodigoProducto.DataSource = negocio.N_cargarboxPro();
            cbbCodigoProducto.DisplayMember = "Codigo_producto";

            cbbCodigoEmpleado.DataSource = negocio.N_cargarVen();
            cbbCodigoEmpleado.DisplayMember = "Codigo_Empleado";
        }

        public void sumaprecio()
        {
            decimal Total = 0;

            foreach(DataGridViewRow data in gridfacturar.Rows)
            {
                Total += Convert.ToDecimal(data.Cells["ColumTotalPro"].Value);
            
            }

            lblTotal.Text = Total.ToString();
        }
 
       

        private void Facturacion_Load(object sender, EventArgs e)
        {
            CargarBox();

            sumaprecio();


        }

        private void cbbCodigoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea agregar a " + nomcliF.Text + "?", "Mensaje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                GestionFa("1");

                Inventario("1");

            }

            string precio = textPrecioP2.Text;
            int pr = int.Parse(precio);
            int cant = ((int)CantidaP2.Value);

            int total = pr * cant;
            txtTotalPago.Text = total.ToString();


            int n = gridfacturar.Rows.Add();
            

            gridfacturar.Rows[n].Cells[0].Value = cbbCodigoCliente.Text;
            gridfacturar.Rows[n].Cells[1].Value = nomcliF.Text;
            gridfacturar.Rows[n].Cells[2].Value = cbbCodigoProducto.Text;
            gridfacturar.Rows[n].Cells[3].Value = textnomp2.Text;
            gridfacturar.Rows[n].Cells[4].Value = textDetaP2.Text;
            gridfacturar.Rows[n].Cells[5].Value = textPrecioP2.Text;
            gridfacturar.Rows[n].Cells[6].Value = CantidaP2.Text;
            gridfacturar.Rows[n].Cells[7].Value = txtTotalPago.Text;
            gridfacturar.Rows[n].Cells[8].Value = fechaF.Text;
            gridfacturar.Rows[n].Cells[9].Value = cbbCodigoEmpleado.Text;

            sumaprecio();



            cbbCodigoProducto.Text = "";
            textnomp2.Text = "";
            textDetaP2.Text = "";
            textPrecioP2.Text = "";
            CantidaP2.Text = "";
            txtTotalPago.Text = "";
            cbbCodigoEmpleado.Text = "";
        }

        private void addcliente_Click(object sender, EventArgs e)
        {

        }
        

        

        private void cbbCodigoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            SqlCommand cmd = new SqlCommand("select NombresC from cliente where Codigo_Cliente = '" + cbbCodigoCliente.Text + "'", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read()== true)
            {
                nomcliF.Text = reader["NombresC"].ToString();

            }
            conn.Close();

        }

        private void cbbNombreCliente_SelectedIndexChanged(object sender, EventArgs e)
        {



            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            


        }

        private void cbbCodigoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SqlConnection conn2 = new SqlConnection("server=DESKTOP-VQDU39N\\SQLEXPRESS;integrated security = yes;Database=Facturacion");
            SqlCommand cmd2 = new SqlCommand("select Nombre_producto, Detalles_producto, Precio_producto  from productos where Codigo_producto = '" + cbbCodigoProducto.Text + "'", conn);
            conn.Open();
            SqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.Read() == true)
            {
                textnomp2.Text = reader2["Nombre_producto"].ToString();
                textDetaP2.Text = reader2["Detalles_producto"].ToString();
                textPrecioP2.Text = reader2["Precio_producto"].ToString();

            }
            conn.Close();
        }

        private void textnomp2_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtTotalPago_TextChanged(object sender, EventArgs e)
        {

            
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
            
            Bitmap bitmap = new Bitmap(this.gridfacturar.Width, this.gridfacturar.Height );
            gridfacturar.DrawToBitmap(bitmap, new Rectangle(0, 0, this.gridfacturar.Width, this.gridfacturar.Height));

            Image image = Image.FromFile("C:\\Users\\FRANCIS BRYANT\\OneDrive\\Imágenes\\Logo Grup 5.png");

            float x = -20.0F;
            float y = -25.0F;

            RectangleF rectangle = new RectangleF(100.0F, 100.0F, 200.0F, 200.0F);
            GraphicsUnit unit = GraphicsUnit.Pixel;

            //e.PageSettings.Landscape = true;
            e.Graphics.DrawImage(bitmap, -125, 200);
            e.Graphics.DrawString(lblMyText.Text, new Font("Verdana", 16, FontStyle.Bold), Brushes.Black, new Point(200, 30));
            e.Graphics.DrawString(lblTotal2.Text, new Font("Verdana", 20, FontStyle.Bold), Brushes.Black, new Point(100, 800));
            e.Graphics.DrawString(lblTotal.Text, new Font("Verdana", 20, FontStyle.Bold), Brushes.Black, new Point(380, 800));
            e.Graphics.DrawImage(image, x, y, rectangle, unit);
        }
    }
}
