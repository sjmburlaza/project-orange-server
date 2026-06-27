using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectOrangeApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSiteTradeInFlags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "Id",
                keyValue: 1,
                column: "TradeInEnabled",
                value: true);

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "Id",
                keyValue: 2,
                column: "TradeInEnabled",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "Id",
                keyValue: 1,
                column: "TradeInEnabled",
                value: false);

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "Id",
                keyValue: 2,
                column: "TradeInEnabled",
                value: true);
        }
    }
}
