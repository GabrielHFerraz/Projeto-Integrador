using API_Projeto_Integrador.Models;
using API_Projeto_Integrador.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Projeto_Integrador.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DadosSensor : ControllerBase
    {
        private IDadoSensorRepository _repository;
        public DadosSensor()
        {
            _repository = new DadoSensorRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.Get());
        }

        [HttpGet("/dadosensor/{id}")]
        public IActionResult Get(int id)
        {
            var dadoSensor = _repository.Get(id);
            if (dadoSensor == null)
            {
                return NotFound();
            }
            return Ok(dadoSensor);
        }


        [HttpPost("/cadastro/dadosensor")]
        public IActionResult Insert([FromBody] DadoSensor dadosSensor)
        {
            _repository.Insert(dadosSensor);
            return Ok(dadosSensor);
        }

        [HttpDelete("/delete/dadosensor")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return Ok();
        }
    }
}
