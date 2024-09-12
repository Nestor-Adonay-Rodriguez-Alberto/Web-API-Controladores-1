using Microsoft.AspNetCore.Mvc;
using Web_API_Controladores_1.Models;


namespace Web_API_Controladores_1.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        // Para Guardar Registros:
        static List<Persona> Lista_Personas = new List<Persona>();



        // GET: api/<PersonaController>
        // Obtiene Todos Los Registros De La Lista:
        [HttpGet]
        public IEnumerable<Persona> Get()
        {
            return Lista_Personas;
        }

        // GET api/<PersonaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PersonaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PersonaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
