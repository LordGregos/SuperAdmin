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
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;


namespace SuperAdmin
{
    public partial class SuperAdmin : Form
    {
        public SuperAdmin()
        {
            InitializeComponent();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            string auxDir = tbCorreo.Text.ToString();
            bool aux = SendMail(auxDir);
        }

        public static bool SendMail(string dir)
        {
            try
            {
                //Configuración del Mensaje para Gmail
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                
                //Correo desde el que se envia el Email y el nombre de la aplicacion
                mail.From = new MailAddress("soporte.cerebro@gmail.com", "Cerebro", Encoding.UTF8);
                
                //Asunto del correo
                mail.Subject = "Prueba de Envío de Correo";
                
                //Mensaje del correo
                mail.Body = "Prueba de Envío de Correo de Gmail desde C# para el barba";
                
                //Destinatario del Email
                mail.To.Add(dir);
                
                //Para enviar un adjunto, hay que especificar la ruta en donde se encuentra
                //mail.Attachments.Add(new Attachment(@"C:\Documentos\carta.docx"));

                //Configuracion del SMTP
                SmtpServer.Port = 587; //Puerto que utiliza Gmail para el servicio
                
                //Credenciales del mail desde el que se envia
                SmtpServer.Credentials = new System.Net.NetworkCredential("soporte.cerebro@gmail.com", "fantauvacerebro");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
