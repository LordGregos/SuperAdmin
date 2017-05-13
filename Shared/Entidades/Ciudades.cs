using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Entidades {
    public partial class Ciudades {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ciudades() {
            this.Admins = new HashSet<Admins>();
        }

        public int CiudadID { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> CoordenadaX { get; set; }
        public Nullable<int> CoordenadaY { get; set; }
        public Nullable<double> Radio { get; set; }
        public string URLLogo { get; set; }
        public string URL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Admins> Admins { get; set; }
    }
}
