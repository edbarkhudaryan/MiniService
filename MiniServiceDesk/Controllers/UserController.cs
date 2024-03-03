using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniServiceDesk.Data;
using MiniServiceDesk.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MiniServiceDesk.Controllers
{

    [Route("api/[controller]/[action]")]
    //[Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;

        public UserController(ApplicationDbContext db)
        {
            this._db = db;
        }

        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

      
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var obj = _db.Users.First();
            return Ok(obj);
            //var obj = _db.Users.Find(id);
            //return Ok(obj);
        }

        [HttpPost]
        public IActionResult Add([FromBody]Users user)
        {
            if (ModelState.IsValid)
            {
                _db.Users.Add(user);
                _db.SaveChanges();
                return Ok(user);
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id==0)
                return NotFound();

            else
            {
                var users = _db.Users.Find(id);
                return users==null?  NotFound(): Ok(users);
            }
           
        }
    }
}

