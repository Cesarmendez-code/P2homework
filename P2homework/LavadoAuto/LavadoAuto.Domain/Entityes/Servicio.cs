using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace  Lavado.domain.Entityes
{
    public class Servicio
    {
        public int IdServicio { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; } // Básico, Premium, Full
        public decimal Precio { get; set; }
        public TimeSpan DuracionEstimada { get; set; }

        
    }
}
