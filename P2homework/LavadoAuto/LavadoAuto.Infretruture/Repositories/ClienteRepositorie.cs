using LavadoAuto.Infretruture.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  LavadoAuto.Infretruture.Model;
using LavadoAuto.Infretruture.Data;

namespace LavadoAuto.Infretruture.Repositories
{
    public class ClienteRepositorie:Baserepositorie<ClienteModel>
    {
        public ClienteRepositorie(LavadoAutosContext context) : base(context) { }

    }
}
