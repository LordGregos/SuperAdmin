using Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busines_Layer
{
    public interface IBLCiudades
    {
        void AgregarCiudad(Ciudades aux);

        void BorrarCiudad(int id);

        void ActualizarCiudad(Ciudades aux);

        Ciudades GetCiudad(int id);

        List<Ciudades> ListaCiudades();
    }
}
