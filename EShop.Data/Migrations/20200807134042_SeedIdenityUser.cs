using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EShop.Data.Migrations
{
    public partial class SeedIdenityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("ba29e407-47a9-48c2-98ae-942c7fcef6a1"), "f6afc84f-f918-4cf8-8d43-1a9ceee549c8", "Adminsistrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("ba29e407-47a9-48c2-98ae-942c7fcef6a1"), new Guid("ba29e407-47a9-48c2-98ae-942c7fcef6a1") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("ba29e407-47a9-48c2-98ae-942c7fcef6a1"), 0, "3aed2171-0074-4b64-af80-b88678ad9860", new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "khoa.dinh@pap-tech.com", true, "Khoa", "Dinh", false, null, "khoa.dinh@pap-tech.com", "admin", "AQAAAAEAACcQAAAAEPJUH/1JAgwrpBSx9IEnx6Bii1tTHf94W7jDpcJeXeWwsYZQjXAJgFmqiv+t54fiwg==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 8, 7, 20, 40, 41, 332, DateTimeKind.Local).AddTicks(275));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ba29e407-47a9-48c2-98ae-942c7fcef6a1"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("ba29e407-47a9-48c2-98ae-942c7fcef6a1"), new Guid("ba29e407-47a9-48c2-98ae-942c7fcef6a1") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ba29e407-47a9-48c2-98ae-942c7fcef6a1"));

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 8, 7, 20, 3, 39, 769, DateTimeKind.Local).AddTicks(7995));
        }
    }
}
