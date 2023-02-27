using EventScheduler.Common.Interfaces;
using EventScheduler.Common.Models;
using EventScheduler.Core;

namespace EventScheduler.Repositorys;

public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
{
    private ApplicationDbContext DbContext { get; }

    public EmployeeRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        DbContext = dbContext;
    }


}
