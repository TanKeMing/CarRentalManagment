using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagment.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Vehicles",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Vehicles",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Models",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Models",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Makes",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Makes",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Customers",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Customers",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Colours",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Colours",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Bookings",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Bookings",
                newName: "DateCreated");

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "Updatedby" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 1, 12, 30, 21, 960, DateTimeKind.Local).AddTicks(4878), new DateTime(2022, 12, 1, 12, 30, 21, 961, DateTimeKind.Local).AddTicks(7379), "Black", "System" },
                    { 2, "System", new DateTime(2022, 12, 1, 12, 30, 21, 961, DateTimeKind.Local).AddTicks(7895), new DateTime(2022, 12, 1, 12, 30, 21, 961, DateTimeKind.Local).AddTicks(7897), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "Updatedby" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 1, 12, 30, 21, 962, DateTimeKind.Local).AddTicks(7583), new DateTime(2022, 12, 1, 12, 30, 21, 962, DateTimeKind.Local).AddTicks(7592), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 12, 1, 12, 30, 21, 962, DateTimeKind.Local).AddTicks(7595), new DateTime(2022, 12, 1, 12, 30, 21, 962, DateTimeKind.Local).AddTicks(7596), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "Updatedby" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 1, 12, 30, 21, 962, DateTimeKind.Local).AddTicks(9991), new DateTime(2022, 12, 1, 12, 30, 21, 962, DateTimeKind.Local).AddTicks(9994), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 12, 1, 12, 30, 21, 962, DateTimeKind.Local).AddTicks(9997), new DateTime(2022, 12, 1, 12, 30, 21, 962, DateTimeKind.Local).AddTicks(9998), "X5", "System" },
                    { 3, "System", new DateTime(2022, 12, 1, 12, 30, 21, 962, DateTimeKind.Local).AddTicks(9999), new DateTime(2022, 12, 1, 12, 30, 21, 963, DateTimeKind.Local), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 12, 1, 12, 30, 21, 963, DateTimeKind.Local).AddTicks(1), new DateTime(2022, 12, 1, 12, 30, 21, 963, DateTimeKind.Local).AddTicks(2), "RAV4", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Vehicles",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Vehicles",
                newName: "DataCreated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Models",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Models",
                newName: "DataCreated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Makes",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Makes",
                newName: "DataCreated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Customers",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Customers",
                newName: "DataCreated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Colours",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Colours",
                newName: "DataCreated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Bookings",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Bookings",
                newName: "DataCreated");
        }
    }
}
