using Microsoft.AspNetCore.Mvc;
using LavadoAuto.Infretruture.Data;
using LavadoAuto.Aplication.Dtos;
using LavadoAuto.Infretruture.Model;
using LavadoAuto.Aplication.Dtos.Lavado.Application.Dtos;

namespace tienda_videojuegos.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ServicioController : ControllerBase
    {
        private readonly LavadoAutosContext _aPIContex;
        public ServicioController(LavadoAutosContext aPIContex)
        {
            _aPIContex = aPIContex;
        }

        [HttpGet]
        public IActionResult GetAllServicios()
        {
            var servicios = _aPIContex.Servicios.ToList();
            var selecServicios = servicios.Select(e => new ServicioModel
            {
                Nombre = e.Nombre,
                Tipo = e.Tipo,
                Precio = e.Precio,
                DuracionEstimada = e.DuracionEstimada
            }).ToList();

            return Ok(selecServicios);
        }

        [HttpGet("{id}")]
        public IActionResult GetServicioById(int id)
        {
            var servicio = _aPIContex.Servicios.FirstOrDefault(e => e.IdServicio == id);
            if (servicio == null) return NotFound();
            return Ok(servicio);
        }

        [HttpPost]
        public IActionResult CreateServicio([FromBody] ServicioDto servicioDto)
        {
            var servicio = new ServicioModel
            {
                Nombre = servicioDto.Nombre,
                Tipo = servicioDto.Tipo,
                Precio = servicioDto.Precio,
                DuracionEstimada = servicioDto.DuracionEstimada
            };

            _aPIContex.Add(servicio);
            _aPIContex.SaveChanges();
            return Ok(servicioDto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateServicio(int id, [FromBody] ServicioDto servicioDto)
        {
            var servicio = _aPIContex.Servicios.FirstOrDefault(e => e.IdServicio == id);
            if (servicio == null) return NotFound($"{id} no encontrado");

            servicio.Nombre = servicioDto.Nombre;
            servicio.Tipo = servicioDto.Tipo;
            servicio.Precio = servicioDto.Precio;
            servicio.DuracionEstimada = servicioDto.DuracionEstimada;

            _aPIContex.Servicios.Update(servicio);
            _aPIContex.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteServicio(int id, [FromBody] ServicioDto servicioDto)
        {
            var servicio = _aPIContex.Servicios.FirstOrDefault(e => e.IdServicio == id);
            if (servicio == null) return NotFound($"{id} no encontrado");

            _aPIContex.Servicios.Remove(servicio);
            _aPIContex.SaveChanges();
            return NoContent();
        }
    }
}
