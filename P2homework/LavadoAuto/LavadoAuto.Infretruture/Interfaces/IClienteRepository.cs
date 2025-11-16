using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  LavadoAuto.Infretruture.Model;

namespace LavadoAuto.Infretruture.Interfaces
{
    public  interface IClienteRepository:IBaserepositorie<ClienteModel>
    {
            Task<ClienteModel> CreateClienteAsync(ClienteModel cliente);
            Task DeleteClienteAsync(int id);
            Task<List<ClienteModel>> GetAllClientesAsync();
            Task<ClienteModel> GetClienteByIdAsync(int id);
            Task<ClienteModel> UpdateClienteAsync(int id, ClienteModel cliente);
        }
    }


