using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LavadoAuto.Infretruture.Model
{
    public class VehiculoModel
    {
       
        public string Name { get; set; }
        [Key]
        public int IdVehiculo { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Tipo { get; set; }
        public int IdCliente { get; set; }
        // Ejemplo: Sedan, SUV, Camioneta

        // Relación: un vehículo pertenece a un cliente
        public ClienteModel  Cliente { get; set; }

        // Relación: un vehículo puede tener varios tickets
        public List<TicketModel> Tickets { get; set; }

        public VehiculoModel(int idVehiculo, string placa, string marca, string modelo, string tipo)
        {
            IdVehiculo = idVehiculo;
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Tipo = tipo;
            Tickets = new List<TicketModel >();
        }
    }
}
