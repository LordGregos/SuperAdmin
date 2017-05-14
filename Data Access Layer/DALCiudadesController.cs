using Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer {
    public class DALCiudadesController : IDALCiudades{

        public void AgregarCiudad(Ciudades aux)
        {
            using (var db = new Modelo.autenticacionEntities())
            {
                db.Ciudades.Add(aux);
                db.SaveChanges();
            }

        }

        public void BorrarCiudad(int id)
        {
            using (var db = new Modelo.autenticacionEntities())
            {
                db.Ciudades.Remove(db.Ciudades.Find(id));
                db.SaveChanges();
            }
        }

        public void ActualizarCiudad(Ciudades aux)
        {
            using (var db = new Modelo.autenticacionEntities())
            {
                var ciudad = db.Ciudades.Find(aux.CiudadID);
                ciudad.Nombre = aux.Nombre;
                ciudad.Radio = aux.Radio;
                ciudad.CoordenadaX = aux.CoordenadaX;
                ciudad.URLLogo = aux.URLLogo;
                db.SaveChanges();
            }
        }

        public Ciudades GetCiudad(int id)
        {
            using (var db = new Modelo.autenticacionEntities())
            {
                return db.Ciudades.Find(id);
            }
        }

        public List<Ciudades> ListaCiudades()
        {
            using (var db = new Modelo.autenticacionEntities())
            {
                return db.Ciudades.ToList();
            }
        }

    }
}
