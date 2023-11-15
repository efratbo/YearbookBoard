using Microsoft.AspNetCore.Mvc;
using YearbookBoard.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YearbookBoard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {

        private static List<Events> _events = new List<Events> { 
            new Events { Day = "", Date = new(),Name = "",NumClass = 0,EventType = "",EventLocation = "",Note = ""} };

        // GET: api/<EventsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return _events;
        }

        // GET api/<EventsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var events = _events.Find(e => e.NumClass == id);
            if (events == null)
                return NotFound();
            return events;
        }

        // POST api/<EventsController>
        [HttpPost]
        public void Post([FromBody] Events e)
        {
            _events.Add(new Events
            {
                Day = e.Day,
                Date = e.Date,
                Name = e.Name,
                NumClass++,
                EventType = e.EventType,
                EventLocation = e.EventLocation,
                Note = e.Note


            });
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public ActionResul Put(int id, [FromBody] Events e)
        {
            var events = _events.Find(e => e.NumClass == id);
            if (events == null)
                return NotFound();
            Day = e.Day,
                Date = e.Date,
                Name = e.Name,
                EventType = e.EventType,
                EventLocation = e.EventLocation,
                Note = e.Note
            return Ok(events);
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var events = _events.Find(e => e.NumClass == id);
            if (events == null)
                return NotFound();
            _events.Remove(events);
            return Ok();
        }
    }
}
