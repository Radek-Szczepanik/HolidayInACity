namespace HolidayInACity.Domain.Entities;

public class HolidayEvent : EntityBase
{
    public string Name { get; set; } = default!;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Description { get; set; } = default!;
    public decimal Price { get; set; }

    public int EventOrganizerId { get; set; }
    public virtual EventOrganizer EventOrganizer { get; set; } = default!;
}
