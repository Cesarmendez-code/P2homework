using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavadoAuto.Infretruture.Model
{
    public class TicketModel
    {
        [Key]
        public int IdTicket { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }

        public int IdVehiculo { get; set; }
        public int IdServicio { get; set; }
        public int IdEmpleado { get; set; }

        // Relaciones:
        public VehiculoModel Vehiculo { get; set; }   // Un ticket pertenece a un vehículo
        public EmpleadoModel Empleado { get; set; }   // Un ticket lo genera un empleado
        public ServicioModel Servicio { get; set; }   // Un ticket tiene un servicio asociado

        public TicketModel(int idTicket, DateTime fecha, decimal total)
            {


            IdTicket = idTicket;
            Fecha = fecha;
            Total = total;

        }
    }
}

