using LavadoAuto.Infretruture.core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavadoAuto.Infretruture.Exceptions
{
    public class ClienteEX : Exception
    {
        public ClienteEX() { }

        public ClienteEX(string message) : base(message) { }

    }
}
