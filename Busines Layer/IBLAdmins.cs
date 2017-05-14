using Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busines_Layer {
    public interface IBLAdmins {

        void AgregarAdmin(Admins adm);

        void BorrarAdmin(int id);

        void ActualizarAdmin(Admins adm);

        Admins GetAdmin(int id);

        void AsignarCiudad(int adminID, Ciudades c);

        List<Admins> ListaAdmins();

        bool EnviarMensaje(string dir);

    }
}
