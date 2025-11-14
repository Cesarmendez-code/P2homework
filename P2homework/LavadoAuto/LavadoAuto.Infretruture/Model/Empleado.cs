using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace  LavadoAuto.Infretruture.Model
{
    public class EmpleadoModel
    {
        [Key]
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Puesto { get; set; } // Ejemplo: Lavador, Cajero, Supervisor
        public decimal SueldoPorHora { get; set; }

        // Relación: un empleado puede generar varios tickets
        public List<TicketModel> TicketsGenerados { get; set; }

        public EmpleadoModel(int idEmpleado, string nombre, string puesto, decimal sueldoPorHora)
        {
            IdEmpleado = idEmpleado;
            Nombre = nombre;
            Puesto = puesto;
            SueldoPorHora = sueldoPorHora;
            TicketsGenerados = new List<TicketModel>();
        }
    }

}
