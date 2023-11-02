
using ERP.Domain.Entities;
using ERP.Domain.Interfaces;
using Npgsql;
using Dapper;

namespace ERP.Infra.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IConectionDB _conectionDB;
        public UsuarioRepository(IConectionDB conectionDB)
        {
            _conectionDB = conectionDB;
        }
        public async Task Adicionar(Usuario usuario)
        {
            using (var conn = new NpgsqlConnection(_conectionDB.ConexaoDataBase))
            {
                await conn.OpenAsync();

                // Construa a consulta SQL para inserção
                var query = "INSERT INTO usuarios (login, senha, data_criacao, data_alteracao, status) " +
                            "VALUES (@Login, @Senha, @DataCriacao, @DataAlteracao, @Status)";

                await conn.ExecuteAsync(query, usuario);
            }
        }

        public async Task Atualizar(Usuario usuario)
        {
            using (var conn = new NpgsqlConnection(_conectionDB.ConexaoDataBase))
            {
                await conn.OpenAsync();

                // Construa a consulta SQL para atualização
                var query = "UPDATE usuarios SET login = @Login, senha = @Senha, data_criacao = @DataCriacao, data_alteracao = @DataAlteracao, status = @Status " +
                            "WHERE id = @Id";

                conn.ExecuteAsync(query, usuario);
            }
        }

        public async Task AtualizarStatus(int idUsuario, bool status)
        {
            using (var conn = new NpgsqlConnection(_conectionDB.ConexaoDataBase))
            {

                // Construa a consulta SQL para atualização
                var query = "UPDATE usuarios SET status = @Status " +
                            "WHERE id = @Id";

                await conn.ExecuteAsync(query, new {Id = idUsuario, Status = status});
            }
        }

        public async Task<IEnumerable<Usuario>> Listar()
        {
            using (var conn = new NpgsqlConnection(_conectionDB.ConexaoDataBase))
            {
                await conn.OpenAsync();

                // Construa a consulta SQL para buscar o usuário por ID
                var query = "SELECT id, login, senha, data_criacao, data_alteracao, status " +
                            "FROM usuarios " +
                            "WHERE id = @Id";

                return await conn.QueryAsync<Usuario>(query);


            }
        }
        public async Task<Usuario> BuscarPorId(int id)
        {
            using (var conn = new NpgsqlConnection(_conectionDB.ConexaoDataBase))
            {
                await conn.OpenAsync();

                // Construa a consulta SQL para buscar o usuário por ID
                var query = "SELECT id, login, senha, data_criacao, data_alteracao, status " +
                            "FROM usuarios " +
                            "WHERE id = @Id";

                return  conn.QueryAsync<Usuario>(query,new { id = id}).Result.FirstOrDefault() ;

    
            }
        }


    }
}
