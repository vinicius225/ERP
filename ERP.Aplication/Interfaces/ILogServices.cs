using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Aplication.Interfaces
{
    public interface ILogService
    {
        void Adicionar<T, Y>(T jsonObject, Y erroObject, string rota, string verbo);
    }
}
