using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Migrations
{
    public partial class AuthorizedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "authorized",
                table: "developer_tokens",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "authorized_at",
                table: "developer_tokens",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "authorized",
                table: "developer_tokens");

            migrationBuilder.DropColumn(
                name: "authorized_at",
                table: "developer_tokens");
        }
    }
}
