using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Transportation_System.Migrations
{
    public partial class FinishDomainClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.AddColumn<int>(
                name: "NumOfSeats",
                table: "Vehicles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "VehicleName",
                table: "Vehicles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehicleType",
                table: "Vehicles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "BookingDate",
                table: "Tickets",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Passenger_Id",
                table: "Tickets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Schedule_Id",
                table: "Tickets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Driver_Id",
                table: "Schedules",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Route",
                table: "Schedules",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Vehicle_Id",
                table: "Schedules",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Details",
                table: "Promotions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Promotions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Passenger_Id",
                table: "Promotions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TransportationType",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DriverVehicle",
                columns: table => new
                {
                    Driver_Id = table.Column<string>(nullable: false),
                    Vehicle_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverVehicle", x => new { x.Vehicle_Id, x.Driver_Id });
                    table.ForeignKey(
                        name: "FK_DriverVehicle_AspNetUsers_Driver_Id",
                        column: x => x.Driver_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DriverVehicle_Vehicles_Vehicle_Id",
                        column: x => x.Vehicle_Id,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_Passenger_Id",
                table: "Tickets",
                column: "Passenger_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_Schedule_Id",
                table: "Tickets",
                column: "Schedule_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_Driver_Id",
                table: "Schedules",
                column: "Driver_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_Vehicle_Id",
                table: "Schedules",
                column: "Vehicle_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Promotions_Passenger_Id",
                table: "Promotions",
                column: "Passenger_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DriverVehicle_Driver_Id",
                table: "DriverVehicle",
                column: "Driver_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Promotions_AspNetUsers_Passenger_Id",
                table: "Promotions",
                column: "Passenger_Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_AspNetUsers_Driver_Id",
                table: "Schedules",
                column: "Driver_Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Vehicles_Vehicle_Id",
                table: "Schedules",
                column: "Vehicle_Id",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AspNetUsers_Passenger_Id",
                table: "Tickets",
                column: "Passenger_Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Schedules_Schedule_Id",
                table: "Tickets",
                column: "Schedule_Id",
                principalTable: "Schedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Promotions_AspNetUsers_Passenger_Id",
                table: "Promotions");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_AspNetUsers_Driver_Id",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Vehicles_Vehicle_Id",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_Passenger_Id",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Schedules_Schedule_Id",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "DriverVehicle");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_Passenger_Id",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_Schedule_Id",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_Driver_Id",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_Vehicle_Id",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Promotions_Passenger_Id",
                table: "Promotions");

            migrationBuilder.DropColumn(
                name: "NumOfSeats",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "VehicleName",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "VehicleType",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "BookingDate",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Passenger_Id",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Schedule_Id",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Driver_Id",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "Route",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "Vehicle_Id",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "Promotions");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Promotions");

            migrationBuilder.DropColumn(
                name: "Passenger_Id",
                table: "Promotions");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TransportationType",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.Id);
                });
        }
    }
}
