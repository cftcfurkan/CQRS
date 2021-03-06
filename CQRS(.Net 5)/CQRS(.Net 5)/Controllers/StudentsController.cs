using CQRS_.Net_5_.CQRS.Commands;
using CQRS_.Net_5_.CQRS.Handlers;
using CQRS_.Net_5_.CQRS.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_.Net_5_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly GetStudentByIdQueryHandler _getStudentByIdQueryHandler;
        private readonly GetStudentsQueryHandler _getStudentsQueryHandler;
        private readonly CreateStudentCommandHandler _createStudentCommandHandler;
        private readonly RemoveStudentCommandHandler _removeStudentCommandHandler;
        public StudentsController(GetStudentByIdQueryHandler getStudentByIdQueryHandler, GetStudentsQueryHandler getStudentsQueryHandler, CreateStudentCommandHandler createStudentCommandHandler, RemoveStudentCommandHandler removeStudentCommandHandler)
        {
            _getStudentByIdQueryHandler = getStudentByIdQueryHandler;
            _getStudentsQueryHandler = getStudentsQueryHandler;
            _createStudentCommandHandler = createStudentCommandHandler;
            _removeStudentCommandHandler = removeStudentCommandHandler;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _getStudentsQueryHandler.Handle(new GetStudentsQuery());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var result = _getStudentByIdQueryHandler.Handle(new GetStudentByIdQuery(id));
            return Ok(result);
        }

        [HttpPost]

        public IActionResult Create(CreateStudentCommand command)
        {
            _createStudentCommandHandler.Handle(command);
            return Created("", command.Name);        // return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            _removeStudentCommandHandler.Handle(new RemoveStudentCommand(id));
            return NoContent();  // return Ok();
        }

    }
}
