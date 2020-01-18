using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Migrations
{
    public partial class rest_requests2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "rest_requests",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    token_id = table.Column<string>(nullable: true),
                    developer_id = table.Column<string>(nullable: true),
                    return_url = table.Column<string>(nullable: true),
                    cancel_url = table.Column<string>(nullable: true),
                    generated_at = table.Column<DateTime>(nullable: true),
                    invoked = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rest_requests", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "rest_requests");
        }
    }
}
