using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Migrations
{
    public partial class helloworld : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "last_updated_at",
                table: "developer_tokens",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "updated_times",
                table: "developer_tokens",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "last_updated_at",
                table: "developer_tokens");

            migrationBuilder.DropColumn(
                name: "updated_times",
                table: "developer_tokens");
        }
    }
}
