using ERP.Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain
{
    public class ConectionDatabase : IConectionDB
    {
        private readonly IConfiguration _configuration;
        public ConectionDatabase(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string ConexaoDataBase { get => _configuration.GetConnectionString("ERP_Base"); }
    }
}
