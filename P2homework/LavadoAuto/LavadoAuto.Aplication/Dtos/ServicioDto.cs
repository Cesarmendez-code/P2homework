using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavadoAuto.Aplication.Dtos
{
    namespace Lavado.Application.Dtos
    {
        public class ServicioDto
        {
            public int IdServicio { get; set; }
            public string Nombre { get; set; }
            public string Tipo { get; set; }
            public decimal Precio { get; set; }
            public TimeSpan DuracionEstimada { get; set; }
        }
    }

}
