using LavadoAuto.Infretruture.Interfaces;
using LavadoAuto.Infretruture.Model;
using Mapster;
using LavadoAuto.Aplication.Dtos;
using LavadoAuto.Aplication.Contract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LavadoAuto.Aplication.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _cliente;

        public ClienteService(IClienteRepository cliente)
        {
            _cliente = cliente;
        }

        public async Task<ClienteDTO> CreateClienteAsync(ClienteDTO clienteDto)
        {
            var cliente = clienteDto.Adapt<ClienteModel>();
            await _cliente.CreateClienteAsync(cliente);
            return clienteDto;
        }

        public async Task<List<ClienteDTO>> GetAllClientesAsync()
        {
            var clientes = await _cliente.GetAllClientesAsync();
            return clientes.Adapt<List<ClienteDTO>>();
        }

        public async Task<ClienteDTO> GetClienteByIdAsync(int id)
        {
            var cliente = await _cliente.GetClienteByIdAsync(id);
            return cliente.Adapt<ClienteDTO>();
        }

        public async Task<ClienteDTO> UpdateClienteAsync(int id, ClienteDTO clienteDto)
        {
            var cliente = clienteDto.Adapt<ClienteModel>();
            await _cliente.UpdateClienteAsync(id, cliente);
            return clienteDto;
        }

        public async Task DeleteClienteAsync(int id)
        {
            await _cliente.DeleteClienteAsync(id);
        }
    }
}
