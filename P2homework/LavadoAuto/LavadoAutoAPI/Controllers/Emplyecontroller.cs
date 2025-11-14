using Microsoft.AspNetCore.Mvc;
using LavadoAuto.Infretruture.Data;
using tienda_videojuegos.Dtos;
using LavadoAuto.Infretruture.Model;

namespace tienda_videojuegos.Controllers
    {
        [ApiController]
        [Route("api/[Controller]")]
        public class ClienteController : ControllerBase
        {
            private readonly LavadoAutosContext _aPIContex;
            public ClienteController(LavadoAutosContext aPIContex)
            {
                _aPIContex = aPIContex;
            }
            [HttpGet]
            public IActionResult GetAllCustomers()
            {
                var clientes = _aPIContex.Clientes.ToList();
                var list = new List<ClienteDTO>();

                var seleccustomers = clientes.Select(e => new ClienteModel
                {
                  
                    Nombre = e.Nombre,
                    Telefono = e.Telefono,
                    PuntosFidelidad = e.PuntosFidelidad,
                   


                }).ToList();
                return Ok(seleccustomers);

            }
            [HttpGet("{id}")]
            public IActionResult GetclienteById(int id)
            {
                var cliente = _aPIContex.Clientes.FirstOrDefault(e => e.IdCliente == id);
                if (cliente == null)
                {
                    return NotFound();
                }
                return Ok(cliente);
            }
            [HttpPost]
            public IActionResult Createcliente([FromBody] ClienteDTO clientedtos)
            {
                var cliente = new ClienteModel
                {

                    Nombre = clientedtos.Nombre,
                    Telefono = clientedtos.Telefono,
                    PuntosFidelidad = clientedtos.PuntosFidelidad,
                    
                };

                _aPIContex.Add(cliente);
                _aPIContex.SaveChanges();
                return Ok(clientedtos);
            }


            [HttpPut("{id}")]
            public IActionResult Updateclienter(int id, [FromBody] ClienteDTO clientedtos)
            {
                var cliente = _aPIContex.Clientes.FirstOrDefault(e => e.IdCliente == id);
                if (cliente == null)
                {
                    return NotFound($" {id} no encontrado");
                }
            cliente.Nombre = clientedtos.Nombre;
            cliente.Telefono = clientedtos.Telefono;
            cliente.PuntosFidelidad = clientedtos.PuntosFidelidad;
                _aPIContex.Clientes.Update(cliente);
                _aPIContex.SaveChanges();
                return NoContent();
            }
            [HttpDelete("{id}")]
            public IActionResult Deleteclienter(int id, [FromBody] ClienteDTO clientedtos)
            {
                var cliente = _aPIContex.Clientes.FirstOrDefault(e => e.IdCliente == id);
                if (cliente == null)
                {
                    return NotFound($"{id} no encontrado");
                }
            _aPIContex.Clientes.Remove(cliente);
                _aPIContex.SaveChanges();
                return NoContent();
            }
    }
}





