using Microsoft.AspNetCore.Mvc;
using YearbookBoard.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YearbookBoard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelephoneBoardController : ControllerBase
    {

        private static List<TelephoneBoard> yearbookBoards = new List<TelephoneBoard> { 
            new TelephoneBoard {Name="" ,FamilyN = "", NumClass = 0, TelephoneNumber = "", AdditionalTelephone = ""} };

        // GET: api/<TelephoneBoardController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TelephoneBoardController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TelephoneBoardController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TelephoneBoardController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TelephoneBoardController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
