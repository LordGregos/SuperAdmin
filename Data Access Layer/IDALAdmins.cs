using Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer {
    public interface IDALAdmins {
        void AgregarAdmin(Admins adm);

        void BorrarAdmin(int id);

        void ActualizarAdmin(Admins adm);

        Admins GetAdmin(int id);

        void AsignarCiudad(int adminID, Ciudades c);

        List<Admins> ListaAdmins();
    }
}
