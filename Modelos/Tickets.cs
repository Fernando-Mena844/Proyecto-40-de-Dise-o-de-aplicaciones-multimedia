using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class Tickets
    {

        public int idTickets { get; set; }
        public string descripcionTicket { get; set; }
        public Categorias oCategoria { get; set; }
        public Usuario oUsuario { get; set; }
        public Clientes oCliente { get; set; }
        public DateTime fechaRecibido { get; set; }
        public DateTime fechaEntrega { get; set; }

    }
}
