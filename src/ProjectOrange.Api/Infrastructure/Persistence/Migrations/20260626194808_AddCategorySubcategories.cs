using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectOrangeApi.Migrations
{
    /// <inheritdoc />
    public partial class AddCategorySubcategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SubcategoriesJson",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubcategoriesJson",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "SubcategoriesJson",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "SubcategoriesJson",
                value: "[\"Keyboard\",\"Mouse\",\"Earbuds\",\"Headphones\",\"Headset\"]");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "SubcategoriesJson",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "SubcategoriesJson",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "SubcategoriesJson",
                value: "[\"Keyboard\",\"Mouse\",\"Earbuds\",\"Headphones\",\"Headset\"]");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "SubcategoriesJson",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "SubcategoriesJson",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "SubcategoriesJson",
                value: "[\"Keyboard\",\"Mouse\",\"Earbuds\",\"Headphones\",\"Headset\"]");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "SubcategoriesJson",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "SubcategoriesJson",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "SubcategoriesJson",
                value: "[\"Keyboard\",\"Mouse\",\"Earbuds\",\"Headphones\",\"Headset\"]");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "SubcategoriesJson",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "SubcategoriesJson",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "SubcategoriesJson",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "SubcategoriesJson",
                value: "[]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubcategoriesJson",
                table: "Categories");
        }
    }
}
