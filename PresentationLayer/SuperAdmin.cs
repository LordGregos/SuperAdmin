using System;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using Shared.Entidades;
using Busines_Layer;

namespace PresentationLayer
{
    public partial class SuperAdmin : Form
    {
        public SuperAdmin()
        {
            InitializeComponent();
            contrasena.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Verificar() == true)
                {
                    contrasena.Text = Cifrado.Generate();
                    string usuarioAux = usuario.Text;
                    GuardarAdmin();
                    EnviarMensaje(correo.Text, nombre.Text, contrasena.Text, usuario.Text);
                    correo.Text = "";
                    nombre.Text = "";
                    contrasena.Text = "";
                    usuario.Text = "";
                    MessageBox.Show("Admin " + usuarioAux + " se guardo correctamente.");
                }
            }
            catch(Exception excepcion)
            {
                MessageBox.Show("- ERROR #404 -\n \n" + excepcion);
            }            
        }

        private void GuardarAdmin() {
            IBLAdmins ibladmin = new BLAdminsController();
            string contrasenaAux = Cifrado.CreateSHAHash(contrasena.Text,usuario.Text);
            Admins adm = new Admins() {

                Contrasena = contrasenaAux,
                Nombre = usuario.Text
            };
            ibladmin.AgregarAdmin(adm);

        }

        private static void EnviarMensaje(string dir, string nombre, string contrasena, string usuario)
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
                body += "Estimad@ " + nombre + ",";
                body += "<br />";
                body += "<p>Es un placer darle la bienvenida a nuestra aplicación, agradecemos contar con su servicio!</p>";
                body += "<p><a href='" + "createcity.cerebro.localhost" + "'>Click aquí</a> para terminar la creación de su ciudad</p>";
                body += "<p>Usuario: <b>" + usuario + "</b> </p>";
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());                
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
            else if (String.IsNullOrEmpty(usuario.Text) == true)
            {
                MessageBox.Show("Falta el nombre del Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
    }
}
