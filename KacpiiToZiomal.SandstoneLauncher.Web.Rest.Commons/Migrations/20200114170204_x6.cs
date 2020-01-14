using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Migrations
{
    public partial class x6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "developer_tokens",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    developer_id = table.Column<string>(nullable: true),
                    generated_at = table.Column<DateTime>(nullable: true),
                    expired_at = table.Column<DateTime>(nullable: true),
                    archived = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_developer_tokens", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "developer_tokens");
        }
    }
}
