using CQRS_.Net_5_.CQRS.Queries;
using CQRS_.Net_5_.CQRS.Results;
using CQRS_.Net_5_.Data;

namespace CQRS_.Net_5_.CQRS.Handlers
{
    public class GetStudentByIdQueryHandler
    {
        private readonly StudentContext _context;
        public GetStudentByIdQueryHandler(StudentContext context)
        {
            _context = context;
        }
        public GetStudentByIdQueryResult Handle(GetStudentByIdQuery query)
        {
            var student = _context.Set<Student>().Find(query.Id);
            return new GetStudentByIdQueryResult
            {
                age = student.age,
                Name = student.Name,
                Surname = student.Surname
            };

        }
    }
}
