using LavadoAuto.Aplication.Dtos;

namespace LavadoAuto.Aplication.Contract
{
    public interface IVehiculoService
    {
        Task<VehiculoDto> CreateVehiculoAsync(VehiculoDto vehiculoDto);
        Task DeleteVehiculoAsync(int id);
        Task<List<VehiculoDto>> GetAllVehiculosAsync();
        Task<VehiculoDto> GetVehiculoByIdAsync(int id);
        Task<VehiculoDto> UpdateVehiculoAsync(int id, VehiculoDto vehiculoDto);
    }
}
