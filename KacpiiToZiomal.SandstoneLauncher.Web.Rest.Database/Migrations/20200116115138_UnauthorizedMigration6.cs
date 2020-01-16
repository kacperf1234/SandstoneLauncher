using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Migrations
{
    public partial class UnauthorizedMigration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime?>(
                table: "developer_tokens",
                name: "unauthorized_at",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
