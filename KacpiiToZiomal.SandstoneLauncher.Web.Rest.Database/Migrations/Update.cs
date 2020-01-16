using Microsoft.EntityFrameworkCore.Migrations;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Migrations
{
    [Migration("update-migrate")]
    public class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(name: "unauthorized", 
                table: "developer_tokens",
                type: "INTEGER",
                defaultValue: null);
        }
    }
}