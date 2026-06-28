using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectOrangeApi.Migrations
{
    /// <inheritdoc />
    public partial class AddCartItemSubcategoryName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SubcategoryName",
                table: "CartItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.Sql("""
                UPDATE cartItem
                SET cartItem.SubcategoryName = product.SubcategoryName
                FROM CartItems AS cartItem
                INNER JOIN Products AS product ON product.Id = cartItem.ProductId
                WHERE cartItem.SubcategoryName = ''
                    AND product.SubcategoryName <> ''
                """);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubcategoryName",
                table: "CartItems");
        }
    }
}
