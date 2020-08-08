using Microsoft.AspNetCore.Mvc;
using psa_server_dotnetcore.Repository;

namespace psa_server_dotnetcore.Controllers
{
    [ApiController]
    [Route("quiz")]
    public class QuizController : ControllerBase
    {

        private readonly QuizRepository _repository;

        public QuizController(QuizRepository repository)
        {
            _repository = repository;
        }

        [Route("")]
        [HttpGet]
        public Quiz Get()
        {
            return _repository.Get();
        }

    }
}
