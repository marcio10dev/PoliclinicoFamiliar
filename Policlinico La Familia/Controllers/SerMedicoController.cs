using Microsoft.AspNetCore.Mvc;
using Policlinico_La_Familia.Contexto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Policlinico_La_Familia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SerMedicoController : ControllerBase
    {
        private readonly CentroSaludFamiliaContext _context;
        public SerMedicoController(CentroSaludFamiliaContext context)
        {
            _context = context;
        }
        // GET: api/<SerMedicoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SerMedicoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SerMedicoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SerMedicoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SerMedicoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
