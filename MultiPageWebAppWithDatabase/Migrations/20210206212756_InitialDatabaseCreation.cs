using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactList.Migrations
{
    public partial class InitialDatabaseCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    NoteId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.NoteId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 12, nullable: false),
                    AddressLine1 = table.Column<string>(maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(maxLength: 100, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    State = table.Column<string>(maxLength: 25, nullable: false),
                    ZipCode = table.Column<string>(maxLength: 10, nullable: false),
                    NoteId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                    table.ForeignKey(
                        name: "FK_Contacts_Notes_NoteId",
                        column: x => x.NoteId,
                        principalTable: "Notes",
                        principalColumn: "NoteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "NoteId", "Name" },
                values: new object[,]
                {
                    { "F", "Met through a friend." },
                    { "H", "Met while hiking." },
                    { "M", "Met while making jewelry." },
                    { "R", "Met at a restaurant." },
                    { "W", "Met at work." }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "AddressLine1", "AddressLine2", "City", "Name", "NoteId", "PhoneNumber", "State", "ZipCode" },
                values: new object[,]
                {
                    { 1, "123 Main Street", "Apt #2B", "Ankeny", "John Denver", "F", "888-555-1212", "Iowa", "50021-0000" },
                    { 4, "1500 West Lincoln Street", "", "Ankeny", "Burt Reynolds", "M", "888-555-6666", "Iowa", "50021-0000" },
                    { 2, "456 First Street", " ", "Ankeny", "Jason Priestly", "R", "888-555-4444", "Iowa", "50021-0456" },
                    { 3, "789 Elm Road", "Unit 5A", "Ankeny", "Sally Fields", "W", "888-555-5555", "Iowa", "50023-0000" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_NoteId",
                table: "Contacts",
                column: "NoteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Notes");
        }
    }
}
