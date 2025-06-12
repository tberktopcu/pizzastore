using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaStore.Migrations
{
    /// <inheritdoc />
    public partial class MigrationName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "test",
                table: "Pizzas",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 1,
                column: "test",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "test",
                table: "Pizzas");
        }
    }
}
