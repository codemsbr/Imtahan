using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Imtahan.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b73dcbc-eb6e-48fd-a7e5-37e3e14fd1cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eee5903a-1576-44c2-9117-8d483d59775b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cc8e8d3a-55dd-4a14-bf77-37084bc9277f", "3b12e3ab-9a57-4ace-a8e2-4e4222b98ab3", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e58974f1-b0cb-4a99-98ea-78d5619561c4", "b2f9a845-217a-4e59-8cca-e1ac3ebf619a", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc8e8d3a-55dd-4a14-bf77-37084bc9277f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e58974f1-b0cb-4a99-98ea-78d5619561c4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5b73dcbc-eb6e-48fd-a7e5-37e3e14fd1cc", "4dfbd657-a4c3-4e85-b600-2aa55caee683", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eee5903a-1576-44c2-9117-8d483d59775b", "be3d1daf-70d1-46c5-8b96-68769a03b26f", "Member", "MEMBER" });
        }
    }
}
