namespace HolidayInACity.Domain.Entities;

public class EventOrganizer : EntityBase
{
    public string Name { get; set; } = default!;

    public int EventOrganizerAddressId { get; set; }
    public virtual EventOrganizerAddress EventOrganizerAddress { get; set; } = default!;
    public int EventOrganizerContactId { get; set; }
    public virtual EventOrganizerContact EventOrganizerContact { get; set; } = default!;
    public virtual ICollection<HolidayEvent> HolidayEvents { get; } = new List<HolidayEvent>();
}
