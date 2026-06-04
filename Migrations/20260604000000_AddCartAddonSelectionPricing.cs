using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using ProjectOrangeApi.Data;

#nullable disable

namespace ProjectOrangeApi.Migrations
{
    /// <inheritdoc />
    [DbContext(typeof(AppDbContext))]
    [Migration("20260604000000_AddCartAddonSelectionPricing")]
    public partial class AddCartAddonSelectionPricing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "CartItemAddons",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "AmountDisplay",
                table: "CartItemAddons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BillingType",
                table: "CartItemAddons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "MultiplyByQuantity",
                table: "CartItemAddons",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "OptionCode",
                table: "CartItemAddons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OptionName",
                table: "CartItemAddons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "CartItemAddons");

            migrationBuilder.DropColumn(
                name: "AmountDisplay",
                table: "CartItemAddons");

            migrationBuilder.DropColumn(
                name: "BillingType",
                table: "CartItemAddons");

            migrationBuilder.DropColumn(
                name: "MultiplyByQuantity",
                table: "CartItemAddons");

            migrationBuilder.DropColumn(
                name: "OptionCode",
                table: "CartItemAddons");

            migrationBuilder.DropColumn(
                name: "OptionName",
                table: "CartItemAddons");
        }
    }
}
