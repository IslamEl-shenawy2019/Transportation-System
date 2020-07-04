using Microsoft.EntityFrameworkCore.Migrations;

namespace Transportation_System.Migrations
{
    public partial class TestUserTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Promotions_AspNetUsers_PassengerId",
                table: "Promotions");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_AspNetUsers_DriverId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Vehicles_VehicleId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_PassengerId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Schedules_ScheduleId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_PassengerId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_ScheduleId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_DriverId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_VehicleId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Promotions_PassengerId",
                table: "Promotions");

            migrationBuilder.DropColumn(
                name: "PassengerId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ScheduleId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "DriverId",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "PassengerId",
                table: "Promotions");

            migrationBuilder.AlterColumn<string>(
                name: "Passenger_Id",
                table: "Tickets",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Driver_Id",
                table: "Schedules",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Passenger_Id",
                table: "Promotions",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

            migrationBuilder.AlterColumn<string>(
                name: "Passenger_Id",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PassengerId",
                table: "Tickets",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ScheduleId",
                table: "Tickets",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Driver_Id",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DriverId",
                table: "Schedules",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                table: "Schedules",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Passenger_Id",
                table: "Promotions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PassengerId",
                table: "Promotions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_PassengerId",
                table: "Tickets",
                column: "PassengerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ScheduleId",
                table: "Tickets",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_DriverId",
                table: "Schedules",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_VehicleId",
                table: "Schedules",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Promotions_PassengerId",
                table: "Promotions",
                column: "PassengerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Promotions_AspNetUsers_PassengerId",
                table: "Promotions",
                column: "PassengerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_AspNetUsers_DriverId",
                table: "Schedules",
                column: "DriverId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Vehicles_VehicleId",
                table: "Schedules",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AspNetUsers_PassengerId",
                table: "Tickets",
                column: "PassengerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Schedules_ScheduleId",
                table: "Tickets",
                column: "ScheduleId",
                principalTable: "Schedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
