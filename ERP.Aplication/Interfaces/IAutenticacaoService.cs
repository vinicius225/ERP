using ERP.Aplication.Services;
using ERP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Aplication.Interfaces
{
    public interface IAutenticacaoService
    {
        string GerarToken(Usuario usuario);
    }
}
