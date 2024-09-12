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
        // OBTIENE TODOS LOS REGISTROS DE LA LISTA:
        [HttpGet]
        public IEnumerable<Persona> Get()
        {
            return Lista_Personas;
        }



        // GET api/<PersonaController>/5
        // OBTIENE UN REGISTRO CON ESE MISMO ID: 
        [HttpGet("{id}")]
        public Persona Get(int id)
        {
            Persona Objetod_Obtenido = Lista_Personas.FirstOrDefault(x => x.IdPersona == id);

            return Objetod_Obtenido;
        }



        // POST api/<PersonaController>
        // GUARDA EL OBJETO DEL PARAMETRO EN LA LISTA:
        [HttpPost]
        public IActionResult Post([FromBody] Persona persona)
        {
            Lista_Personas.Add(persona);

            return Ok("Guardado Exitosamente.");
        }



        // PUT api/<PersonaController>/5
        // OBTIENE UN REGISTRO CON ESE MISMO ID Y LO MODIFICA CON LOS DATOS DEL PARAMETRO:
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Persona persona)
        {

            Persona? Objetod_Obtenido = Lista_Personas.FirstOrDefault(x => x.IdPersona == id);

            if(Objetod_Obtenido!=null)
            {
                Objetod_Obtenido.Nombre = persona.Nombre;
                Objetod_Obtenido.Edad = persona.Edad;
                Objetod_Obtenido.Residencia = persona.Residencia;
                Objetod_Obtenido.Telefono = persona.Telefono;

                return Ok("Modificado Exitosamente.");
            }
            else
            {
                return NotFound("No se encontro un registro con ese ID:");
            }

        }



        // DELETE api/<PersonaController>/5
        // OBTIENE UN REGISTRO CON ESE MISMO ID Y LO ELIMINA:
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            Persona? Objetod_Obtenido = Lista_Personas.FirstOrDefault(x => x.IdPersona == id);

            if (Objetod_Obtenido != null)
            {
                Lista_Personas.Remove(Objetod_Obtenido);

                return Ok("Eliminado Exitosamente.");
            }
            else
            {
                return NotFound("No se encontro un registro con ese ID:");
            }

        }


    }
}
