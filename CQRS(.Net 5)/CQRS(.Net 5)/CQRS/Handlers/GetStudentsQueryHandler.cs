using CQRS_.Net_5_.CQRS.Queries;
using CQRS_.Net_5_.CQRS.Results;
using CQRS_.Net_5_.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CQRS_.Net_5_.CQRS.Handlers
{
    public class GetStudentsQueryHandler
    {
        private readonly StudentContext _context;
        public GetStudentsQueryHandler(StudentContext context)
        {
            _context = context;
        }
        public IEnumerable<GetStudentsQueryResult> Handle(GetStudentsQuery query)
        {
            return _context.Students.Select(x => new GetStudentsQueryResult { Name = x.Name, Surname = x.Surname }).AsNoTracking().AsEnumerable();
        }
    }
}
