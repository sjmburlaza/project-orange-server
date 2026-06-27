using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectOrangeApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedApplicationRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("""
                IF NOT EXISTS (SELECT 1 FROM [AspNetRoles] WHERE [NormalizedName] = N'ADMIN')
                BEGIN
                    INSERT INTO [AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
                    VALUES (N'role-admin', N'role-admin', N'admin', N'ADMIN');
                END

                IF NOT EXISTS (SELECT 1 FROM [AspNetRoles] WHERE [NormalizedName] = N'CUSTOMER')
                BEGIN
                    INSERT INTO [AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
                    VALUES (N'role-customer', N'role-customer', N'customer', N'CUSTOMER');
                END

                IF NOT EXISTS (SELECT 1 FROM [AspNetRoles] WHERE [NormalizedName] = N'INVENTORY-MANAGER')
                BEGIN
                    INSERT INTO [AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
                    VALUES (N'role-inventory-manager', N'role-inventory-manager', N'inventory-manager', N'INVENTORY-MANAGER');
                END

                IF NOT EXISTS (SELECT 1 FROM [AspNetRoles] WHERE [NormalizedName] = N'SUPPORT-AGENT')
                BEGIN
                    INSERT INTO [AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
                    VALUES (N'role-support-agent', N'role-support-agent', N'support-agent', N'SUPPORT-AGENT');
                END
                """);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "role-admin");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "role-customer");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "role-inventory-manager");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "role-support-agent");
        }
    }
}
