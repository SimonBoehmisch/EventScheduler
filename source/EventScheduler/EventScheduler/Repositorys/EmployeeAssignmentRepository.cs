using EventScheduler.Common.Interfaces;
using EventScheduler.Common.Models;
using EventScheduler.Core;

namespace EventScheduler.Repositorys
{
    public class EmployeeAssignmentRepository : GenericRepository<EmployeeAssignment>, IEmployeeAssignmentRepository
    {
        private ApplicationDbContext DbContext { get; }

        public EmployeeAssignmentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            DbContext = dbContext;
        }

    }
}
