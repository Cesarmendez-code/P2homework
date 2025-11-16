using Microsoft.AspNetCore.Mvc;
using LavadoAuto.Infretruture.Data;
using LavadoAuto.Aplication.Dtos;
using LavadoAuto.Infretruture.Model;

namespace tienda_videojuegos.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class TicketController : ControllerBase
    {
        private readonly LavadoAutosContext _aPIContex;
        public TicketController(LavadoAutosContext aPIContex)
        {
            _aPIContex = aPIContex;
        }

        [HttpGet]
        public IActionResult GetAllTickets()
        {
            var tickets = _aPIContex.Tickets.ToList();
            var selecTickets = tickets.Select(e => new TicketModel
            {
                Fecha = e.Fecha,
                Total = e.Total
            }).ToList();

            return Ok(selecTickets);
        }

        [HttpGet("{id}")]
        public IActionResult GetTicketById(int id)
        {
            var ticket = _aPIContex.Tickets.FirstOrDefault(e => e.IdTicket == id);
            if (ticket == null) return NotFound();
            return Ok(ticket);
        }

        [HttpPost]
        public IActionResult CreateTicket([FromBody] TicketDto ticketDto)
        {
            var ticket = new TicketModel
            {
                Fecha = ticketDto.Fecha,
                Total = ticketDto.Total
            };

            _aPIContex.Add(ticket);
            _aPIContex.SaveChanges();
            return Ok(ticketDto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTicket(int id, [FromBody] TicketDto ticketDto)
        {
            var ticket = _aPIContex.Tickets.FirstOrDefault(e => e.IdTicket == id);
            if (ticket == null) return NotFound($"{id} no encontrado");

            ticket.Fecha = ticketDto.Fecha;
            ticket.Total = ticketDto.Total;

            _aPIContex.Tickets.Update(ticket);
            _aPIContex.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTicket(int id, [FromBody] TicketDto ticketDto)
        {
            var ticket = _aPIContex.Tickets.FirstOrDefault(e => e.IdTicket == id);
            if (ticket == null) return NotFound($"{id} no encontrado");

            _aPIContex.Tickets.Remove(ticket);
            _aPIContex.SaveChanges();
            return NoContent();
        }
    }
}
