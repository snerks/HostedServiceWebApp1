using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HostedServiceWebApp1.Services;
using Microsoft.AspNetCore.Mvc;

namespace HostedServiceWebApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IRandomStringProvider _randomStringProvider;

        public ValuesController(IRandomStringProvider randomStringProvider)
        {
            _randomStringProvider = randomStringProvider;
        }

        [HttpGet]
        public string Get()
        {
            return _randomStringProvider.RandomString;
        }
    }
}

//[Route("api/[controller]")]
//[ApiController]
//public class ValuesController : ControllerBase
//{
//    // GET api/values
//    [HttpGet]
//    public ActionResult<IEnumerable<string>> Get()
//    {
//        return new string[] { "value1", "value2" };
//    }

//    // GET api/values/5
//    [HttpGet("{id}")]
//    public ActionResult<string> Get(int id)
//    {
//        return "value";
//    }

//    // POST api/values
//    [HttpPost]
//    public void Post([FromBody] string value)
//    {
//    }

//    // PUT api/values/5
//    [HttpPut("{id}")]
//    public void Put(int id, [FromBody] string value)
//    {
//    }

//    // DELETE api/values/5
//    [HttpDelete("{id}")]
//    public void Delete(int id)
//    {
//    }
//}

