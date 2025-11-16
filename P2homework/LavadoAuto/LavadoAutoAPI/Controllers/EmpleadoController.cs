using Microsoft.AspNetCore.Mvc;
using LavadoAuto.Infretruture.Data;
using LavadoAuto.Aplication.Dtos;
using LavadoAuto.Infretruture.Model;

namespace tienda_videojuegos.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class EmpleadoController : ControllerBase
    {
        private readonly LavadoAutosContext _aPIContex;
        public EmpleadoController(LavadoAutosContext aPIContex)
        {
            _aPIContex = aPIContex;
        }

        [HttpGet]
        public IActionResult GetAllEmpleados()
        {
            var empleados = _aPIContex.Empleados.ToList();
            var selecEmpleados = empleados.Select(e => new EmpleadoModel
            {
              IdEmpleado = e.IdEmpleado,
                Nombre = e.Nombre,
                Puesto = e.Puesto,
                SueldoPorHora = e.SueldoPorHora
            }).ToList();

            return Ok(selecEmpleados);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmpleadoById(int id)
        {
            var empleado = _aPIContex.Empleados.FirstOrDefault(e => e.IdEmpleado == id);
            if (empleado == null) return NotFound();
            return Ok(empleado);
        }

        [HttpPost]
        public IActionResult CreateEmpleado([FromBody] EmpleadoDto empleadoDto)
        {
            var empleado = new EmpleadoModel
            {
                Nombre = empleadoDto.Nombre,
                Puesto = empleadoDto.Puesto,
                SueldoPorHora = empleadoDto.SueldoPorHora
            };

            _aPIContex.Add(empleado);
            _aPIContex.SaveChanges();
            return Ok(empleadoDto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEmpleado(int id, [FromBody] EmpleadoDto empleadoDto)
        {
            var empleado = _aPIContex.Empleados.FirstOrDefault(e => e.IdEmpleado == id);
            if (empleado == null) return NotFound($"{id} no encontrado");

            empleado.Nombre = empleadoDto.Nombre;
            empleado.Puesto = empleadoDto.Puesto;
            empleado.SueldoPorHora = empleadoDto.SueldoPorHora;

            _aPIContex.Empleados.Update(empleado);
            _aPIContex.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmpleado(int id, [FromBody] EmpleadoDto empleadoDto)
        {
            var empleado = _aPIContex.Empleados.FirstOrDefault(e => e.IdEmpleado == id);
            if (empleado == null) return NotFound($"{id} no encontrado");

            _aPIContex.Empleados.Remove(empleado);
            _aPIContex.SaveChanges();
            return NoContent();
        }
    }
}
