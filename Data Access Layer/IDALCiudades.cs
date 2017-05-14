using Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer {
    public interface IDALCiudades {
        void AgregarCiudad(Ciudades aux);

        void BorrarCiudad(int id);

        void ActualizarCiudad(Ciudades aux);

        Ciudades GetCiudad(int id);

        List<Ciudades> ListaCiudades();

        String ObtenerURL();
    }
}
