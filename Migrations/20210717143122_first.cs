using Microsoft.EntityFrameworkCore.Migrations;

namespace asp_api.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password" },
                values: new object[,]
                {
                    { 1, "sa@angular.io", "123" },
                    { 2, "Robert.Martin@hotmail.fr", "123" },
                    { 3, "Aquilin.Laurent@gmail.com", "123" },
                    { 4, "Gontran5@yahoo.fr", "123" },
                    { 5, "Agneflete66@hotmail.fr", "123" },
                    { 6, "Jeanne_Barre44@hotmail.fr", "123" },
                    { 7, "Aurore_Simon14@hotmail.fr", "123" },
                    { 8, "Christian67@gmail.com", "123" },
                    { 9, "Athanasie.Colin21@yahoo.fr", "123" },
                    { 10, "Pascal26@hotmail.fr", "123" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
