using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using psa_server_dotnetcore.Repository;

namespace psa_server_dotnetcore.Controllers
{
    [ApiController]
    [Route("educacional")]
    public class EducacionalController : ControllerBase
    {
        private readonly EducacionalRepository _repository;

        private readonly ILogger<EducacionalController> _logger;

        public EducacionalController(ILogger<EducacionalController> logger, EducacionalRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }
        [Route("")]
        [HttpGet]
        public Educacional Get()
        {
            return _repository.Get();
        }
    }
}
