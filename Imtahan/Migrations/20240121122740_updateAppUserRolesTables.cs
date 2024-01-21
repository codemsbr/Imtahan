using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Imtahan.Migrations
{
    public partial class updateAppUserRolesTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b5b3163-56f2-4e2f-aa04-902b26206c30");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "719e6e5b-60bf-46c5-8297-95c18bfc11cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2a89df9-a4d6-431a-9286-e50d5eee290e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a680cb63-2b56-4797-bc68-c60fba83f752", "f064a327-49fc-4dd9-b213-7e12a66e701f", "Member", "Member" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c2b0c0c8-97a3-49f8-b006-704877b6b774", "b92328ae-e7fe-4126-a4a3-bb735bf64a32", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "df9aea13-7df4-4538-a8aa-85d40170c4c9", "5a12851c-3417-40e6-8177-a9f864b1ee31", "SuperAdmin", "SuperAdmin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a680cb63-2b56-4797-bc68-c60fba83f752");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2b0c0c8-97a3-49f8-b006-704877b6b774");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df9aea13-7df4-4538-a8aa-85d40170c4c9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2b5b3163-56f2-4e2f-aa04-902b26206c30", "c79ccd25-8591-4ee5-86ac-b65e4b5deb69", "SuperAdmin", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "719e6e5b-60bf-46c5-8297-95c18bfc11cc", "0f022136-ff9e-46ef-92a2-d7f8c7065fd3", "Member", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c2a89df9-a4d6-431a-9286-e50d5eee290e", "079c25fd-a279-4e2f-931d-db89873329f4", "Admin", null });
        }
    }
}
