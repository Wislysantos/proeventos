using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

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
        public List<Evento> Get()
        {            
            return new List<Evento> (){
            
            new Evento(){
               EventoId= 1,
               Local = "Rincao",
               Tema = "Encontro olhos de Aguia",
               QtdPessoa =20,
               DataEvento= DateTime.Now.AddDays(2).ToString(),
               Lote = "Primeiro lote",
            },
            new Evento(){
               EventoId= 2,
               Local = "Rincao",
               Tema = "Encontro dos motoCar",
               QtdPessoa =150,
               DataEvento= DateTime.Now.AddDays(2).ToString(),
               Lote = "Primeiro lote",
            }
            };
        }

        private List<T> List<T>()
        {
            throw new NotImplementedException();
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
