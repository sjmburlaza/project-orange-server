using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectOrangeApi.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderItemSubcategoryName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SubcategoryName",
                table: "OrderItems",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.Sql("""
                UPDATE orderItem
                SET orderItem.SubcategoryName = product.SubcategoryName
                FROM OrderItems AS orderItem
                INNER JOIN Products AS product ON product.Id = orderItem.ProductId
                WHERE orderItem.SubcategoryName = ''
                    AND product.SubcategoryName <> ''
                """);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubcategoryName",
                table: "OrderItems");
        }
    }
}
