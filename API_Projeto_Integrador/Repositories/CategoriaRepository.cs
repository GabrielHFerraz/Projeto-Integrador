using API_Projeto_Integrador.Controllers;

namespace API_Projeto_Integrador.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private static List<Categoria> _db = new List<Categoria>()
        {
            new Categoria() { Id = 1, Nome = "Teste"}
        };

        public List<Categoria> Get()
        {
            return _db;
        }

        public Categoria Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public void Update(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
