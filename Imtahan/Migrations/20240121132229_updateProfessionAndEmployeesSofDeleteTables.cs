using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Imtahan.Migrations
{
    public partial class updateProfessionAndEmployeesSofDeleteTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3464a5d0-b714-40c3-ab98-06bb5ac9a0e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5137040f-5a22-44c3-8d0e-bbb6c1287cb5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f75dddc0-ee0b-444a-b783-b9356c8de3cd");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Professions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3c300b1b-dff4-4124-82f8-f0e1651681de", "5ef53ea8-c6db-4f25-a96c-58b902def96d", "Member", "Member" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3c4766c2-3b78-4c10-afde-601799b0defc", "55fbee39-ceef-492f-a781-916b04e2a827", "SuperAdmin", "SuperAdmin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d4960a2-3ddf-4294-99c0-8afb7e05fb89", "6403c416-b06e-4217-a23d-120e63f4efdc", "Admin", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c300b1b-dff4-4124-82f8-f0e1651681de");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c4766c2-3b78-4c10-afde-601799b0defc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d4960a2-3ddf-4294-99c0-8afb7e05fb89");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Professions");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3464a5d0-b714-40c3-ab98-06bb5ac9a0e6", "cea05542-4401-49bd-93fc-8d0861bdbde1", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5137040f-5a22-44c3-8d0e-bbb6c1287cb5", "d8b63747-fbb5-4bb1-b30b-4e7ff9f11cce", "Member", "Member" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f75dddc0-ee0b-444a-b783-b9356c8de3cd", "571d3444-7f55-4d5e-811d-dbc8e1490e25", "SuperAdmin", "SuperAdmin" });
        }
    }
}
