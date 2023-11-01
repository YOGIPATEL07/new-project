using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assignments.Migrations
{
    /// <inheritdoc />
    public partial class _7Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConsoleId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConsoleId",
                table: "Products");
        }
    }
}
