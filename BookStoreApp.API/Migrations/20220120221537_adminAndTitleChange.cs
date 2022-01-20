using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    public partial class adminAndTitleChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a03e792-b707-4689-aea5-f83fde6dd875",
                column: "ConcurrencyStamp",
                value: "3a0aab8d-f88c-4386-bc83-ab10fca93579");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e301b28a-320e-4c7b-9e4e-20689a685afd",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b5724989-4333-475f-8170-e71d0b2851df", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9accb19b-c635-4c63-86ee-3a3ac9de7343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c6440e9-a784-4541-8b1e-7858771365d8", "AQAAAAEAACcQAAAAEPTAwMpYi74nfDuVhArY9noZhBbo6aJjQmMxs+y2v3/W8/Rn/vcNDv1vRVaEfZdXsQ==", "aeade4d2-418d-4d41-94f6-7758a7771549" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df2fe041-5f27-4a6c-869b-75092cc0d08d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53846be3-a0cb-40d8-8f0a-72937c623286", "AQAAAAEAACcQAAAAEExgZ179JL6/itXUiZ6B8r278Hv8heC4ssa4g0QBvFd5hk6jT4hxgffNMskjoIEMVw==", "b60e7330-10fd-4c8d-8825-c5e616da1a1c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a03e792-b707-4689-aea5-f83fde6dd875",
                column: "ConcurrencyStamp",
                value: "7e4ad543-404e-411d-9540-cf91115a86f3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e301b28a-320e-4c7b-9e4e-20689a685afd",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c6715880-a739-4a3d-8a10-793ad3254a01", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9accb19b-c635-4c63-86ee-3a3ac9de7343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d502b9f-793a-47d6-94d4-15e05ff55bfd", "AQAAAAEAACcQAAAAEFCjAPOzbLCzL/+GUuM/3/FkmI94CiIIZf6FYyEXVKzG4X9zQegXlU5T8RZYNrFQww==", "c16a740a-0323-4c7f-8f4b-2059af93dbad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df2fe041-5f27-4a6c-869b-75092cc0d08d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6d369de-5d0c-4d29-bfb4-a38f680c4a8b", "AQAAAAEAACcQAAAAEH8cANzZ3qdNMdc8JE5ChXtFaosGycCoFMwLNUKj5Od6z4/TlHJwDo60iTxCI384BA==", "22b13858-69cc-4b02-98df-cee37088c815" });
        }
    }
}
