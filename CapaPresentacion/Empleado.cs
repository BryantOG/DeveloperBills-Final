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
using System.Net.Mail;

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

        const string EmailUser = "developersbills@gmail.com";
        const string EmailPassword = "Abc12345_bills";

        public static void EnviarCorreo(StringBuilder mensaje, DateTime fechaenvio, string De, string Para, string Asunto, out string Error)
        {
            Error = "";

            try
            {
                mensaje.Append(Environment.NewLine);
                mensaje.Append(string.Format("Este correo ha sido enviado en la fecha {0:dd/MM/yyyy} - hora {0:HH:mm:ss} Hrs \n\n", fechaenvio));
                mensaje.Append(Environment.NewLine);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(De);
                mail.To.Add(Para);
                mail.Subject= Asunto;
                mail.Body = mensaje.ToString();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(EmailUser, EmailPassword);
                smtp.EnableSsl = true;
                smtp.Send(mail);
                Error = "Enviado con existo";
                MessageBox.Show(Error);

            }
            catch (Exception ex)
            {
                Error = "Error: " + ex.Message;
                MessageBox.Show(Error);
                return;
            }

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
                MessageBox.Show("El usuario o contraseña esta incorrecto");
                textClave.Text = "";
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
                string Error = "";
                string asunto = "Registro del empleado " + textNomEm.Text;
                StringBuilder mensaje = new StringBuilder();
                mensaje.Append("Se ha creado un usuario de empleado en Developers Bills. A nombre de:" + textNomEm.Text.Trim() + " Si no conoce de la actividad, favor comuniquese a este correo.");
                EnviarCorreo(mensaje, DateTime.Now, EmailUser.Trim(), textCorrEmp.Text.Trim(), asunto.Trim(), out Error);


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

            textCeduEmp.Text = gridEmpleados[2, fi].Value.ToString();
            textNomEm.Text = gridEmpleados[3, fi].Value.ToString();
            textApeEmp.Text = gridEmpleados[4, fi].Value.ToString();
            textTelEmp.Text = gridEmpleados[5, fi].Value.ToString();
            textDepEmp.Text = gridEmpleados[6, fi].Value.ToString();
            textCorrEmp.Text = gridEmpleados[7, fi].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar a " + textNomEm.Text + "?", "Mensaje",
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
