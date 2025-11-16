using LavadoAuto.Infretruture.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LavadoAuto.Infretruture.Interfaces
{
    public interface IServicio : IBaserepositorie<ServicioModel>
    {
        Task<ServicioModel> CreateServicioAsync(ServicioModel servicio);
        Task DeleteServicioAsync(int id);
        Task<List<ServicioModel>> GetAllServiciosAsync();
        Task<ServicioModel> GetServicioByIdAsync(int id);
        Task<ServicioModel> UpdateServicioAsync(int id, ServicioModel servicio);
    }
}
