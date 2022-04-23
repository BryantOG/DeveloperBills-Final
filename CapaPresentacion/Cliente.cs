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
    public partial class Cliente : Form
    {
       
        Entidad entidad = new Entidad();
        Negocio Negocio = new Negocio();
        public Cliente()
        {
            InitializeComponent();
        }

        void GestionCli(String accion)
        {
            entidad.CedulaC = textCeduCl.Text;
            entidad.NombreC = textNombreC.Text;
            entidad.ApellidoC = textApellidoC.Text;
            entidad.CelC = textTelC.Text;
            entidad.DireccionC = textDireccionC.Text;
            entidad.CorreoC = textCorreoC.Text;

            entidad.accion=accion;

            String v = Negocio.N_cliente(entidad);
            MessageBox.Show(v, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Enviar un correo

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
                mail.Subject = Asunto;
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


        void limpiar()
        {
            textCeduCl.Text = "";
            textNombreC.Text = "";
            textApellidoC.Text = "";
            textTelC.Text = "";
            textDireccionC.Text = "";
            textCorreoC.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridCliente.DataSource = Negocio.N_listarcli();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea agregar a " + textNombreC.Text + "?", "Mensaje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                GestionCli("1");


                string Error = "";
                string asuntado2 = "Registro del cliente " + textNombreC.Text;
                StringBuilder mensaje = new StringBuilder();
                mensaje.Append("Se ha creado un usuario en Developers Bills. A nombre de: " + textNombreC.Text.Trim());
                EnviarCorreo(mensaje, DateTime.Now, EmailUser.Trim(), textCorreoC.Text.Trim(), asuntado2.Trim(), out Error);

                limpiar();
                gridCliente.DataSource =Negocio.N_listarcli();
                
            }

           /* string Error = "";
            StringBuilder mensaje = new StringBuilder();
            mensaje.Append("Se ha creado un usuario en Developers Bills. A nombre de :" + textNombreC.Text.Trim());
            EnviarCorreo(mensaje, DateTime.Now, EmailUser.Trim(), textCorreoC.Text.Trim(), "Registro del cliente "+ textNombreC.Text.Trim(), out Error);*/
        

            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            gridCliente.Visible=true;
            btnOculCli.Visible = true;
            textBusCli.Visible =true;
            labelBus.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar a " + textNombreC.Text + "?", "Mensaje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                GestionCli("3");
                limpiar();
                gridCliente.DataSource = Negocio.N_listarcli();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea modificar a " + textNombreC.Text + "?", "Mensaje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                GestionCli("2");
                limpiar();
                gridCliente.DataSource = Negocio.N_listarcli();

            }



        }

        private void button5_Click(object sender, EventArgs e)
        {
            gridCliente.Visible = false;
            textBusCli.Visible = false;
            labelBus.Visible = false;
            btnOculCli.Visible = false;
            modificarCli2.Visible = false;
            ModificarCli1.Visible = true;
        }

        private void modificarCli2_Click(object sender, EventArgs e)
        {
            gridCliente.Visible = false;

            panelClave.Visible = true;

        }

        public void Modificar3_Click(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string contraseña = "admin";

            if (textClave.Text == contraseña)
            {
                modificarCli2.Visible = false;
                ModificarCli1.Visible = true;
                panelClave.Visible = false;

                btnElimina1.Visible=true;
                btnEliminar2.Visible = false;
                gridCliente.Visible = true;
                textBusCli.Visible = true;
                labelBus.Visible = true;
                btnOculCli.Visible = true;
                
                
                textClave.Text = "";


            }
            else
            {
                MessageBox.Show("El usuario o contraseña esta incorrecto");
                textClave.Text = "";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fi = gridCliente.CurrentCell.RowIndex;

            textCeduCl.Text = gridCliente[2, fi].Value.ToString();
            textNombreC.Text = gridCliente[3, fi].Value.ToString();
            textApellidoC.Text = gridCliente[4, fi].Value.ToString();
            textTelC.Text = gridCliente[5, fi].Value.ToString();
            textDireccionC.Text = gridCliente[6, fi].Value.ToString();
            textCorreoC.Text = gridCliente[7, fi].Value.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            gridCliente.Visible = false;
            panelClave.Visible = true;
        }

        private void textTelC_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelClave_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBusCli_TextChanged(object sender, EventArgs e)
        {
            if (textBusCli.Text != "")
            {
                entidad.CedulaC = textBusCli.Text;
                DataTable dt2 = new DataTable();
                dt2 = Negocio.N_buscarCliente(entidad);
                gridCliente.DataSource = dt2;

            }
            else
            {
                gridCliente.DataSource = Negocio.N_listarcli();
            }
        }
    }
}
