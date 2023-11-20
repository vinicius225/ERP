using ERP.Domain.Interfaces;
using Npgsql;
using Dapper;

namespace ERP.Infra.Data.Repositories
{
    public class LogRepository : ILogRepository
    {
        private readonly IConectionDB _conectionDB;

        public LogRepository(IConectionDB conectionDB)
        {
            _conectionDB = conectionDB;
        }

        public async Task Adicionar(string rota, string verbo, string json, string erro)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_conectionDB.ConexaoDataBase))
                {
                    conn.Open();
                    string sql = $"insert into LOG (Rota, Verbo, Json, Erro, DataCadastro) values('{rota}', '{verbo}, '{json}', '{erro}', '{DateTime.Now}') ";
                    await conn.ExecuteAsync(sql);
                }
            }
            catch
            {
            }
        }
    }
}
