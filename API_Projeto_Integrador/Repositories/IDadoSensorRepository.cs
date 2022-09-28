using API_Projeto_Integrador.Models;

namespace API_Projeto_Integrador.Repositories
{
     interface IDadoSensorRepository
    {
        public  List<DadoSensor> Get();
        public DadoSensor Get(int id);
        public void Insert(DadoSensor sensor);
        public void Update(DadoSensor sensor);
        public void Delete(int id);
    }
}
