using EventScheduler.Common.Interfaces;
using EventScheduler.Common.Models;
using EventScheduler.Core;

namespace EventScheduler.Repositorys;

public class RoleRequirementRepository : GenericRepository<RoleRequirement>, IRoleRequirementRepository
{
    private ApplicationDbContext DbContext { get; }

    public RoleRequirementRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        DbContext = dbContext;
    }
}

