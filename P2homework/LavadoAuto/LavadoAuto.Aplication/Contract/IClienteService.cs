using LavadoAuto.Aplication.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using LavadoAuto.Infretruture.Model;

namespace LavadoAuto.Aplication.Contract
{
    public interface IClienteService
    {
        Task<ClienteDTO> CreateClienteAsync(ClienteDTO clienteDto);
        Task DeleteClienteAsync(int id);
        Task<List<ClienteDTO>> GetAllClientesAsync();
        Task<ClienteDTO> GetClienteByIdAsync(int id);
        Task<ClienteDTO> UpdateClienteAsync(int id, ClienteDTO clienteDto);
    }
}
