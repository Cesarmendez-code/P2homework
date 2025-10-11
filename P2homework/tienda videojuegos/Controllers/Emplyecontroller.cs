using Microsoft.AspNetCore.Mvc;
using tienda_videojuegos.   DbContex;
using tienda_videojuegos.Dtos;
using tienda_videojuegos.Model.Entities;

namespace tienda_videojuegos.Controllers
    {
        [ApiController]
        [Route("api/[Controller]")]
        public class EmployerController : ControllerBase
        {
            private readonly videogamescontext _aPIContex;
            public EmployerController(videogamescontext aPIContex)
            {
                _aPIContex = aPIContex;
            }
            [HttpGet]
            public IActionResult GetAllCustomers()
            {
                var employes = _aPIContex.Employers.ToList();
                var list = new List<Employedtos>();

                var seleccustomers = employes.Select(e => new Employedtos
                {
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    Email = e.Email,
                    PhoneNumber = e.PhoneNumber


                }).ToList();
                return Ok(seleccustomers);

            }
            [HttpGet("{id}")]
            public IActionResult GetemployeById(int id)
            {
                var employe = _aPIContex.Employers.FirstOrDefault(e => e.Id == id);
                if (employe == null)
                {
                    return NotFound();
                }
                return Ok(employe);
            }
            [HttpPost]
            public IActionResult Createemploye([FromBody] Employedtos employedtos)
            {
                var employe = new Employe
                {

                    FirstName = employedtos.FirstName,
                    LastName = employedtos.LastName,
                    Email = employedtos.Email,
                    PhoneNumber = employedtos.PhoneNumber
                };

                _aPIContex.Add(employe);
                _aPIContex.SaveChanges();
                return Ok(employedtos);
            }


            [HttpPut("{id}")]
            public IActionResult UpdateEmployer(int id, [FromBody] Employedtos employedtos)
            {
                var employe = _aPIContex.Employers.FirstOrDefault(e => e.Id == id);
                if (employe == null)
                {
                    return NotFound($" {id} no encontrado");
                }
            employe.FirstName = employedtos.FirstName;
            employe.LastName = employedtos.LastName;
            employe.Email = employedtos.Email;
            employe.PhoneNumber = employedtos.PhoneNumber;
                _aPIContex.Employers.Update(employe);
                _aPIContex.SaveChanges();
                return NoContent();
            }
            [HttpDelete("{id}")]
            public IActionResult DeleteEmployer(int id, [FromBody] Employedtos employedtos)
            {
                var employe = _aPIContex.Employers.FirstOrDefault(e => e.Id == id);
                if (employe == null)
                {
                    return NotFound($"{id} no encontrado");
                }
            _aPIContex.Employers.Remove(employe);
                _aPIContex.SaveChanges();
                return NoContent();
            }
    }
}





