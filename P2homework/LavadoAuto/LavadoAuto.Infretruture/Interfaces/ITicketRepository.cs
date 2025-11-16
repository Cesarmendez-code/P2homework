using  LavadoAuto.Infretruture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavadoAuto.Infretruture.Interfaces
{
    public interface ITicketRepository:IBaserepositorie<TicketModel>
    {
            Task<TicketModel> CreateTicketAsync(TicketModel ticket);
            Task DeleteTicketAsync(int id);
            Task<List<TicketModel>> GetAllTicketsAsync();
            Task<TicketModel> GetTicketByIdAsync(int id);
            Task<TicketModel> UpdateTicketAsync(int id, TicketModel ticket);
        }
    }


