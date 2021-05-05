using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Catalog.Api.Controllers
{
    [ApiController]
    [Route("/")]
    public class DafaultController : ControllerBase
    {
       
        private readonly ILogger<DafaultController> _logger;

        public DafaultController(ILogger<DafaultController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Running  ....";
        }
    }
}
