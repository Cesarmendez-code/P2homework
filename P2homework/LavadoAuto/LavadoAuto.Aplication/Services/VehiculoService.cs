using LavadoAuto.Infretruture.Interfaces;
using LavadoAuto.Infretruture.Model;
using Mapster;
using LavadoAuto.Aplication.Dtos;
using LavadoAuto.Aplication.Contract;

namespace LavadoAuto.Aplication.Services
{
    public class VehiculoService : IVehiculoService
    {
        private readonly IVehiculoRepository  _vehiculo;

        public VehiculoService(IVehiculoRepository  vehiculo)
        {
            _vehiculo = vehiculo;
        }

        public async Task<VehiculoDto> CreateVehiculoAsync(VehiculoDto vehiculoDto)
        {
            var vehiculo = vehiculoDto.Adapt<VehiculoModel>();
            await _vehiculo.CreateVehiculoAsync(vehiculo);
            return vehiculoDto;
        }

        public async Task<List<VehiculoDto>> GetAllVehiculosAsync()
        {
            var vehiculos = await _vehiculo.GetAllVehiculosAsync();
            return vehiculos.Adapt<List<VehiculoDto>>();
        }

        public async Task<VehiculoDto> GetVehiculoByIdAsync(int id)
        {
            var vehiculo = await _vehiculo.GetVehiculoByIdAsync(id);
            return vehiculo.Adapt<VehiculoDto>();
        }

        public async Task<VehiculoDto> UpdateVehiculoAsync(int id, VehiculoDto vehiculoDto)
        {
            var vehiculo = vehiculoDto.Adapt<VehiculoModel>();
            await _vehiculo.UpdateVehiculoAsync(id, vehiculo);
            return vehiculoDto;
        }

        public async Task DeleteVehiculoAsync(int id)
        {
            await _vehiculo.DeleteVehiculoAsync(id);
        }
    }
}
