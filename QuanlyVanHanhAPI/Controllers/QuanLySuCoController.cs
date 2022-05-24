using Microsoft.AspNetCore.Mvc;

namespace QuanlyVanHanhAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class QuanLySuCoController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<QuanLySuCoController> _logger;
        
        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        public QuanLySuCoController(ILogger<QuanLySuCoController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetQuanLySuCo")]
        public IEnumerable<QuanLySuCo> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new QuanLySuCo
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}