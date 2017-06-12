using Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer {
    public class DALAdminsController : IDALAdmins{

        public void AgregarAdmin(Shared.Entidades.Admins adm) {
            using (var db = new Modelo.autenticacionEntities()) 
            {
                try
                {
                    db.Admins.Add(adm);
                    db.SaveChanges();
                }
                catch(Exception e)
                {
                    //Infierno del programador                
                }
            }

        }

        public void BorrarAdmin(int id) {
            using (var db = new Modelo.autenticacionEntities()) 
            {
            db.Admins.Remove(db.Admins.Find(id));
            db.SaveChanges();
            }
        }

        public void ActualizarAdmin(Admins adm) {
            using (var db = new Modelo.autenticacionEntities()) 
            {
            var admobj = db.Admins.Find(adm.ID);
            admobj.Contrasena = adm.Contrasena;
            admobj.Nombre = adm.Nombre;
            admobj.utilizado = adm.utilizado;
            //admobj.Ciudad = adm.Ciudad;
           // admobj.Ciudades = adm.Ciudades;
            db.SaveChanges();
            }
        }

        public Admins GetAdmin(int id) {
            using (var db = new Modelo.autenticacionEntities()) 
            {
            return db.Admins.Find(id);
            }
        }

        public void AsignarCiudad(int adminID, Ciudades c) {
            using (var db = new Modelo.autenticacionEntities()) 
            {
            var adm = db.Admins.Find(adminID);
            adm.Ciudad = c.CiudadID;
            db.SaveChanges();
            }
        }

        public List<Admins> ListaAdmins() {
            using (var db = new Modelo.autenticacionEntities()) 
            {
            return db.Admins.ToList();
            }
        }
    }
}
