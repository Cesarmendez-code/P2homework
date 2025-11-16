using LavadoAuto.Infretruture.Interfaces;
using LavadoAuto.Infretruture.Repositories;
using LavadoAuto.Infretruture.Model;
using Mapster;
using LavadoAuto.Aplication.Dtos;
using LavadoAuto.Aplication.Contract;

namespace Lavado.Application.Services
{
    public class EmpleadoService : IEmpleadoService
    {
        private readonly IEmpleadoRepository _empleado;

        public EmpleadoService(IEmpleadoRepository empleado)
        {
            _empleado = empleado;
        }

        public async Task<EmpleadoDto> CreateEmpleadoAsync(EmpleadoDto empleadoDto)
        {
            var empleado = empleadoDto.Adapt<EmpleadoModel>();
            await _empleado.CreateEmpleadoAsync(empleado);
            return empleadoDto;
        }

        public async Task<List<EmpleadoDto>> GetAllEmpleadosAsync()
        {
            var empleados = await _empleado.GetAllEmpleadosAsync();
            return empleados.Adapt<List<EmpleadoDto>>();
        }

        public async Task<EmpleadoDto> GetEmpleadoByIdAsync(int id)
        {
            var empleado = await _empleado.GetEmpleadoByIdAsync(id);
            return empleado.Adapt<EmpleadoDto>();
        }

        public async Task<EmpleadoDto> UpdateEmpleadoAsync(int id, EmpleadoDto empleadoDto)
        {
            var empleado = empleadoDto.Adapt<EmpleadoModel>();
            await _empleado.UpdateEmpleadoAsync(id, empleado);
            return empleadoDto;
        }

        public async Task DeleteEmpleadoAsync(int id)
        {
            await _empleado.DeleteEmpleadoAsync(id);
        }
    }
}
