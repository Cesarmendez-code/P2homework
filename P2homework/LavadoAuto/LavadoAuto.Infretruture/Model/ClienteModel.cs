using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LavadoAuto.Infretruture.Model
{
    public class ClienteModel
    {
        [Key]
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string PuntosFidelidad { get; set; }

       
        public List<VehiculoModel> Vehiculos { get; set; }

        
        public ClienteModel(int idCliente, string nombre, string telefono, string puntos)
        {
            IdCliente = idCliente;
            Nombre = nombre;
            Telefono = telefono;
            PuntosFidelidad = puntos;
            Vehiculos = new List<VehiculoModel>();
        }

        
        public ClienteModel()
        {
            
        }
    }
}
