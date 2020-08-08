using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using psa_server_dotnetcore.Model;
using System.Threading.Tasks;

namespace psa_server_dotnetcore.Controllers
{
    [ApiController]
    [Route("user")]
    public class UsuarioController : ControllerBase
    {
        private readonly UserContext _context;
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger, UserContext context)
        {
            _context = context;
            _logger = logger;
        }

        [Route("")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]UserData user)
        {
            _logger.LogInformation(1002, "POST {user} da request", user);
            _context.users.Add(user);
            await _context.SaveChangesAsync();
            return Ok(200);
        }
    }
}
