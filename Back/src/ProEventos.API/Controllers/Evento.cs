using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class EventoController : ControllerBase
    {        
        public EventoController(ILogger<EventoController> logger)
        {
            
        }

        [HttpGet]
        public string Get()
        {            
            return "Olá Mundo!";           
        }

        [HttpPost]
        public string Post(){
            return "Estamos no metodo Post";
        }

        [HttpDelete("{id}")]
        public string Delete(int id){
            return $"Agora Delete com o id={id}";
        }
    }
}
