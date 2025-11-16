using LavadoAuto.Aplication.Dtos;

namespace LavadoAuto.Aplication.Contract
{
    public interface IEmpleadoService
    {
        Task<EmpleadoDto> CreateEmpleadoAsync(EmpleadoDto empleadoDto);
        Task DeleteEmpleadoAsync(int id);
        Task<List<EmpleadoDto>> GetAllEmpleadosAsync();
        Task<EmpleadoDto> GetEmpleadoByIdAsync(int id);
        Task<EmpleadoDto> UpdateEmpleadoAsync(int id, EmpleadoDto empleadoDto);
    }
}