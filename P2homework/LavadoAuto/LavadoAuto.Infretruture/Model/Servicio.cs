using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace  LavadoAuto.Infretruture.Model
{
    public class ServicioModel
    {
        [Key]
        public int IdServicio { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; } // Básico, Premium, Full
        public decimal Precio { get; set; }
        public TimeSpan DuracionEstimada { get; set; }

        // Relación: un servicio puede estar en varios tickets
        public List<TicketModel> Tickets { get; set; }

        public ServicioModel(int idServicio, string nombre, string tipo, decimal precio, TimeSpan duracionEstimada)
        {
            IdServicio = idServicio;
            Nombre = nombre;
            Tipo = tipo;
            Precio = precio;
            DuracionEstimada = duracionEstimada;
            Tickets = new List<TicketModel>();
        }
    }
}
