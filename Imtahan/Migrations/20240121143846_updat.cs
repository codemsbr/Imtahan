using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Imtahan.Migrations
{
    public partial class updat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66471a19-0b7e-4315-a335-aaa89f26b40f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "867fd619-a229-41c6-b0b1-32b9ed3a8317");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bff046ab-0291-4d14-b22a-ec34ef1e7dcf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5b73dcbc-eb6e-48fd-a7e5-37e3e14fd1cc", "4dfbd657-a4c3-4e85-b600-2aa55caee683", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eee5903a-1576-44c2-9117-8d483d59775b", "be3d1daf-70d1-46c5-8b96-68769a03b26f", "Member", "MEMBER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "66471a19-0b7e-4315-a335-aaa89f26b40f", "3ae6fa7b-5673-44a0-8fb1-59066d14a669", "Member", "Member" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "867fd619-a229-41c6-b0b1-32b9ed3a8317", "277b43c9-cf19-4170-88bb-8a8e360c8b4b", "SuperAdmin", "SuperAdmin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bff046ab-0291-4d14-b22a-ec34ef1e7dcf", "2d5c8ce8-4856-4649-8761-f3385759dfc2", "Admin", "Admin" });
        }
    }
}
