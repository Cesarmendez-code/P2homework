using Microsoft.AspNetCore.Mvc;
using LavadoAuto.Infretruture.Data;
using LavadoAuto.Aplication.Dtos;
using LavadoAuto.Infretruture.Model;

namespace tienda_videojuegos.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class VehiculoController : ControllerBase
    {
        private readonly LavadoAutosContext _aPIContex;
        public VehiculoController(LavadoAutosContext aPIContex)
        {
            _aPIContex = aPIContex;
        }

        [HttpGet]
        public IActionResult GetAllVehiculos()
        {
            var vehiculos = _aPIContex.Vehiculos.ToList();
            var selecVehiculos = vehiculos.Select(e => new VehiculoModel
            {
                Placa = e.Placa,
                Marca = e.Marca,
                Modelo = e.Modelo,
                Tipo = e.Tipo
            }).ToList();

            return Ok(selecVehiculos);
        }

        [HttpGet("{id}")]
        public IActionResult GetVehiculoById(int id)
        {
            var vehiculo = _aPIContex.Vehiculos.FirstOrDefault(e => e.IdVehiculo == id);
            if (vehiculo == null) return NotFound();
            return Ok(vehiculo);
        }

        [HttpPost]
        public IActionResult CreateVehiculo([FromBody] VehiculoDto vehiculoDto)
        {
            var vehiculo = new VehiculoModel
            {
                Placa = vehiculoDto.Placa,
                Marca = vehiculoDto.Marca,
                Modelo = vehiculoDto.Modelo,
                Tipo = vehiculoDto.Tipo
            };

            _aPIContex.Add(vehiculo);
            _aPIContex.SaveChanges();
            return Ok(vehiculoDto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateVehiculo(int id, [FromBody] VehiculoDto vehiculoDto)
        {
            var vehiculo = _aPIContex.Vehiculos.FirstOrDefault(e => e.IdVehiculo == id);
            if (vehiculo == null) return NotFound($"{id} no encontrado");

            vehiculo.Placa = vehiculoDto.Placa;
            vehiculo.Marca = vehiculoDto.Marca;
            vehiculo.Modelo = vehiculoDto.Modelo;
            vehiculo.Tipo = vehiculoDto.Tipo;

            _aPIContex.Vehiculos.Update(vehiculo);
            _aPIContex.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVehiculo(int id, [FromBody] VehiculoDto vehiculoDto)
        {
            var vehiculo = _aPIContex.Vehiculos.FirstOrDefault(e => e.IdVehiculo == id);
            if (vehiculo == null) return NotFound($"{id} no encontrado");

            _aPIContex.Vehiculos.Remove(vehiculo);
            _aPIContex.SaveChanges();
            return NoContent();
        }
    }
}
