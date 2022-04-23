using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Producto : Form
    {
        Entidad entidad = new Entidad();
        Negocio negocio = new Negocio();

        public Producto()
        {
            InitializeComponent();
        }

        void GestionPro(String accion)
        {
            entidad.CodigoP = textCodigo.Text;
            entidad.NombreP = textnomPro.Text;
            entidad.DetalleP = textDetallesPro.Text;
            entidad.PrecioP = textprecioPro.Text; 
            entidad.CantidadP = textCantidadPro.Text;
            entidad.accion = accion;

            String v = negocio.N_gestionProducto(entidad);
            MessageBox.Show(v, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void limpiarP()
        {
            textCodigo.Text = "";
            textnomPro.Text = "";
            textDetallesPro.Text = "";
            textprecioPro.Text = "";
            textCantidadPro.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea agregar a " + textnomPro.Text + "?", "Mensaje",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                GestionPro("1");
                limpiarP();
                gridProducto.DataSource = negocio.N_listarpro();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar a " + textnomPro.Text + "?", "Mensaje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                GestionPro("3");
                limpiarP();
                gridProducto.DataSource = negocio.N_listarpro();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Modificar a " + textnomPro.Text + "?", "Mensaje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                GestionPro("2");
                limpiarP();
                gridProducto.DataSource = negocio.N_listarpro();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gridProducto.Visible = true;
            lblBuscar.Visible = true;
            bntOculconsulta.Visible = true;
            textBuscar.Visible = true;
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            gridProducto.DataSource = negocio.N_listarpro();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar1_Click(object sender, EventArgs e)
        {
            gridProducto.Visible = false;

            panelClave.Visible = true;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string contraseña = "admin";

            if (textClave.Text == contraseña)
            {
                btnModificar2.Visible = true;
                btnEliminar2.Visible = true;
                btnModificar1.Visible = false;
                btnEliminar1.Visible = false;
                panelClave.Visible = false;

                gridProducto.Visible = true;
                textBuscar.Visible = true;
                lblBuscar.Visible = true;
                bntOculconsulta.Visible = true;

                textClave.Text = "";


            }
            else
            {
                MessageBox.Show("El usuario o contraseña esta incorrecto");
                textClave.Text = "";
            }
        }

        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            gridProducto.Visible = false;
            panelClave.Visible = true;
        }

        private void bntOculconsulta_Click(object sender, EventArgs e)
        {
            gridProducto.Visible = false;
            lblBuscar.Visible = false;
            bntOculconsulta.Visible = false;
            textBuscar.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textprecioPro_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fi = gridProducto.CurrentCell.RowIndex;

            textCodigo.Text = gridProducto[1, fi].Value.ToString();
            textnomPro.Text = gridProducto[2, fi].Value.ToString();
            textDetallesPro.Text = gridProducto[3, fi].Value.ToString();
            textprecioPro.Text = gridProducto[4, fi].Value.ToString();
            textCantidadPro.Text = gridProducto[5, fi].Value.ToString();
            


        }
    }
}
