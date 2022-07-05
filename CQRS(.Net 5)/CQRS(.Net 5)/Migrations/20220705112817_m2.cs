using Microsoft.EntityFrameworkCore.Migrations;

namespace CQRS_.Net_5_.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "Surname", "age" },
                values: new object[] { 1, "Furkan", "Çiftci", 29 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "Surname", "age" },
                values: new object[] { 2, "Gökhan", "Çiftci", 24 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "Surname", "age" },
                values: new object[] { 3, "Hakan", "Çiftci", 39 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
