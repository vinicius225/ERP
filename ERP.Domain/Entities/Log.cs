using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Entities
{
    public class Log
    {
        public int Id { get; set; }
        public string Rota { get; set; }
        public string Verbo { get; set; }
        public string Json { get; set; }
        public string Erro { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
