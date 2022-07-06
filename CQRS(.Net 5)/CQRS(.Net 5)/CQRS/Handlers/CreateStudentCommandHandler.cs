using CQRS_.Net_5_.CQRS.Commands;
using CQRS_.Net_5_.Data;

namespace CQRS_.Net_5_.CQRS.Handlers
{
    public class CreateStudentCommandHandler
    {
        private readonly StudentContext _context;

        public CreateStudentCommandHandler(StudentContext context)
        {
            _context = context;
        }
        public void Handle(CreateStudentCommand command)
        {
            _context.Students.Add(new Student { age = command.Age, Name = command.Name, Surname = command.Surname });
            _context.SaveChanges();
        }
    }
}
