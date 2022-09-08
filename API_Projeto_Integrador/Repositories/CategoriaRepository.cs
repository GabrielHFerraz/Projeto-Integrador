using API_Projeto_Integrador.Controllers;
using Dapper;
using Npgsql;
using System.Data;

namespace API_Projeto_Integrador.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private  IDbConnection _connection;
        
        public CategoriaRepository()
        {
           _connection = new NpgsqlConnection("User ID=postgres;Password=root;Host=localhost;Port=5432;Database=API_Projeto;Pooling=true;Connection Lifetime=0;");
        }

        public List<Categoria> Get()
        {
            return _connection.Query<Categoria>("SELECT * FROM CATEGORIA").ToList();
        }

        public Categoria Get(int id)
        {
            return _connection.QuerySingleOrDefault<Categoria>("SELECT * FROM CATEGORIA WHERE ID = @id",new{ id = id});
         
        }

        public void Insert(Categoria categoria)
        {
            string sql = "INSERT INTO CATEGORIA (Nome)values(@Nome)";
             _connection.Query(sql, categoria);
        }

        public void Update(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            _connection.Query("DELETE FROM CATEGORIA WHERE ID = @id", new {id =id});
        }
    }
}
