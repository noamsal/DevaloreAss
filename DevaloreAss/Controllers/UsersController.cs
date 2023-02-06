using Microsoft.AspNetCore.Mvc;
using DevaloreAss.Controllers;
using DevaloreAss.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DevaloreAss.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        Db db = new Db();
        // ApiHelper.InitalizeClient();


        


        public async Task<IActionResult> Index()
        {
            
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://randomuser.me/api/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservationList = JsonConvert.DeserializeObject<List<Reservation>>(apiResponse);
                }
            }
            return View(reservationList);
        } */

        // GET: api/Users
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/Users/5
        [HttpGet("{id}")]
        public int Get(int id)
        {
            return id;
        }

        // GET api/Users/5
        [HttpGet("{gender}")]
        public string Get(string gender)
        {
            return "value";
        }


        
        // POST api/Users
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Users>5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        
    }

}
