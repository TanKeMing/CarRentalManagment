using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagment.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "1ad6cdad-571c-481b-90e7-bfc5b537acee", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "c279ee2a-29f1-4433-8c74-4c23762ebeef", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "95375ca2-48db-4253-96bd-ae0a360d54c9", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEIAIJUagb7ru8P6l+04zi7i4O7Oui6amVnaogWYz/NL+AsU3zyant6iQduPXko2cXw==", null, false, "1f43b63e-641b-476f-968c-0336289fae20", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 1, 12, 52, 18, 50, DateTimeKind.Local).AddTicks(2638), new DateTime(2022, 12, 1, 12, 52, 18, 51, DateTimeKind.Local).AddTicks(4862) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 1, 12, 52, 18, 51, DateTimeKind.Local).AddTicks(5936), new DateTime(2022, 12, 1, 12, 52, 18, 51, DateTimeKind.Local).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 1, 12, 52, 18, 53, DateTimeKind.Local).AddTicks(1890), new DateTime(2022, 12, 1, 12, 52, 18, 53, DateTimeKind.Local).AddTicks(1906) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 1, 12, 52, 18, 53, DateTimeKind.Local).AddTicks(1911), new DateTime(2022, 12, 1, 12, 52, 18, 53, DateTimeKind.Local).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 1, 12, 52, 18, 53, DateTimeKind.Local).AddTicks(5607), new DateTime(2022, 12, 1, 12, 52, 18, 53, DateTimeKind.Local).AddTicks(5614) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 1, 12, 52, 18, 53, DateTimeKind.Local).AddTicks(5620), new DateTime(2022, 12, 1, 12, 52, 18, 53, DateTimeKind.Local).AddTicks(5622) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 1, 12, 52, 18, 53, DateTimeKind.Local).AddTicks(5624), new DateTime(2022, 12, 1, 12, 52, 18, 53, DateTimeKind.Local).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 1, 12, 52, 18, 53, DateTimeKind.Local).AddTicks(5628), new DateTime(2022, 12, 1, 12, 52, 18, 53, DateTimeKind.Local).AddTicks(5629) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 1, 12, 30, 21, 960, DateTimeKind.Local).AddTicks(4878), new DateTime(2022, 12, 1, 12, 30, 21, 961, DateTimeKind.Local).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 1, 12, 30, 21, 961, DateTimeKind.Local).AddTicks(7895), new DateTime(2022, 12, 1, 12, 30, 21, 961, DateTimeKind.Local).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 1, 12, 30, 21, 962, DateTimeKind.Local).AddTicks(7583), new DateTime(2022, 12, 1, 12, 30, 21, 962, DateTimeKind.Local).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 1, 12, 30, 21, 962, DateTimeKind.Local).AddTicks(7595), new DateTime(2022, 12, 1, 12, 30, 21, 962, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 1, 12, 30, 21, 962, DateTimeKind.Local).AddTicks(9991), new DateTime(2022, 12, 1, 12, 30, 21, 962, DateTimeKind.Local).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 1, 12, 30, 21, 962, DateTimeKind.Local).AddTicks(9997), new DateTime(2022, 12, 1, 12, 30, 21, 962, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 1, 12, 30, 21, 962, DateTimeKind.Local).AddTicks(9999), new DateTime(2022, 12, 1, 12, 30, 21, 963, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 1, 12, 30, 21, 963, DateTimeKind.Local).AddTicks(1), new DateTime(2022, 12, 1, 12, 30, 21, 963, DateTimeKind.Local).AddTicks(2) });
        }
    }
}
