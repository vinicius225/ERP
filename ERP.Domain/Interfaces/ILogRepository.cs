using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Interfaces
{
    public interface ILogRepository
    {
        Task Adicionar(string rota, string verbo, string json, string erro);
    }
}
