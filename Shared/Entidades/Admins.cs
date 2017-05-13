using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Entidades {
    public partial class Admins {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public Nullable<int> Ciudad { get; set; }
        public bool utilizado { get; set; }

        public virtual Ciudades Ciudades { get; set; }
    }
}
