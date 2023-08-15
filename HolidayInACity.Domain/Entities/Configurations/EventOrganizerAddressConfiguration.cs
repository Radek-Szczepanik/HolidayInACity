namespace HolidayInACity.Domain.Entities.Configurations;

public class EventOrganizerAddressConfiguration : IEntityTypeConfiguration<EventOrganizerAddress>
{
    public void Configure(EntityTypeBuilder<EventOrganizerAddress> builder)
    {
        builder.Property(x => x.Street)
               .IsRequired()
               .HasMaxLength(20);

        builder.Property(x => x.StreetNumber)
               .IsRequired()
               .HasMaxLength(10);

        builder.Property(x => x.PostCode)
               .IsRequired()
               .HasMaxLength(6);

        builder.Property(x => x.City)
               .IsRequired()
               .HasMaxLength(30);
    }
}
