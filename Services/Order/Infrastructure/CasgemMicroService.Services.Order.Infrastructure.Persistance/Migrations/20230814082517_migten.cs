using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasgemMicroService.Services.Order.Infrastructure.Persistance.Migrations
{
    public partial class migten : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Addresses");
        }
    }
}
