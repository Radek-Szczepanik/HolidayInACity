namespace HolidayInACity.Domain.Entities;

public class EventOrganizerAddress : EntityBase
{
    public string Street { get; set; } = default!;
    public string StreetNumber { get; set; } = default!;
    public string PostCode { get; set; } = default!;
    public string City { get; set; } = default!;

    public virtual EventOrganizer EventOrganizer { get; set; } = default!;
}
