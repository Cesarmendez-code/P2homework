using  LavadoAuto.Infretruture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavadoAuto.Infretruture.Interfaces
{
    public interface IVehiculoRepository:IBaserepositorie<VehiculoModel>
    {

        
            Task<VehiculoModel> CreateVehiculoAsync(VehiculoModel vehiculo);
            Task DeleteVehiculoAsync(int id);
            Task<List<VehiculoModel>> GetAllVehiculosAsync();
            Task<VehiculoModel> GetVehiculoByIdAsync(int id);
            Task<VehiculoModel> UpdateVehiculoAsync(int id, VehiculoModel vehiculo);
        
    }

}
