using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace  Lavado.domain.Entityes
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Puesto { get; set; } // Ejemplo: Lavador, Cajero, Supervisor
        public decimal SueldoPorHora { get; set; }

        
    }

}
