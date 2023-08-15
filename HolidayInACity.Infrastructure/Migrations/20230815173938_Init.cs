#nullable disable

namespace HolidayInACity.Infrastructure.Migrations;

/// <inheritdoc />
public partial class Init : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "EventOrganizers",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                EventOrganizerAddressId = table.Column<int>(type: "int", nullable: false),
                EventOrganizerContactId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_EventOrganizers", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "EventOrganizerAddresses",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false),
                Street = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                StreetNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                PostCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                City = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_EventOrganizerAddresses", x => x.Id);
                table.ForeignKey(
                    name: "FK_EventOrganizerAddresses_EventOrganizers_Id",
                    column: x => x.Id,
                    principalTable: "EventOrganizers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "EventOrganizerContacts",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false),
                PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_EventOrganizerContacts", x => x.Id);
                table.ForeignKey(
                    name: "FK_EventOrganizerContacts_EventOrganizers_Id",
                    column: x => x.Id,
                    principalTable: "EventOrganizers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "HolidayEvents",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                Price = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: false),
                EventOrganizerId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_HolidayEvents", x => x.Id);
                table.ForeignKey(
                    name: "FK_HolidayEvents_EventOrganizers_EventOrganizerId",
                    column: x => x.EventOrganizerId,
                    principalTable: "EventOrganizers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "IX_HolidayEvents_EventOrganizerId",
            table: "HolidayEvents",
            column: "EventOrganizerId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "EventOrganizerAddresses");

        migrationBuilder.DropTable(
            name: "EventOrganizerContacts");

        migrationBuilder.DropTable(
            name: "HolidayEvents");

        migrationBuilder.DropTable(
            name: "EventOrganizers");
    }
}
