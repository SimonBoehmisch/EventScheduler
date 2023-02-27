using EventScheduler.Common.Interfaces;
using EventScheduler.Common.Models;
using EventScheduler.Core;

namespace EventScheduler.Repositorys;

public class RoleRepository : GenericRepository<Role>, IRoleRepository
{
    private ApplicationDbContext DbContext { get; }

    public RoleRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        DbContext = dbContext;
    }
}

