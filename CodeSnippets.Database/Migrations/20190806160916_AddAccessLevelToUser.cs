using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeSnippets.Database.Migrations
{
    public partial class AddAccessLevelToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "AccessLevel",
                table: "User",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessLevel", "Password", "RegistrationDate", "Username" },
                values: new object[] { -1, (byte)2, "TVRJeg==", new DateTime(2019, 8, 6, 19, 9, 16, 452, DateTimeKind.Local).AddTicks(6864), "SaberMK" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DropColumn(
                name: "AccessLevel",
                table: "User");
        }
    }
}
