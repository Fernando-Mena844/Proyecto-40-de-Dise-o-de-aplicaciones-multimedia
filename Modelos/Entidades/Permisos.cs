using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
   public class Permisos
    {
        public int idPermisos { get; set; }
        public Rol oRol { get; set; }
        public string descripcionPermiso { get; set; }
    }
}
