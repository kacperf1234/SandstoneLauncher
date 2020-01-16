using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Migrations
{
    public partial class UnauthorizedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "unauthorized_at",
                table: "developer_tokens",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "unauthorized_at",
                table: "developer_tokens");
        }
    }
}
