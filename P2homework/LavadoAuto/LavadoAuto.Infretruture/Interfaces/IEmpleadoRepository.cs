using  LavadoAuto.Infretruture.Model;
using System;
using LavadoAuto.Infretruture.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavadoAuto.Infretruture.Interfaces
{
    public interface IEmpleadoRepository:IBaserepositorie<EmpleadoModel>
    {
        Task<EmpleadoModel> CreateEmpleadoAsync(EmpleadoModel EmpleadoModel);
        Task DeleteEmpleadoAsync(int id);
        Task<List<EmpleadoModel>> GetAllEmpleadosAsync();
        Task<EmpleadoModel> GetEmpleadoByIdAsync(int id);
        Task<EmpleadoModel> UpdateEmpleadoAsync(int id, EmpleadoModel EmpleadoModel);
    }
}
