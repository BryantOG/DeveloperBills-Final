using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Mensajeria : Form
    {
        const string usuario = "developersbills@gmail.com";
        const string password = "Abc12345_bills";

        public Mensajeria()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            textDestino.Text = "";
            textPara.Text = "";
            textAsunto.Text = "";
            textMensaje.Text = "";
        }

        public static void EnviarCorreo(StringBuilder Mensaje, DateTime FechaEnvio, string De, string Para, string Asunto, out string Error)
        {
            Error = "";
            try
            {
                Mensaje.Append(Environment.NewLine);
                Mensaje.Append(string.Format(" Este correo ha sido enviado el día {0:dd/MM/yyyy} a las {0:HH:mm:ss} \n\n ", FechaEnvio));
                Mensaje.Append(Environment.NewLine);
                MailMessage email = new MailMessage();
                email.From = new MailAddress(De);
                email.To.Add(Para);
                email.Subject = Asunto;
                email.Body = Mensaje.ToString();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(usuario, password);
                smtp.EnableSsl = true;
                smtp.Send(email);
                Error = "Mensaje enviado exitosamente";
                MessageBox.Show(Error, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);




            }
            catch (Exception ex)
            {
                Error = "Error: " + ex.Message;
                MessageBox.Show(Error);
                return;
            }

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Error = "";
            StringBuilder MensajeBuilder = new StringBuilder();
            MensajeBuilder.Append(textMensaje.Text.Trim());
            EnviarCorreo(MensajeBuilder, DateTime.Now, textDestino.Text.Trim(), textPara.Text.Trim(), textAsunto.Text.Trim(), out Error);

            limpiar();
        }

        private void Mensajeria_Load(object sender, EventArgs e)
        {

        }
    }
}

