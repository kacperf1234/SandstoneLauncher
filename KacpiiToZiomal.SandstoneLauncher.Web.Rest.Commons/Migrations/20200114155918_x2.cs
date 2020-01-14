using Microsoft.EntityFrameworkCore.Migrations;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Migrations
{
    public partial class x2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "developer_credentials",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    developer_id = table.Column<string>(nullable: true),
                    client_id = table.Column<string>(nullable: true),
                    client_secret = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_developer_credentials", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "developer_credentials");
        }
    }
}
