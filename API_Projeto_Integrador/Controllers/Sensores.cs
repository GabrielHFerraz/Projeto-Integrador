using API_Projeto_Integrador.Models;
using API_Projeto_Integrador.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Projeto_Integrador.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Sensores : ControllerBase
    {
        private ISensorRepository _repository;

        public Sensores()
        {
            _repository = new SensorRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.Get());
        }

        [HttpGet("/sensor/{id}")]
        public IActionResult Get(int id)
        {
            var sensor = _repository.Get(id);
            if (sensor == null)
            {
                return NotFound();
            }
            return Ok(sensor);
        }

        [HttpPost("/cadastro/sensor")]
        public IActionResult Insert([FromBody] Sensor sensor)
        {
            _repository.Insert(sensor);
            return Ok(sensor);
        }

        [HttpDelete("/delete/sensor")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return Ok();
        }

    }
}
