using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace PresentationLayer
{
    public partial class SuperAdmin : Form
    {
        private static string auxEx;

        public SuperAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnviarMensaje(correo.Text);
        }

        public static bool EnviarMensaje(string dir)
        {
            try
            {
                //Configuración del Mensaje para Gmail
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                //Direccion desde el que se envia el Email
                mail.From = new MailAddress("soporte.cerebro@gmail.com", "Cerebro", Encoding.UTF8);

                //Asunto del Correo
                mail.Subject = "Prueba de Envío de Correo";

                //Mensaje del correo
                mail.Body = "Prueba de Envío de Correo de Gmail desde C# para el barba";

                //Destinatario del Email
                mail.To.Add(dir);
                
                //Configuracion del SMTP
                SmtpServer.Port = 587; //Gmail Port

                //Credenciales del mail desde el que se envia
                SmtpServer.Credentials = new System.Net.NetworkCredential("soporte.cerebro@gmail.com", "fantauvacerebro");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                auxEx = ex.ToString();
                return false;
            }
        }
    }
}
