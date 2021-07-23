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
                    { 2, "Brieuc_Moreau73@gmail.com", "123" },
                    { 3, "Marion_Faure@hotmail.fr", "123" },
                    { 4, "Firmin.Bertrand@yahoo.fr", "123" },
                    { 5, "Aurelle.Brunet5@hotmail.fr", "123" },
                    { 6, "Victoire_Carpentier54@gmail.com", "123" },
                    { 7, "Nathan46@gmail.com", "123" },
                    { 8, "Herve1@hotmail.fr", "123" },
                    { 9, "Anstrudie.Breton@hotmail.fr", "123" },
                    { 10, "Fantin_Pierre51@gmail.com", "123" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
