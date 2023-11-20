using ERP.Aplication.Interfaces;
using ERP.Domain.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ERP.Aplication.Services
{
    public class LogService : ILogService
    {
        private readonly ILogRepository _logRepository;

        public LogService(ILogRepository logRepository)
        {
            _logRepository = logRepository;
        }

        public void Adicionar<T, Y>(T jsonObject, Y erroObject, string rota, string verbo)
        {
            _logRepository.Adicionar(rota : rota,
                verbo: verbo,
                json: JsonConvert.SerializeObject(jsonObject, Formatting.Indented),
                erro: JsonConvert.SerializeObject(erroObject, Formatting.Indented)
                );
        }
    }
}
