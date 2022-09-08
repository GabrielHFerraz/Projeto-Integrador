using API_Projeto_Integrador.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Projeto_Integrador.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Categorias : ControllerBase
    {
        private ICategoriaRepository _repository;
        public Categorias()
        {
            _repository = new CategoriaRepository();
        }

        [HttpGet]   
        public IActionResult Get()
        {
            return Ok(_repository.Get());
        }
        
    }
}
