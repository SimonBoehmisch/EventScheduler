namespace EventScheduler.Common.Models;

public class RoleRequirement : BaseEntity
{
    public Event Event { get; set; }
    public Role Role { get; set; }

    public int RequiredEmployees { get; set; }

}