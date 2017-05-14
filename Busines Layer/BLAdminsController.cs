using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Entidades;
using System.Net.Mail;

namespace Busines_Layer
{
    class BLAdminsController : IBLAdmins
    {
        private IDALAdmins _dala = new DALAdminsController();

        public void ActualizarAdmin(Admins adm) {
            _dala.ActualizarAdmin(adm);
        }

        public void AgregarAdmin(Admins adm) {
            _dala.AgregarAdmin(adm);
        }

        public void AsignarCiudad(int adminID, Ciudades c) {
            _dala.AsignarCiudad(adminID, c);
        }

        public void BorrarAdmin(int id) {
            _dala.BorrarAdmin(id);
        }

        public Admins GetAdmin(int id) {
            return _dala.GetAdmin(id);
        }

        public List<Admins> ListaAdmins() {
            return _dala.ListaAdmins();
        }

        public bool EnviarMensaje(string dir) {
            try {
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
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
