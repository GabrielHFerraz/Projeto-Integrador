using API_Projeto_Integrador.Controllers;

namespace API_Projeto_Integrador.Repositories
{
    interface ICategoriaRepository
    {
        public List<Categoria> Get();
        public Categoria Get(int id);
        public void Insert(Categoria categoria);
        public void Update(Categoria categoria);
        public void Delete(int id);
    }
}
