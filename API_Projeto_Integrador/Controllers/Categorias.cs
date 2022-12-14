using API_Projeto_Integrador.Models;
using API_Projeto_Integrador.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Projeto_Integrador.Controllers
{
    [Route("[controller]")]
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
  
        [HttpGet("/categoria/{id}")]
        public IActionResult Get(int id)
        {
            var categoria = _repository.Get(id);
            if(categoria == null)
            {
                return NotFound();
            }
            return Ok(categoria);
        }

        [HttpPost("/cadastro/categoria")]
        public IActionResult Insert([FromBody]Categoria categoria)
        {
            _repository.Insert(categoria);
            return Ok(categoria);
        }

        [HttpDelete("/delete/categoria")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return Ok();
        }

    }
}
