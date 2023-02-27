using EventScheduler.Common.Interfaces;
using EventScheduler.Common.Models;
using EventScheduler.Core;

namespace EventScheduler.Repositorys;

public class EventRepository : GenericRepository<Event>, IEventRepository
{
    private ApplicationDbContext DbContext { get; }

    public EventRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        DbContext = dbContext;
    }
}
