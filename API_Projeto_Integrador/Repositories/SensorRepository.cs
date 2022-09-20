using API_Projeto_Integrador.Models;
using Dapper;
using Npgsql;
using System.Data;

namespace API_Projeto_Integrador.Repositories
{
    public class SensorRepository : ISensorRepository
    {
        private IDbConnection _connection;

        public SensorRepository()
        {
            _connection = new NpgsqlConnection("User ID=postgres;Password=root;Host=localhost;Port=5432;Database=API_Projeto;Pooling=true;Connection Lifetime=0;");
        }

        public List<Sensor> Get()
        {
            return _connection.Query<Sensor>("SELECT * FROM SENSOR").ToList();
        }

        public Sensor Get(int id)
        {
            return _connection.QueryFirstOrDefault("SELECT * FROM SENSOR WHERE ID = @id", new { id = id });
        }

        public void Insert(Sensor sensor)
        {
            string SQL = ("INSERT INTO SENSOR (Nome,Categoria)Values(@Nome,@Categoria)");
             _connection.Query(SQL, sensor);
        }

        public void Update(Sensor sensor)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            _connection.Query("DELETE FROM SENSOR WHERE ID = @Id", new {id =id});
        }
    }
}
