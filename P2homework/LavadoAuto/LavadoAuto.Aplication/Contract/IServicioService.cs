using LavadoAuto.Aplication.Dtos;
using LavadoAuto.Aplication.Dtos.Lavado.Application.Dtos;

namespace LavadoAuto.Aplication.Contract
{
    public interface IServicioService
    {
        Task<ServicioDto> CreateServicioAsync(ServicioDto servicioDto);
        Task DeleteServicioAsync(int id);
        Task<List<ServicioDto>> GetAllServiciosAsync();
        Task<ServicioDto> GetServicioByIdAsync(int id);
        Task<ServicioDto> UpdateServicioAsync(int id, ServicioDto servicioDto);
    }
}
