using LavadoAuto.Infretruture.Interfaces;
using LavadoAuto.Infretruture.Model;
using Mapster;
using LavadoAuto.Aplication.Dtos;
using LavadoAuto.Aplication.Contract;


namespace LavadoAuto.Aplication.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticket;

        public TicketService(ITicketRepository ticket)
        {
            _ticket = ticket;
        }

        public async Task<TicketDto> CreateTicketAsync(TicketDto ticketDto)
        {
            var ticket = ticketDto.Adapt<TicketModel>();
            await _ticket.CreateTicketAsync(ticket);
            return ticketDto;
        }

        public async Task<List<TicketDto>> GetAllTicketsAsync()
        {
            var tickets = await _ticket.GetAllTicketsAsync();
            return tickets.Adapt<List<TicketDto>>();
        }

        public async Task<TicketDto> GetTicketByIdAsync(int id)
        {
            var ticket = await _ticket.GetTicketByIdAsync(id);
            return ticket.Adapt<TicketDto>();
        }

        public async Task<TicketDto> UpdateTicketAsync(int id, TicketDto ticketDto)
        {
            var ticket = ticketDto.Adapt<TicketModel>();
            await _ticket.UpdateTicketAsync(id, ticket);
            return ticketDto;
        }

        public async Task DeleteTicketAsync(int id)
        {
            await _ticket.DeleteTicketAsync(id);
        }
    }
}
