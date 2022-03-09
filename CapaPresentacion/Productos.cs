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
    public partial class Productos : Form
    {
        Entidad ent = new Entidad();
        Negocio neg = new Negocio();
        public Productos()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Productos_Load(object sender, EventArgs e)
        {
            dataGridProducto.DataSource = neg.N_listarPro();
        }
        void GestionPrd(String accion)
        {
            ent.id = textBoxID.Text;
            ent.Nombre = textBoxNomb.Text;
            ent.Precio = tetBoxPreci.Text;
            ent.Descripcion = textBoxDE.Text;
            ent.Cantidad = texBoxCantid.Text;
            ent.Estado = comBoxEstad.Text;

            ent.accion = accion;

            String v = neg.N_gestionProducto(ent);
            MessageBox.Show(v, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void limpiar()
        {
            textBoxID.Text = "";
            textBoxNomb.Text = "";
            tetBoxPreci.Text = "";
            textBoxDE.Text = "";
            texBoxCantid.Text = "";
            comBoxEstad.Text = "";
        }
        ////AGREGAMOS UN PRODUCTO
        private void Ingresar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea ingresar " + textBoxNomb.Text + "?", "Mensaje",
             MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                GestionPrd("1");
                limpiar();
                dataGridProducto.DataSource = neg.N_listarPro();
            }
        }
        ////MODIFICAMOS LOS REGISTROS DE UN PRODUCTO
        private void modificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea modificar por " + textBoxNomb.Text + "?", "Mensaje",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                GestionPrd("2");
                limpiar();
                dataGridProducto.DataSource = neg.N_listarPro();
            }
        }
        ////BORRAMOS LOS REGISTROS DE UN PRODUCTO
        private void eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar " + textBoxNomb.Text + "?", "Mensaje",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                GestionPrd("3");
                limpiar();
                dataGridProducto.DataSource = neg.N_listarPro();
            }
        }
        ////MOSTRAMOS LOS REGISTROS
        private void reporte_Click(object sender, EventArgs e)
        {
            dataGridProducto.Visible = true;
            buttoOcul.Visible = true;
            textBoxBusc.Visible = true;
            labelBucs.Visible = true;
        }
        ////OCULTAMOS LOS REGISTROS
        private void buttoOcul_Click(object sender, EventArgs e)
        {
            dataGridProducto.DataSource = neg.N_listarPro();
            dataGridProducto.Visible = false;
            buttoOcul.Visible = false;
            textBoxBusc.Visible = false;
            labelBucs.Visible = false;
        }

        private void textBoxBusc_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBusc.Text != "")
            {
                ent.id = textBoxBusc.Text;
                DataTable dt2 = new DataTable();
                dt2 = neg.N_buscarPro(ent);
                dataGridProducto.DataSource = dt2;

            }
            else
            {
                dataGridProducto.DataSource = neg.N_listarPro();
            }
        }

        private void dataGridProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fi = dataGridProducto.CurrentCell.RowIndex;

            textBoxID.Text = dataGridProducto[0, fi].Value.ToString();
            textBoxNomb.Text = dataGridProducto[1, fi].Value.ToString();
            tetBoxPreci.Text = dataGridProducto[2, fi].Value.ToString();
            textBoxDE.Text = dataGridProducto[3, fi].Value.ToString();
            texBoxCantid.Text = dataGridProducto[4, fi].Value.ToString();
            comBoxEstad.Text = dataGridProducto[5, fi].Value.ToString();
        }
    }
}
