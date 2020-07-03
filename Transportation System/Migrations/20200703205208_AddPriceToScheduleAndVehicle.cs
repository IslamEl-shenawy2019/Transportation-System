using Microsoft.EntityFrameworkCore.Migrations;

namespace Transportation_System.Migrations
{
    public partial class AddPriceToScheduleAndVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "Vehicles",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "FinalPrice",
                table: "Schedules",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "InitialPrice",
                table: "Schedules",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "FinalPrice",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "InitialPrice",
                table: "Schedules");
        }
    }
}
