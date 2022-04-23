using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    internal class Correo
    {

        const string EmailUser = "developersbills@gmail.com";
        const string EmailPassword = "Abc12345_bills";

        public static void EnviarCorreo(StringBuilder mensaje, DateTime fechaenvio, string De, string Para, string Asunto, out string Error )
        {
            Error = "";

            try
            {
                mensaje.Append(Environment.NewLine);
                mensaje.Append(string.Format("Este corredo ha sido envieado en la fecha de {0:dd/MM/yyyy} en la hora {0:HH:mm:ss} Hrs \n\n", fechaenvio));
                mensaje.Append(Environment.NewLine);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(De);
                mail.To.Add(Para);
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
            catch(Exception ex)
            {
                Error = "Error: " + ex.Message;
                MessageBox.Show(Error);
                return;
            }

        }


    }
}
