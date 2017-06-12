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
using Shared.Entidades;
using Busines_Layer;

namespace PresentationLayer
{
    public partial class SuperAdmin : Form
    {
        private static string auxEx;

        public SuperAdmin()
        {
            InitializeComponent();
            contrasena.Visible = false;
            contrasena.Text = Shared.Cifrado.Generate();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(Verificar() == true)
            {
                GuardarAdmin();
                EnviarMensaje(correo.Text, contrasena.Text, nombre.Text);
            }
        }

        private void GuardarAdmin() {
            IBLAdmins ibladmin = new BLAdminsController();
            Admins adm = new Admins() {
                Contrasena = Shared.Cifrado.CreateSHAHash(contrasena.Text,nombre.Text),
                Nombre = nombre.Text
            };
            ibladmin.AgregarAdmin(adm);

        }

        private static bool EnviarMensaje(string dir, string contrasena, string nombre)
        {
            try
            {
                //Configuración del Mensaje para Gmail
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                //Direccion desde el que se envia el Email
                mail.From = new MailAddress("soporte.cerebro@gmail.com", "Cerebro", Encoding.UTF8);

                //Asunto
                mail.Subject = "TSI 2017- CEREBRO";

                //Mensaje

                string body = "<h3>¡Bienvenido a Cerebro!</h3>";
                body += "<br />";
                body += "Estimad@ Administrador/a,";
                body += "<br />";
                body += "<p>Es un placer darle la bienvenida a nuestra aplicación, agradecemos contar con su servicio!</p>";
                //agregar pagina de creacion !!!!!!!!!!!!!!!!!!
                body += "<p><a href='" + "createcity.cerebro.localhost" + "'>Click aquí</a> para terminar la creación de su ciudad</p>";
                body += "<p>Usuario: <b>" + nombre + "</b> </p>";
                body += "  <p>Contraseña: <b>" + contrasena + "</b></p>";
                body += "<br />";
                body += "Desde ya muchas gracias,";
                body += "<br />";
                body += "<b>Soporte Cerebro</b>";

                mail.Body = body;
                mail.IsBodyHtml = true;
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
                Console.WriteLine(ex.ToString());
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
            /*else if (String.IsNullOrEmpty(ciudad.Text) == true)
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
            }*/
            else
                return true;
        }
    }
}
