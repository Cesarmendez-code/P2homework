using LavadoAuto.Aplication.Dtos;

namespace LavadoAuto.Aplication.Contract
{
    public interface ITicketService
    {
        Task<TicketDto> CreateTicketAsync(TicketDto ticketDto);
        Task DeleteTicketAsync(int id);
        Task<List<TicketDto>> GetAllTicketsAsync();
        Task<TicketDto> GetTicketByIdAsync(int id);
        Task<TicketDto> UpdateTicketAsync(int id, TicketDto ticketDto);
    }
}
