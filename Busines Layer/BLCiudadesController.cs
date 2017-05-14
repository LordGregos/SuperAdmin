using Data_Access_Layer;
using Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busines_Layer
{
    public class BLCiudadesController : IBLCiudades
    {
        private IDALCiudades IDALC = new DALCiudadesController();

        public void AgregarCiudad(Ciudades aux)
        {
            IDALC.AgregarCiudad(aux);
        }

        public void BorrarCiudad(int id)
        {
            IDALC.BorrarCiudad(id);
        }

        public void ActualizarCiudad(Ciudades aux)
        {
            IDALC.ActualizarCiudad(aux);
        }

        public Ciudades GetCiudad(int id)
        {
            return IDALC.GetCiudad(id);
        }

        public List<Ciudades> ListaCiudades()
        {
            return IDALC.ListaCiudades();
        }

        public String ObtenerURL()
        {
            return "";
        }
    }
}
