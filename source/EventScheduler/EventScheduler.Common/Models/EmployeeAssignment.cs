namespace EventScheduler.Common.Models;

public partial class EmployeeAssignment : BaseEntity
{
    public Employee Employee { get; set; }
    public Event Event { get; set; }
    public bool IsAssigned { get; set; }
}
