using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Migrations
{
    public partial class users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    developer_id = table.Column<string>(nullable: true),
                    registration_id = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    email_confirmed = table.Column<bool>(nullable: false),
                    email_confirmed_at = table.Column<DateTime>(nullable: true),
                    phonenumber = table.Column<string>(nullable: true),
                    phonenumber_confirmed = table.Column<bool>(nullable: false),
                    phonenumber_confirmed_at = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users_token",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    user_id = table.Column<string>(nullable: true),
                    developer_id = table.Column<string>(nullable: true),
                    access_token = table.Column<string>(nullable: true),
                    generated_at = table.Column<DateTime>(nullable: true),
                    expired_at = table.Column<DateTime>(nullable: true),
                    authorized = table.Column<bool>(nullable: false),
                    unauthorized_at = table.Column<DateTime>(nullable: true),
                    unauthorized = table.Column<bool>(nullable: false),
                    archived = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users_token", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "users_token");
        }
    }
}
