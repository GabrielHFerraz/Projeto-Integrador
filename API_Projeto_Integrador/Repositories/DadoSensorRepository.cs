using API_Projeto_Integrador.Models;
using Dapper;
using Npgsql;
using System.Data;

namespace API_Projeto_Integrador.Repositories
{
    public class DadoSensorRepository : IDadoSensorRepository
    {
        private IDbConnection _connection;

        public DadoSensorRepository()
        {
            _connection = new NpgsqlConnection("User ID=postgres;Password=postgres;Host=localhost;Port=5432;Database=API_Projeto;Pooling=true;Connection Lifetime=0;");
        }

        public List<DadoSensor> Get()
        {
            return _connection.Query<DadoSensor>("SELECT * FROM DadoSensor").ToList();
        }

        public DadoSensor Get(int id)
        {
            return _connection.QuerySingleOrDefault<DadoSensor>("SELECT * FROM DadoSensor WHERE ID = @id", new { id = id });
        }

        public void Insert(DadoSensor dadoSensor)
        {
            string sql = "INSERT INTO DADOSENSOR (Valor,Estado)values(@Valor,@Estado)";
            _connection.Query(sql, dadoSensor);
        }

        public void Delete(int id)
        {
            _connection.Query("DELETE FROM DadoSensor WHERE ID = @id", new { id = id });
        }

        public void Update(DadoSensor sensor)
        {
            throw new NotImplementedException();
        }
    }
}
