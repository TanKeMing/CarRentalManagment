using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagment.Server.Migrations
{
    public partial class newdb_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "8e737d2d-12b6-4d83-862b-d9c98897a8f3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "1f8d3563-d123-4988-a271-bc030927a991");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a044d11-4922-4edd-8e1f-0e1d05f4910a", "AQAAAAEAACcQAAAAELv5AVU6EhV9ZfRRaaeW6c/zZdiirBmcW8YcKfp98NZzauLjAIo0GI0LbUdZlg1Spw==", "d5c06adc-905c-4e2f-ba3f-13918b5b40fc" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 19, 11, 46, 40, 408, DateTimeKind.Local).AddTicks(5876), new DateTime(2023, 1, 19, 11, 46, 40, 409, DateTimeKind.Local).AddTicks(6966) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 19, 11, 46, 40, 409, DateTimeKind.Local).AddTicks(7774), new DateTime(2023, 1, 19, 11, 46, 40, 409, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 19, 11, 46, 40, 411, DateTimeKind.Local).AddTicks(3182), new DateTime(2023, 1, 19, 11, 46, 40, 411, DateTimeKind.Local).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 19, 11, 46, 40, 411, DateTimeKind.Local).AddTicks(3202), new DateTime(2023, 1, 19, 11, 46, 40, 411, DateTimeKind.Local).AddTicks(3204) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 19, 11, 46, 40, 411, DateTimeKind.Local).AddTicks(6929), new DateTime(2023, 1, 19, 11, 46, 40, 411, DateTimeKind.Local).AddTicks(6936) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 19, 11, 46, 40, 411, DateTimeKind.Local).AddTicks(6941), new DateTime(2023, 1, 19, 11, 46, 40, 411, DateTimeKind.Local).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 19, 11, 46, 40, 411, DateTimeKind.Local).AddTicks(6945), new DateTime(2023, 1, 19, 11, 46, 40, 411, DateTimeKind.Local).AddTicks(6947) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 19, 11, 46, 40, 411, DateTimeKind.Local).AddTicks(6948), new DateTime(2023, 1, 19, 11, 46, 40, 411, DateTimeKind.Local).AddTicks(6950) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "dac82160-f2d3-457b-ba67-bf09d51b9375");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "372d2d81-3e42-443f-8c15-95916ed8bc50");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "265685d8-1077-459f-981e-279ddab036fa", "AQAAAAEAACcQAAAAEDWpD9h7yZD4vcSHBVMlb812CeMDIdBJTYul6ofeXbvl+Vq+VX0UNujZTENbS6bCmQ==", "07eaf12b-7922-47e6-98d3-0cfff40a6541" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 19, 11, 1, 12, 221, DateTimeKind.Local).AddTicks(5040), new DateTime(2023, 1, 19, 11, 1, 12, 223, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 19, 11, 1, 12, 223, DateTimeKind.Local).AddTicks(806), new DateTime(2023, 1, 19, 11, 1, 12, 223, DateTimeKind.Local).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 19, 11, 1, 12, 224, DateTimeKind.Local).AddTicks(4266), new DateTime(2023, 1, 19, 11, 1, 12, 224, DateTimeKind.Local).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 19, 11, 1, 12, 224, DateTimeKind.Local).AddTicks(4282), new DateTime(2023, 1, 19, 11, 1, 12, 224, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 19, 11, 1, 12, 225, DateTimeKind.Local).AddTicks(3238), new DateTime(2023, 1, 19, 11, 1, 12, 225, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 19, 11, 1, 12, 225, DateTimeKind.Local).AddTicks(3254), new DateTime(2023, 1, 19, 11, 1, 12, 225, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 19, 11, 1, 12, 225, DateTimeKind.Local).AddTicks(3257), new DateTime(2023, 1, 19, 11, 1, 12, 225, DateTimeKind.Local).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 19, 11, 1, 12, 225, DateTimeKind.Local).AddTicks(3261), new DateTime(2023, 1, 19, 11, 1, 12, 225, DateTimeKind.Local).AddTicks(3262) });
        }
    }
}
