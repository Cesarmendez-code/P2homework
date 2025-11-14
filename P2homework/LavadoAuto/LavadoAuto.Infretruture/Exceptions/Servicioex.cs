using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavadoAuto.Infretruture.Exceptions
{
    public class Servicioex:Exception
    {
        public Servicioex() { }

        public Servicioex(string message) : base(message) { }
    }
}
