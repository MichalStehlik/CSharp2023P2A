using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSharp19LINQ_DB.Migrations
{
    /// <inheritdoc />
    public partial class Seed1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Firstname", "Lastname" },
                values: new object[] { -1, "Eva", "Černá" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
