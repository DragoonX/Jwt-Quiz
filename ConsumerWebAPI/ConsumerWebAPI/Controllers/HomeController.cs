using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsumerWebAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ConsumerWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        readonly IRepository _repository;

        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("getall")]
        public ActionResult<IEnumerable<string>> Get()
        {
            var x = _repository.List();
            return new JsonResult(x);
        }

        [HttpGet]
        [Route("save/{data}")]
        public ActionResult<IEnumerable<string>> Save(string data)
        {
            return new JsonResult(data);
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
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
