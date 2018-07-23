using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gossip.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Nodes")]
    public class NodesController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "Hello world";
        }

    }
}