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
    public partial class Empleado : Form
    {
        Entidad ent = new Entidad();
        Negocio neg = new Negocio();

        public Empleado()
        {
            InitializeComponent();
        }

        void GestionEmp(String accion)
        {
            ent.CedulaE = textCeduEmp.Text;
            ent.NombreE = textNomEm.Text;
            ent.ApellidoE = textApeEmp.Text;
            ent.CelE = textTelEmp.Text;
            ent.DepartamentoE = textDepEmp.Text;
            ent.CorreE = textCorrEmp.Text;
            
            ent.accion = accion;

            String v = neg.N_gestionEmpleado(ent);
            MessageBox.Show(v, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void limpiarE()
        {
            textCeduEmp.Text = "";
            textNomEm.Text = "";
            textApeEmp.Text = "";
            textTelEmp.Text = "";
            textDepEmp.Text = "";
            textCorrEmp.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ModificarCli1_Click(object sender, EventArgs e)
        {
            gridEmpleados.Visible = false;
            panelClave.Visible = true;
        }

        private void modificarCli2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea modificar a " + textNomEm.Text + "?", "Mensaje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                GestionEmp("2");
                limpiarE();
                gridEmpleados.DataSource = neg.N_listarEmp();

            }

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string contra = "admin";

            if (textClave.Text == contra)
            {
                ModificarEmp1.Visible = false;
                modificarEmp2.Visible = true;
                panelClave.Visible = false;
                btnelim2.Visible = false;


                gridEmpleados.Visible = true;
                btnElim1.Visible = true;
                btnOculEmp.Visible = true;
                labelBus.Visible = true;
                textBusEmp.Visible = true;

            }
            else 
            { 
            
            }
        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            
            gridEmpleados.DataSource = neg.N_listarEmp();

        }

        private void textDepEmp_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea agregar a " + textNomEm.Text + "?", "Mensaje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                GestionEmp("1");
                limpiarE();
                gridEmpleados.DataSource = neg.N_listarEmp();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gridEmpleados.Visible = true;
            btnOculEmp.Visible = true;
            textBusEmp.Visible = true;
            labelBus.Visible = true;
        }

        private void btnOculEmp_Click(object sender, EventArgs e)
        {
            gridEmpleados.DataSource = neg.N_listarEmp();
            gridEmpleados.Visible = false;
            btnOculEmp.Visible = false;
            textBusEmp.Visible = false;
            labelBus.Visible = false;
        }

        private void gridEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridEmpleados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int fi = gridEmpleados.CurrentCell.RowIndex;

            textCeduEmp.Text = gridEmpleados[1, fi].Value.ToString();
            textNomEm.Text = gridEmpleados[2, fi].Value.ToString();
            textApeEmp.Text = gridEmpleados[3, fi].Value.ToString();
            textTelEmp.Text = gridEmpleados[4, fi].Value.ToString();
            textDepEmp.Text = gridEmpleados[5, fi].Value.ToString();
            textCorrEmp.Text = gridEmpleados[6, fi].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea agregar a " + textNomEm.Text + "?", "Mensaje",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                GestionEmp("3");
                limpiarE();
                gridEmpleados.DataSource = neg.N_listarEmp();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gridEmpleados.Visible = false;
            panelClave.Visible = true;
        }

        private void textBusEmp_TextChanged(object sender, EventArgs e)
        {
            if (textBusEmp.Text != "")
            {
                ent.CedulaE = textBusEmp.Text;
                DataTable dt2 = new DataTable();
                dt2 = neg.N_buscarempleado(ent);
                gridEmpleados.DataSource = dt2;

            }
            else
            {
                gridEmpleados.DataSource = neg.N_listarEmp();
            }
        }
    }
}
