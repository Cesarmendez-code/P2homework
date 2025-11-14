using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavadoAuto.Infretruture.Exceptions
{
    internal class Ticket:Exception
    {
        public Ticket() { }

        public Ticket(string message) : base(message) { }
    }
}
