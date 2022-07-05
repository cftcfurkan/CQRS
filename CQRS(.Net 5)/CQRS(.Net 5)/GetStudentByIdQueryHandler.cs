using CQRS_.Net_5_.Data;

namespace CQRS_.Net_5_
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
