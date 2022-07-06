namespace CQRS_.Net_5_.CQRS.Queries
{
    public class GetStudentByIdQuery
    {
        public int Id { get; set; }

        public GetStudentByIdQuery(int id)
        {
            Id = id;
        }
    }
}
