using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    public partial class SeededDefaultUserAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2a03e792-b707-4689-aea5-f83fde6dd875", "7e4ad543-404e-411d-9540-cf91115a86f3", "user", "USER" },
                    { "e301b28a-320e-4c7b-9e4e-20689a685afd", "c6715880-a739-4a3d-8a10-793ad3254a01", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9accb19b-c635-4c63-86ee-3a3ac9de7343", 0, "6d502b9f-793a-47d6-94d4-15e05ff55bfd", "nadirashvili8@gmail.com", false, "admin", "admin", false, null, "NADIRASHVILI8@GMAIL.COM", "NADIRASHVILI8@GMAIL.COM", "AQAAAAEAACcQAAAAEFCjAPOzbLCzL/+GUuM/3/FkmI94CiIIZf6FYyEXVKzG4X9zQegXlU5T8RZYNrFQww==", null, false, "c16a740a-0323-4c7f-8f4b-2059af93dbad", false, "nadirashvili8@gmail.com" },
                    { "df2fe041-5f27-4a6c-869b-75092cc0d08d", 0, "c6d369de-5d0c-4d29-bfb4-a38f680c4a8b", "user@gmail.com", false, "System", "User", false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEH8cANzZ3qdNMdc8JE5ChXtFaosGycCoFMwLNUKj5Od6z4/TlHJwDo60iTxCI384BA==", null, false, "22b13858-69cc-4b02-98df-cee37088c815", false, "user@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e301b28a-320e-4c7b-9e4e-20689a685afd", "9accb19b-c635-4c63-86ee-3a3ac9de7343" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2a03e792-b707-4689-aea5-f83fde6dd875", "df2fe041-5f27-4a6c-869b-75092cc0d08d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e301b28a-320e-4c7b-9e4e-20689a685afd", "9accb19b-c635-4c63-86ee-3a3ac9de7343" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2a03e792-b707-4689-aea5-f83fde6dd875", "df2fe041-5f27-4a6c-869b-75092cc0d08d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a03e792-b707-4689-aea5-f83fde6dd875");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e301b28a-320e-4c7b-9e4e-20689a685afd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9accb19b-c635-4c63-86ee-3a3ac9de7343");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df2fe041-5f27-4a6c-869b-75092cc0d08d");
        }
    }
}
