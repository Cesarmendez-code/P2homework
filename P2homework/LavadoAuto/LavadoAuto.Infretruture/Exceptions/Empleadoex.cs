using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavadoAuto.Infretruture.Exceptions
{
    internal class Empleadoex:Exception
    {
        public Empleadoex() { }

        public Empleadoex(string message) : base(message) { }
    }
}
