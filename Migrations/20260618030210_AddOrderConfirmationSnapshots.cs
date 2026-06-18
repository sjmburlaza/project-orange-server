using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectOrangeApi.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderConfirmationSnapshots : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "Orders",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "Orders",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Barangay",
                table: "Orders",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Orders",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Orders",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DeliveryEstimate",
                table: "Orders",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CheckoutDataJson",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "{}");

            migrationBuilder.AddColumn<string>(
                name: "MobileNumber",
                table: "Orders",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NextStepsJson",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<string>(
                name: "OrderNumber",
                table: "Orders",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OrderStatus",
                table: "Orders",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PaymentStatus",
                table: "Orders",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Orders",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RecipientName",
                table: "Orders",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "Orders",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "OrderItems",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "OrderItems",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ItemSpecsJson",
                table: "OrderItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "OrderItems",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.Sql("""
                UPDATE Orders
                SET
                    OrderNumber = CONCAT('OR-', CONVERT(char(8), CreatedAt, 112), '-', CAST(Id AS varchar(10))),
                    PaymentStatus = 'paid',
                    OrderStatus = 'confirmed',
                    RecipientName = CASE WHEN CustomerName = '' THEN 'Orange Customer' ELSE CustomerName END,
                    MobileNumber = '09170000000',
                    AddressLine1 = '123 Orange Avenue',
                    City = 'Manila',
                    PostalCode = '1000',
                    Country = 'Philippines',
                    DeliveryEstimate = '3-5 business days',
                    CheckoutDataJson = '{}',
                    NextStepsJson = '[]'
                WHERE OrderNumber = '';
                """);

            migrationBuilder.Sql("""
                UPDATE orderItem
                SET
                    ProductName = product.Name,
                    ImageUrl = product.ImageUrl,
                    CategoryName = COALESCE(category.Name, ''),
                    ItemSpecsJson = '[]'
                FROM OrderItems orderItem
                INNER JOIN Products product ON orderItem.ProductId = product.Id
                LEFT JOIN Categories category ON product.CategoryId = category.Id
                WHERE orderItem.ProductName = '';
                """);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SiteId_OrderNumber",
                table: "Orders",
                columns: new[] { "SiteId", "OrderNumber" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Orders_SiteId_OrderNumber",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Barangay",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CheckoutDataJson",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DeliveryEstimate",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "NextStepsJson",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderNumber",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderStatus",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "RecipientName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Region",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "ItemSpecsJson",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "OrderItems");
        }
    }
}
