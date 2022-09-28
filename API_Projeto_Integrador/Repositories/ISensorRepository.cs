using API_Projeto_Integrador.Models;

namespace API_Projeto_Integrador.Repositories
{
    public interface ISensorRepository
    {
        public List<Sensor> Get();
        public Sensor Get(int id);
        public void Insert(Sensor sensor);
        public void Update(Sensor sensor);
        public void Delete(int id);
    }
}
