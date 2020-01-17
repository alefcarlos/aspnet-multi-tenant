using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MultiTenant.WebApi.Data;

namespace MultiTenant.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemoController : ControllerBase
    {
        private readonly ILogger<DemoController> _logger;

        public DemoController(ILogger<DemoController> logger, Repository repository)
        {
            _logger = logger;
            this.repository = repository;
        }

        private readonly Repository repository;

        [HttpGet]
        public IActionResult Get([FromQuery]string tenant)
        {
            //Adicionar tenant no context http para ser acessado via IHttpContextAccessor
            HttpContext.Items.Add("tenant", tenant);

            repository.Add();

            return NoContent();
        }
    }
}
