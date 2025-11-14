using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavadoAuto.Infretruture.Exceptions
{
    public class Vehiculoex:Exception
    {
        public Vehiculoex() { }

        public Vehiculoex(string message) : base(message) { }

    }
}
