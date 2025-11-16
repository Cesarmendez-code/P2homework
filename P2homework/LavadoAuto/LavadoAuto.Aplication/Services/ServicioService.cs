using LavadoAuto.Infretruture.Interfaces;
using LavadoAuto.Infretruture.Model;
using Mapster;
using LavadoAuto.Aplication.Dtos;
using LavadoAuto.Aplication.Contract;
using LavadoAuto.Aplication.Dtos.Lavado.Application.Dtos;

namespace LavadoAuto.Aplication.Services
{
    public class ServicioService : IServicioService
    {
        private readonly IServicio _servicio;

        public ServicioService(IServicio servicio)
        {
            _servicio = servicio;
        }

        public async Task<ServicioDto> CreateServicioAsync(ServicioDto servicioDto)
        {
            var servicio = servicioDto.Adapt<ServicioModel>();
            await _servicio.CreateServicioAsync(servicio);
            return servicioDto;
        }

        public async Task<List<ServicioDto>> GetAllServiciosAsync()
        {
            var servicios = await _servicio.GetAllServiciosAsync();
            return servicios.Adapt<List<ServicioDto>>();
        }

        public async Task<ServicioDto> GetServicioByIdAsync(int id)
        {
            var servicio = await _servicio.GetServicioByIdAsync(id);
            return servicio.Adapt<ServicioDto>();
        }

        public async Task<ServicioDto> UpdateServicioAsync(int id, ServicioDto servicioDto)
        {
            var servicio = servicioDto.Adapt<ServicioModel>();
            await _servicio.UpdateServicioAsync(id, servicio);
            return servicioDto;
        }

        public async Task DeleteServicioAsync(int id)
        {
            await _servicio.DeleteServicioAsync(id);
        }
    }
}
