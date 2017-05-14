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
            if(Verificar() == true)
            {
                EnviarMensaje(correo.Text);
            }
        }

        private static bool EnviarMensaje(string dir)
        {
            try
            {
                //Configuración del Mensaje para Gmail
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                //Direccion desde el que se envia el Email
                mail.From = new MailAddress("soporte.cerebro@gmail.com", "Cerebro", Encoding.UTF8);

                //Asunto
                mail.Subject = "Prueba de Envío de Correo";

                //Mensaje
                mail.Body = "Gmail desde C#";

                //Destinatario
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

        private bool Verificar()
        {
            if (String.IsNullOrEmpty(nombre.Text) == true)
            {
                MessageBox.Show("Falta el Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (String.IsNullOrEmpty(correo.Text) == true)
            {
                MessageBox.Show("Falta el correo electronico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (String.IsNullOrEmpty(contrasena.Text) == true)
            {
                MessageBox.Show("Falta ingresar una Contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (String.IsNullOrEmpty(ciudad.Text) == true)
            {
                MessageBox.Show("Falta el nombre de la Ciudad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (String.IsNullOrEmpty(cordX.Text) == true)
            {
                MessageBox.Show("Falta una Coordenadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (String.IsNullOrEmpty(cordY.Text) == true)
            {
                MessageBox.Show("Falta una Coordenadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
    }
}
