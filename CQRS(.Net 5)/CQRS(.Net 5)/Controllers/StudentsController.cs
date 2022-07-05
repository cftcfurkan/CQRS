using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_.Net_5_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly GetStudentByIdQueryHandler _getStudentByIdQueryHandler;
        public StudentsController(GetStudentByIdQueryHandler getStudentByIdQueryHandler)
        {
            _getStudentByIdQueryHandler = getStudentByIdQueryHandler;
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var result = _getStudentByIdQueryHandler.Handle(new GetStudentByIdQuery(id));
            return Ok(result);
        }
    }
}
