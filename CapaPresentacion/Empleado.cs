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
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ModificarCli1_Click(object sender, EventArgs e)
        {
            panelClave.Visible = true;
        }

        private void modificarCli2_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string contra = "admin";

            if (textClave.Text == contra)
            {
                ModificarEmp1.Visible = false;
                modificarEmp2.Visible = true;
                panelClave.Visible = false;

                gridEmpleado.Visible = true;
                btnOculEmp.Visible = true;
                labelBus.Visible = true;
                textBusEmp.Visible = true;

            }
            else 
            { 
            
            }
        }

        
    }
}
