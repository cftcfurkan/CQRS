namespace CQRS_.Net_5_.CQRS.Commands
{
    public class RemoveStudentCommand
    {
        public int Id { get; set; }

        public RemoveStudentCommand(int id)
        {
            Id = id;
        }
    }
}
