using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Usuario
    {
        
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string documentoUsuario { get; set; }
        public string contraseniaUsuario { get; set; }
        public string correoUsuario { get; set; }
        public Rol oRol { get; set; }


    }
}
