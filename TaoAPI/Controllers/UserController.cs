using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaoAPI.Models;

namespace TaoAPI.Controllers
{
    [Route("TaoApi/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        List<User> users = new List<User>();

        public UserController()
        {
            // Ajout des utilisateurs bidons
            User levent = new User(1, "Bayrakli", "Levent", DateTime.Today, "42 Avenue du président John Kennedy 45100 Orléans La Source", "leventgb@gmail.com", "0649560508");
            User arthur = new User(2, "Dessus", "Arthur", DateTime.Today, "16 Rue des Grands Champs 45000 Orléans", "dessus.perso@gmail.com", "0633897506");
            User quentin = new User(3, "DuKentucky", "KentiKent", DateTime.Today, "69 rue du Kentucky 45000 Orléans", "kentikentkentucky@gmail.com", "0649237300");
            User vincent = new User(4, "Oczachowski", "Vincent", DateTime.Today, "5 rue de la Touche", "vincent.oczachowski@gmail.com", "0674927233");
            User waifu = new User(4, "Hime", "Emilia", DateTime.Today, "5 rue de la Touche", "emilia.hime@gmail.com", "0612345678");
            
            users.Add(levent);
            users.Add(arthur);
            users.Add(quentin);
            users.Add(vincent);
            users.Add(waifu);
        }

        // GET api/user
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return users;
        }

        // GET api/user/5
        [HttpGet("{id}")]
        public IEnumerable<User> Get(int id)
        {
            return users.Where(u => u.Id == id);
        }





        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
