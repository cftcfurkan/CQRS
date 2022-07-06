using CQRS_.Net_5_.CQRS.Commands;
using CQRS_.Net_5_.Data;

namespace CQRS_.Net_5_.CQRS.Handlers
{
    public class RemoveStudentCommandHandler
    {
        private readonly StudentContext _context;

        public RemoveStudentCommandHandler(StudentContext context)
        {
            _context = context;
        }

        public void Handle(RemoveStudentCommand command)
        {
            var deletedEntity = _context.Students.Find(command.Id);
            _context.Students.Remove(deletedEntity);
            _context.SaveChanges();
        }
    }
}
