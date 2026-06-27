using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectOrangeApi.Migrations
{
    /// <inheritdoc />
    public partial class AddConfigurableOptionsForLaptopsAndMonitors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2000);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2600);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2700);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2800);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2900);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3000);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4000);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4600);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4700);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4800);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4900);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5000);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6000);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6600);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6700);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6800);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6900);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7000);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8000);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8100);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8200);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8300);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8400);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8500);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8600);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8700);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8800);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8900);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9000);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9100);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9200);

            migrationBuilder.InsertData(
                table: "ProductOptionGroups",
                columns: new[] { "Id", "Code", "Label", "ProductId", "SortOrder" },
                values: new object[,]
                {
                    { 61, "color", "Color", 6, 1 },
                    { 62, "storage", "Storage", 6, 3 },
                    { 63, "memory", "Memory", 6, 2 },
                    { 71, "color", "Color", 7, 1 },
                    { 72, "storage", "Storage", 7, 3 },
                    { 73, "memory", "Memory", 7, 2 },
                    { 81, "color", "Color", 8, 1 },
                    { 82, "storage", "Storage", 8, 3 },
                    { 83, "memory", "Memory", 8, 2 },
                    { 91, "color", "Color", 9, 1 },
                    { 92, "storage", "Storage", 9, 3 },
                    { 93, "memory", "Memory", 9, 2 },
                    { 101, "color", "Color", 10, 1 },
                    { 102, "storage", "Storage", 10, 3 },
                    { 103, "memory", "Memory", 10, 2 },
                    { 201, "color", "Color", 20, 1 },
                    { 204, "stand", "Stand", 20, 2 },
                    { 261, "color", "Color", 26, 1 },
                    { 262, "storage", "Storage", 26, 3 },
                    { 263, "memory", "Memory", 26, 2 },
                    { 271, "color", "Color", 27, 1 },
                    { 272, "storage", "Storage", 27, 3 },
                    { 273, "memory", "Memory", 27, 2 },
                    { 281, "color", "Color", 28, 1 },
                    { 282, "storage", "Storage", 28, 3 },
                    { 283, "memory", "Memory", 28, 2 },
                    { 291, "color", "Color", 29, 1 },
                    { 292, "storage", "Storage", 29, 3 },
                    { 293, "memory", "Memory", 29, 2 },
                    { 301, "color", "Color", 30, 1 },
                    { 302, "storage", "Storage", 30, 3 },
                    { 303, "memory", "Memory", 30, 2 },
                    { 401, "color", "Color", 40, 1 },
                    { 404, "stand", "Stand", 40, 2 },
                    { 461, "color", "Color", 46, 1 },
                    { 462, "storage", "Storage", 46, 3 },
                    { 463, "memory", "Memory", 46, 2 },
                    { 471, "color", "Color", 47, 1 },
                    { 472, "storage", "Storage", 47, 3 },
                    { 473, "memory", "Memory", 47, 2 },
                    { 481, "color", "Color", 48, 1 },
                    { 482, "storage", "Storage", 48, 3 },
                    { 483, "memory", "Memory", 48, 2 },
                    { 491, "color", "Color", 49, 1 },
                    { 492, "storage", "Storage", 49, 3 },
                    { 493, "memory", "Memory", 49, 2 },
                    { 501, "color", "Color", 50, 1 },
                    { 502, "storage", "Storage", 50, 3 },
                    { 503, "memory", "Memory", 50, 2 },
                    { 601, "color", "Color", 60, 1 },
                    { 604, "stand", "Stand", 60, 2 },
                    { 661, "color", "Color", 66, 1 },
                    { 662, "storage", "Storage", 66, 3 },
                    { 663, "memory", "Memory", 66, 2 },
                    { 671, "color", "Color", 67, 1 },
                    { 672, "storage", "Storage", 67, 3 },
                    { 673, "memory", "Memory", 67, 2 },
                    { 681, "color", "Color", 68, 1 },
                    { 682, "storage", "Storage", 68, 3 },
                    { 683, "memory", "Memory", 68, 2 },
                    { 691, "color", "Color", 69, 1 },
                    { 692, "storage", "Storage", 69, 3 },
                    { 693, "memory", "Memory", 69, 2 },
                    { 701, "color", "Color", 70, 1 },
                    { 702, "storage", "Storage", 70, 3 },
                    { 703, "memory", "Memory", 70, 2 },
                    { 801, "color", "Color", 80, 1 },
                    { 804, "stand", "Stand", 80, 2 },
                    { 811, "color", "Color", 81, 1 },
                    { 814, "stand", "Stand", 81, 2 },
                    { 821, "color", "Color", 82, 1 },
                    { 824, "stand", "Stand", 82, 2 },
                    { 831, "color", "Color", 83, 1 },
                    { 834, "stand", "Stand", 83, 2 },
                    { 841, "color", "Color", 84, 1 },
                    { 844, "stand", "Stand", 84, 2 },
                    { 851, "color", "Color", 85, 1 },
                    { 854, "stand", "Stand", 85, 2 },
                    { 861, "color", "Color", 86, 1 },
                    { 864, "stand", "Stand", 86, 2 },
                    { 871, "color", "Color", 87, 1 },
                    { 874, "stand", "Stand", 87, 2 },
                    { 881, "color", "Color", 88, 1 },
                    { 884, "stand", "Stand", 88, 2 },
                    { 891, "color", "Color", 89, 1 },
                    { 894, "stand", "Stand", 89, 2 },
                    { 901, "color", "Color", 90, 1 },
                    { 904, "stand", "Stand", 90, 2 },
                    { 911, "color", "Color", 91, 1 },
                    { 914, "stand", "Stand", 91, 2 },
                    { 921, "color", "Color", 92, 1 },
                    { 924, "stand", "Stand", 92, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "Id", "ImageUrl", "Price", "ProductId", "Sku", "StockQuantity" },
                values: new object[,]
                {
                    { 601, "", 69999m, 6, "PROD-6-MIDNIGHT-8GB-256GB", 2 },
                    { 602, "", 81198.84m, 6, "PROD-6-MIDNIGHT-16GB-512GB", 2 },
                    { 603, "", 92398.68m, 6, "PROD-6-MIDNIGHT-32GB-1TB", 0 },
                    { 604, "", 69999m, 6, "PROD-6-SILVER-8GB-256GB", 2 },
                    { 605, "", 81198.84m, 6, "PROD-6-SILVER-16GB-512GB", 1 },
                    { 606, "", 92398.68m, 6, "PROD-6-SILVER-32GB-1TB", 0 },
                    { 701, "", 74999m, 7, "PROD-7-MIDNIGHT-8GB-256GB", 2 },
                    { 702, "", 86998.84m, 7, "PROD-7-MIDNIGHT-16GB-512GB", 1 },
                    { 703, "", 98998.68m, 7, "PROD-7-MIDNIGHT-32GB-1TB", 0 },
                    { 704, "", 74999m, 7, "PROD-7-SILVER-8GB-256GB", 2 },
                    { 705, "", 86998.84m, 7, "PROD-7-SILVER-16GB-512GB", 1 },
                    { 706, "", 98998.68m, 7, "PROD-7-SILVER-32GB-1TB", 0 },
                    { 801, "", 89999m, 8, "PROD-8-MIDNIGHT-8GB-256GB", 2 },
                    { 802, "", 104398.84m, 8, "PROD-8-MIDNIGHT-16GB-512GB", 1 },
                    { 803, "", 118798.68m, 8, "PROD-8-MIDNIGHT-32GB-1TB", 0 },
                    { 804, "", 89999m, 8, "PROD-8-SILVER-8GB-256GB", 2 },
                    { 805, "", 104398.84m, 8, "PROD-8-SILVER-16GB-512GB", 0 },
                    { 806, "", 118798.68m, 8, "PROD-8-SILVER-32GB-1TB", 0 },
                    { 901, "", 94999m, 9, "PROD-9-MIDNIGHT-8GB-256GB", 2 },
                    { 902, "", 110198.84m, 9, "PROD-9-MIDNIGHT-16GB-512GB", 0 },
                    { 903, "", 125398.68m, 9, "PROD-9-MIDNIGHT-32GB-1TB", 0 },
                    { 904, "", 94999m, 9, "PROD-9-SILVER-8GB-256GB", 2 },
                    { 905, "", 110198.84m, 9, "PROD-9-SILVER-16GB-512GB", 0 },
                    { 906, "", 125398.68m, 9, "PROD-9-SILVER-32GB-1TB", 0 },
                    { 1001, "", 39999m, 10, "PROD-10-MIDNIGHT-8GB-256GB", 3 },
                    { 1002, "", 46398.84m, 10, "PROD-10-MIDNIGHT-16GB-512GB", 2 },
                    { 1003, "", 52798.68m, 10, "PROD-10-MIDNIGHT-32GB-1TB", 1 },
                    { 1004, "", 39999m, 10, "PROD-10-SILVER-8GB-256GB", 3 },
                    { 1005, "", 46398.84m, 10, "PROD-10-SILVER-16GB-512GB", 2 },
                    { 1006, "", 52798.68m, 10, "PROD-10-SILVER-32GB-1TB", 0 },
                    { 2001, "", 12999m, 20, "PROD-20-BLACK-STANDARD", 6 },
                    { 2002, "", 14038.92m, 20, "PROD-20-BLACK-HEIGHT-ADJUSTABLE", 2 },
                    { 2003, "", 13388.97m, 20, "PROD-20-SILVER-STANDARD", 2 },
                    { 2004, "", 14428.89m, 20, "PROD-20-SILVER-HEIGHT-ADJUSTABLE", 0 },
                    { 2601, "", 1999m, 26, "PROD-26-MIDNIGHT-8GB-256GB", 2 },
                    { 2602, "", 2318.84m, 26, "PROD-26-MIDNIGHT-16GB-512GB", 1 },
                    { 2603, "", 2638.68m, 26, "PROD-26-MIDNIGHT-32GB-1TB", 0 },
                    { 2604, "", 1999m, 26, "PROD-26-SILVER-8GB-256GB", 2 },
                    { 2605, "", 2318.84m, 26, "PROD-26-SILVER-16GB-512GB", 0 },
                    { 2606, "", 2638.68m, 26, "PROD-26-SILVER-32GB-1TB", 0 },
                    { 2701, "", 1499m, 27, "PROD-27-MIDNIGHT-8GB-256GB", 2 },
                    { 2702, "", 1738.84m, 27, "PROD-27-MIDNIGHT-16GB-512GB", 2 },
                    { 2703, "", 1978.68m, 27, "PROD-27-MIDNIGHT-32GB-1TB", 0 },
                    { 2704, "", 1499m, 27, "PROD-27-SILVER-8GB-256GB", 2 },
                    { 2705, "", 1738.84m, 27, "PROD-27-SILVER-16GB-512GB", 1 },
                    { 2706, "", 1978.68m, 27, "PROD-27-SILVER-32GB-1TB", 0 },
                    { 2801, "", 1599m, 28, "PROD-28-MIDNIGHT-8GB-256GB", 2 },
                    { 2802, "", 1854.84m, 28, "PROD-28-MIDNIGHT-16GB-512GB", 1 },
                    { 2803, "", 2110.68m, 28, "PROD-28-MIDNIGHT-32GB-1TB", 0 },
                    { 2804, "", 1599m, 28, "PROD-28-SILVER-8GB-256GB", 2 },
                    { 2805, "", 1854.84m, 28, "PROD-28-SILVER-16GB-512GB", 1 },
                    { 2806, "", 2110.68m, 28, "PROD-28-SILVER-32GB-1TB", 0 },
                    { 2901, "", 1199m, 29, "PROD-29-MIDNIGHT-8GB-256GB", 3 },
                    { 2902, "", 1390.84m, 29, "PROD-29-MIDNIGHT-16GB-512GB", 2 },
                    { 2903, "", 1582.68m, 29, "PROD-29-MIDNIGHT-32GB-1TB", 0 },
                    { 2904, "", 1199m, 29, "PROD-29-SILVER-8GB-256GB", 3 },
                    { 2905, "", 1390.84m, 29, "PROD-29-SILVER-16GB-512GB", 1 },
                    { 2906, "", 1582.68m, 29, "PROD-29-SILVER-32GB-1TB", 0 },
                    { 3001, "", 999m, 30, "PROD-30-MIDNIGHT-8GB-256GB", 3 },
                    { 3002, "", 1158.84m, 30, "PROD-30-MIDNIGHT-16GB-512GB", 2 },
                    { 3003, "", 1318.68m, 30, "PROD-30-MIDNIGHT-32GB-1TB", 1 },
                    { 3004, "", 999m, 30, "PROD-30-SILVER-8GB-256GB", 3 },
                    { 3005, "", 1158.84m, 30, "PROD-30-SILVER-16GB-512GB", 2 },
                    { 3006, "", 1318.68m, 30, "PROD-30-SILVER-32GB-1TB", 0 },
                    { 4001, "", 299m, 40, "PROD-40-BLACK-STANDARD", 5 },
                    { 4002, "", 322.92m, 40, "PROD-40-BLACK-HEIGHT-ADJUSTABLE", 2 },
                    { 4003, "", 307.97m, 40, "PROD-40-SILVER-STANDARD", 2 },
                    { 4004, "", 331.89m, 40, "PROD-40-SILVER-HEIGHT-ADJUSTABLE", 0 },
                    { 4601, "", 9999m, 46, "PROD-46-MIDNIGHT-8GB-256GB", 2 },
                    { 4602, "", 11598.84m, 46, "PROD-46-MIDNIGHT-16GB-512GB", 1 },
                    { 4603, "", 13198.68m, 46, "PROD-46-MIDNIGHT-32GB-1TB", 0 },
                    { 4604, "", 9999m, 46, "PROD-46-SILVER-8GB-256GB", 2 },
                    { 4605, "", 11598.84m, 46, "PROD-46-SILVER-16GB-512GB", 1 },
                    { 4606, "", 13198.68m, 46, "PROD-46-SILVER-32GB-1TB", 0 },
                    { 4701, "", 5799m, 47, "PROD-47-MIDNIGHT-8GB-256GB", 3 },
                    { 4702, "", 6726.84m, 47, "PROD-47-MIDNIGHT-16GB-512GB", 2 },
                    { 4703, "", 7654.68m, 47, "PROD-47-MIDNIGHT-32GB-1TB", 1 },
                    { 4704, "", 5799m, 47, "PROD-47-SILVER-8GB-256GB", 3 },
                    { 4705, "", 6726.84m, 47, "PROD-47-SILVER-16GB-512GB", 2 },
                    { 4706, "", 7654.68m, 47, "PROD-47-SILVER-32GB-1TB", 0 },
                    { 4801, "", 6999m, 48, "PROD-48-MIDNIGHT-8GB-256GB", 3 },
                    { 4802, "", 8118.84m, 48, "PROD-48-MIDNIGHT-16GB-512GB", 1 },
                    { 4803, "", 9238.68m, 48, "PROD-48-MIDNIGHT-32GB-1TB", 0 },
                    { 4804, "", 6999m, 48, "PROD-48-SILVER-8GB-256GB", 3 },
                    { 4805, "", 8118.84m, 48, "PROD-48-SILVER-16GB-512GB", 1 },
                    { 4806, "", 9238.68m, 48, "PROD-48-SILVER-32GB-1TB", 0 },
                    { 4901, "", 4999m, 49, "PROD-49-MIDNIGHT-8GB-256GB", 4 },
                    { 4902, "", 5798.84m, 49, "PROD-49-MIDNIGHT-16GB-512GB", 2 },
                    { 4903, "", 6598.68m, 49, "PROD-49-MIDNIGHT-32GB-1TB", 1 },
                    { 4904, "", 4999m, 49, "PROD-49-SILVER-8GB-256GB", 4 },
                    { 4905, "", 5798.84m, 49, "PROD-49-SILVER-16GB-512GB", 2 },
                    { 4906, "", 6598.68m, 49, "PROD-49-SILVER-32GB-1TB", 0 },
                    { 5001, "", 7499m, 50, "PROD-50-MIDNIGHT-8GB-256GB", 2 },
                    { 5002, "", 8698.84m, 50, "PROD-50-MIDNIGHT-16GB-512GB", 1 },
                    { 5003, "", 9898.68m, 50, "PROD-50-MIDNIGHT-32GB-1TB", 0 },
                    { 5004, "", 7499m, 50, "PROD-50-SILVER-8GB-256GB", 2 },
                    { 5005, "", 8698.84m, 50, "PROD-50-SILVER-16GB-512GB", 0 },
                    { 5006, "", 9898.68m, 50, "PROD-50-SILVER-32GB-1TB", 0 },
                    { 6001, "", 1299m, 60, "PROD-60-BLACK-STANDARD", 6 },
                    { 6002, "", 1402.92m, 60, "PROD-60-BLACK-HEIGHT-ADJUSTABLE", 3 },
                    { 6003, "", 1337.97m, 60, "PROD-60-SILVER-STANDARD", 3 },
                    { 6004, "", 1441.89m, 60, "PROD-60-SILVER-HEIGHT-ADJUSTABLE", 0 },
                    { 6601, "", 249800m, 66, "PROD-66-MIDNIGHT-8GB-256GB", 2 },
                    { 6602, "", 289768.00m, 66, "PROD-66-MIDNIGHT-16GB-512GB", 1 },
                    { 6603, "", 329736.00m, 66, "PROD-66-MIDNIGHT-32GB-1TB", 0 },
                    { 6604, "", 249800m, 66, "PROD-66-SILVER-8GB-256GB", 2 },
                    { 6605, "", 289768.00m, 66, "PROD-66-SILVER-16GB-512GB", 0 },
                    { 6606, "", 329736.00m, 66, "PROD-66-SILVER-32GB-1TB", 0 },
                    { 6701, "", 289800m, 67, "PROD-67-MIDNIGHT-8GB-256GB", 2 },
                    { 6702, "", 336168.00m, 67, "PROD-67-MIDNIGHT-16GB-512GB", 0 },
                    { 6703, "", 382536.00m, 67, "PROD-67-MIDNIGHT-32GB-1TB", 0 },
                    { 6704, "", 289800m, 67, "PROD-67-SILVER-8GB-256GB", 2 },
                    { 6705, "", 336168.00m, 67, "PROD-67-SILVER-16GB-512GB", 0 },
                    { 6706, "", 382536.00m, 67, "PROD-67-SILVER-32GB-1TB", 0 },
                    { 6801, "", 164800m, 68, "PROD-68-MIDNIGHT-8GB-256GB", 3 },
                    { 6802, "", 191168.00m, 68, "PROD-68-MIDNIGHT-16GB-512GB", 2 },
                    { 6803, "", 217536.00m, 68, "PROD-68-MIDNIGHT-32GB-1TB", 0 },
                    { 6804, "", 164800m, 68, "PROD-68-SILVER-8GB-256GB", 3 },
                    { 6805, "", 191168.00m, 68, "PROD-68-SILVER-16GB-512GB", 1 },
                    { 6806, "", 217536.00m, 68, "PROD-68-SILVER-32GB-1TB", 0 },
                    { 6901, "", 179800m, 69, "PROD-69-MIDNIGHT-8GB-256GB", 2 },
                    { 6902, "", 208568.00m, 69, "PROD-69-MIDNIGHT-16GB-512GB", 1 },
                    { 6903, "", 237336.00m, 69, "PROD-69-MIDNIGHT-32GB-1TB", 0 },
                    { 6904, "", 179800m, 69, "PROD-69-SILVER-8GB-256GB", 2 },
                    { 6905, "", 208568.00m, 69, "PROD-69-SILVER-16GB-512GB", 1 },
                    { 6906, "", 237336.00m, 69, "PROD-69-SILVER-32GB-1TB", 0 },
                    { 7001, "", 198000m, 70, "PROD-70-MIDNIGHT-8GB-256GB", 3 },
                    { 7002, "", 229680.00m, 70, "PROD-70-MIDNIGHT-16GB-512GB", 1 },
                    { 7003, "", 261360.00m, 70, "PROD-70-MIDNIGHT-32GB-1TB", 0 },
                    { 7004, "", 198000m, 70, "PROD-70-SILVER-8GB-256GB", 3 },
                    { 7005, "", 229680.00m, 70, "PROD-70-SILVER-16GB-512GB", 1 },
                    { 7006, "", 261360.00m, 70, "PROD-70-SILVER-32GB-1TB", 0 },
                    { 8001, "", 44800m, 80, "PROD-80-BLACK-STANDARD", 5 },
                    { 8002, "", 48384.00m, 80, "PROD-80-BLACK-HEIGHT-ADJUSTABLE", 2 },
                    { 8003, "", 46144.00m, 80, "PROD-80-SILVER-STANDARD", 2 },
                    { 8004, "", 49728.00m, 80, "PROD-80-SILVER-HEIGHT-ADJUSTABLE", 0 },
                    { 8101, "", 7999m, 81, "PROD-81-BLACK-STANDARD", 8 },
                    { 8102, "", 8638.92m, 81, "PROD-81-BLACK-HEIGHT-ADJUSTABLE", 3 },
                    { 8103, "", 8238.97m, 81, "PROD-81-SILVER-STANDARD", 3 },
                    { 8104, "", 8878.89m, 81, "PROD-81-SILVER-HEIGHT-ADJUSTABLE", 0 },
                    { 8201, "", 179m, 82, "PROD-82-BLACK-STANDARD", 6 },
                    { 8202, "", 193.32m, 82, "PROD-82-BLACK-HEIGHT-ADJUSTABLE", 2 },
                    { 8203, "", 184.37m, 82, "PROD-82-SILVER-STANDARD", 2 },
                    { 8204, "", 198.69m, 82, "PROD-82-SILVER-HEIGHT-ADJUSTABLE", 0 },
                    { 8301, "", 799m, 83, "PROD-83-BLACK-STANDARD", 10 },
                    { 8302, "", 862.92m, 83, "PROD-83-BLACK-HEIGHT-ADJUSTABLE", 4 },
                    { 8303, "", 822.97m, 83, "PROD-83-SILVER-STANDARD", 4 },
                    { 8304, "", 886.89m, 83, "PROD-83-SILVER-HEIGHT-ADJUSTABLE", 0 },
                    { 8401, "", 24800m, 84, "PROD-84-BLACK-STANDARD", 8 },
                    { 8402, "", 26784.00m, 84, "PROD-84-BLACK-HEIGHT-ADJUSTABLE", 3 },
                    { 8403, "", 25544.00m, 84, "PROD-84-SILVER-STANDARD", 3 },
                    { 8404, "", 27528.00m, 84, "PROD-84-SILVER-HEIGHT-ADJUSTABLE", 0 },
                    { 8501, "", 24999m, 85, "PROD-85-BLACK-STANDARD", 4 },
                    { 8502, "", 26998.92m, 85, "PROD-85-BLACK-HEIGHT-ADJUSTABLE", 2 },
                    { 8503, "", 25748.97m, 85, "PROD-85-SILVER-STANDARD", 2 },
                    { 8504, "", 27748.89m, 85, "PROD-85-SILVER-HEIGHT-ADJUSTABLE", 0 },
                    { 8601, "", 449m, 86, "PROD-86-BLACK-STANDARD", 4 },
                    { 8602, "", 484.92m, 86, "PROD-86-BLACK-HEIGHT-ADJUSTABLE", 2 },
                    { 8603, "", 462.47m, 86, "PROD-86-SILVER-STANDARD", 1 },
                    { 8604, "", 498.39m, 86, "PROD-86-SILVER-HEIGHT-ADJUSTABLE", 0 },
                    { 8701, "", 2499m, 87, "PROD-87-BLACK-STANDARD", 4 },
                    { 8702, "", 2698.92m, 87, "PROD-87-BLACK-HEIGHT-ADJUSTABLE", 2 },
                    { 8703, "", 2573.97m, 87, "PROD-87-SILVER-STANDARD", 2 },
                    { 8704, "", 2773.89m, 87, "PROD-87-SILVER-HEIGHT-ADJUSTABLE", 0 },
                    { 8801, "", 69800m, 88, "PROD-88-BLACK-STANDARD", 4 },
                    { 8802, "", 75384.00m, 88, "PROD-88-BLACK-HEIGHT-ADJUSTABLE", 2 },
                    { 8803, "", 71894.00m, 88, "PROD-88-SILVER-STANDARD", 1 },
                    { 8804, "", 77478.00m, 88, "PROD-88-SILVER-HEIGHT-ADJUSTABLE", 0 },
                    { 8901, "", 27999m, 89, "PROD-89-BLACK-STANDARD", 4 },
                    { 8902, "", 30238.92m, 89, "PROD-89-BLACK-HEIGHT-ADJUSTABLE", 1 },
                    { 8903, "", 28838.97m, 89, "PROD-89-SILVER-STANDARD", 1 },
                    { 8904, "", 31078.89m, 89, "PROD-89-SILVER-HEIGHT-ADJUSTABLE", 0 },
                    { 9001, "", 549m, 90, "PROD-90-BLACK-STANDARD", 4 },
                    { 9002, "", 592.92m, 90, "PROD-90-BLACK-HEIGHT-ADJUSTABLE", 1 },
                    { 9003, "", 565.47m, 90, "PROD-90-SILVER-STANDARD", 1 },
                    { 9004, "", 609.39m, 90, "PROD-90-SILVER-HEIGHT-ADJUSTABLE", 0 },
                    { 9101, "", 2999m, 91, "PROD-91-BLACK-STANDARD", 4 },
                    { 9102, "", 3238.92m, 91, "PROD-91-BLACK-HEIGHT-ADJUSTABLE", 1 },
                    { 9103, "", 3088.97m, 91, "PROD-91-SILVER-STANDARD", 1 },
                    { 9104, "", 3328.89m, 91, "PROD-91-SILVER-HEIGHT-ADJUSTABLE", 0 },
                    { 9201, "", 79800m, 92, "PROD-92-BLACK-STANDARD", 4 },
                    { 9202, "", 86184.00m, 92, "PROD-92-BLACK-HEIGHT-ADJUSTABLE", 1 },
                    { 9203, "", 82194.00m, 92, "PROD-92-SILVER-STANDARD", 1 },
                    { 9204, "", 88578.00m, 92, "PROD-92-SILVER-HEIGHT-ADJUSTABLE", 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductOptions",
                columns: new[] { "Id", "Code", "Hex", "ImageUrl", "Label", "ProductOptionGroupId", "SortOrder" },
                values: new object[,]
                {
                    { 613, "midnight", "#1f2937", null, "Midnight", 61, 1 },
                    { 614, "silver", "#d1d5db", null, "Silver", 61, 2 },
                    { 622, "256gb", null, null, "256GB", 62, 1 },
                    { 623, "512gb", null, null, "512GB", 62, 2 },
                    { 624, "1tb", null, null, "1TB", 62, 3 },
                    { 631, "8gb", null, null, "8GB", 63, 1 },
                    { 632, "16gb", null, null, "16GB", 63, 2 },
                    { 633, "32gb", null, null, "32GB", 63, 3 },
                    { 713, "midnight", "#1f2937", null, "Midnight", 71, 1 },
                    { 714, "silver", "#d1d5db", null, "Silver", 71, 2 },
                    { 722, "256gb", null, null, "256GB", 72, 1 },
                    { 723, "512gb", null, null, "512GB", 72, 2 },
                    { 724, "1tb", null, null, "1TB", 72, 3 },
                    { 731, "8gb", null, null, "8GB", 73, 1 },
                    { 732, "16gb", null, null, "16GB", 73, 2 },
                    { 733, "32gb", null, null, "32GB", 73, 3 },
                    { 813, "midnight", "#1f2937", null, "Midnight", 81, 1 },
                    { 814, "silver", "#d1d5db", null, "Silver", 81, 2 },
                    { 822, "256gb", null, null, "256GB", 82, 1 },
                    { 823, "512gb", null, null, "512GB", 82, 2 },
                    { 824, "1tb", null, null, "1TB", 82, 3 },
                    { 831, "8gb", null, null, "8GB", 83, 1 },
                    { 832, "16gb", null, null, "16GB", 83, 2 },
                    { 833, "32gb", null, null, "32GB", 83, 3 },
                    { 913, "midnight", "#1f2937", null, "Midnight", 91, 1 },
                    { 914, "silver", "#d1d5db", null, "Silver", 91, 2 },
                    { 922, "256gb", null, null, "256GB", 92, 1 },
                    { 923, "512gb", null, null, "512GB", 92, 2 },
                    { 924, "1tb", null, null, "1TB", 92, 3 },
                    { 931, "8gb", null, null, "8GB", 93, 1 },
                    { 932, "16gb", null, null, "16GB", 93, 2 },
                    { 933, "32gb", null, null, "32GB", 93, 3 },
                    { 1013, "midnight", "#1f2937", null, "Midnight", 101, 1 },
                    { 1014, "silver", "#d1d5db", null, "Silver", 101, 2 },
                    { 1022, "256gb", null, null, "256GB", 102, 1 },
                    { 1023, "512gb", null, null, "512GB", 102, 2 },
                    { 1024, "1tb", null, null, "1TB", 102, 3 },
                    { 1031, "8gb", null, null, "8GB", 103, 1 },
                    { 1032, "16gb", null, null, "16GB", 103, 2 },
                    { 1033, "32gb", null, null, "32GB", 103, 3 },
                    { 2011, "black", "#111827", null, "Black", 201, 1 },
                    { 2014, "silver", "#d1d5db", null, "Silver", 201, 2 },
                    { 2041, "standard", null, null, "Standard Stand", 204, 1 },
                    { 2042, "height-adjustable", null, null, "Height Adjustable Stand", 204, 2 },
                    { 2613, "midnight", "#1f2937", null, "Midnight", 261, 1 },
                    { 2614, "silver", "#d1d5db", null, "Silver", 261, 2 },
                    { 2622, "256gb", null, null, "256GB", 262, 1 },
                    { 2623, "512gb", null, null, "512GB", 262, 2 },
                    { 2624, "1tb", null, null, "1TB", 262, 3 },
                    { 2631, "8gb", null, null, "8GB", 263, 1 },
                    { 2632, "16gb", null, null, "16GB", 263, 2 },
                    { 2633, "32gb", null, null, "32GB", 263, 3 },
                    { 2713, "midnight", "#1f2937", null, "Midnight", 271, 1 },
                    { 2714, "silver", "#d1d5db", null, "Silver", 271, 2 },
                    { 2722, "256gb", null, null, "256GB", 272, 1 },
                    { 2723, "512gb", null, null, "512GB", 272, 2 },
                    { 2724, "1tb", null, null, "1TB", 272, 3 },
                    { 2731, "8gb", null, null, "8GB", 273, 1 },
                    { 2732, "16gb", null, null, "16GB", 273, 2 },
                    { 2733, "32gb", null, null, "32GB", 273, 3 },
                    { 2813, "midnight", "#1f2937", null, "Midnight", 281, 1 },
                    { 2814, "silver", "#d1d5db", null, "Silver", 281, 2 },
                    { 2822, "256gb", null, null, "256GB", 282, 1 },
                    { 2823, "512gb", null, null, "512GB", 282, 2 },
                    { 2824, "1tb", null, null, "1TB", 282, 3 },
                    { 2831, "8gb", null, null, "8GB", 283, 1 },
                    { 2832, "16gb", null, null, "16GB", 283, 2 },
                    { 2833, "32gb", null, null, "32GB", 283, 3 },
                    { 2913, "midnight", "#1f2937", null, "Midnight", 291, 1 },
                    { 2914, "silver", "#d1d5db", null, "Silver", 291, 2 },
                    { 2922, "256gb", null, null, "256GB", 292, 1 },
                    { 2923, "512gb", null, null, "512GB", 292, 2 },
                    { 2924, "1tb", null, null, "1TB", 292, 3 },
                    { 2931, "8gb", null, null, "8GB", 293, 1 },
                    { 2932, "16gb", null, null, "16GB", 293, 2 },
                    { 2933, "32gb", null, null, "32GB", 293, 3 },
                    { 3013, "midnight", "#1f2937", null, "Midnight", 301, 1 },
                    { 3014, "silver", "#d1d5db", null, "Silver", 301, 2 },
                    { 3022, "256gb", null, null, "256GB", 302, 1 },
                    { 3023, "512gb", null, null, "512GB", 302, 2 },
                    { 3024, "1tb", null, null, "1TB", 302, 3 },
                    { 3031, "8gb", null, null, "8GB", 303, 1 },
                    { 3032, "16gb", null, null, "16GB", 303, 2 },
                    { 3033, "32gb", null, null, "32GB", 303, 3 },
                    { 4011, "black", "#111827", null, "Black", 401, 1 },
                    { 4014, "silver", "#d1d5db", null, "Silver", 401, 2 },
                    { 4041, "standard", null, null, "Standard Stand", 404, 1 },
                    { 4042, "height-adjustable", null, null, "Height Adjustable Stand", 404, 2 },
                    { 4613, "midnight", "#1f2937", null, "Midnight", 461, 1 },
                    { 4614, "silver", "#d1d5db", null, "Silver", 461, 2 },
                    { 4622, "256gb", null, null, "256GB", 462, 1 },
                    { 4623, "512gb", null, null, "512GB", 462, 2 },
                    { 4624, "1tb", null, null, "1TB", 462, 3 },
                    { 4631, "8gb", null, null, "8GB", 463, 1 },
                    { 4632, "16gb", null, null, "16GB", 463, 2 },
                    { 4633, "32gb", null, null, "32GB", 463, 3 },
                    { 4713, "midnight", "#1f2937", null, "Midnight", 471, 1 },
                    { 4714, "silver", "#d1d5db", null, "Silver", 471, 2 },
                    { 4722, "256gb", null, null, "256GB", 472, 1 },
                    { 4723, "512gb", null, null, "512GB", 472, 2 },
                    { 4724, "1tb", null, null, "1TB", 472, 3 },
                    { 4731, "8gb", null, null, "8GB", 473, 1 },
                    { 4732, "16gb", null, null, "16GB", 473, 2 },
                    { 4733, "32gb", null, null, "32GB", 473, 3 },
                    { 4813, "midnight", "#1f2937", null, "Midnight", 481, 1 },
                    { 4814, "silver", "#d1d5db", null, "Silver", 481, 2 },
                    { 4822, "256gb", null, null, "256GB", 482, 1 },
                    { 4823, "512gb", null, null, "512GB", 482, 2 },
                    { 4824, "1tb", null, null, "1TB", 482, 3 },
                    { 4831, "8gb", null, null, "8GB", 483, 1 },
                    { 4832, "16gb", null, null, "16GB", 483, 2 },
                    { 4833, "32gb", null, null, "32GB", 483, 3 },
                    { 4913, "midnight", "#1f2937", null, "Midnight", 491, 1 },
                    { 4914, "silver", "#d1d5db", null, "Silver", 491, 2 },
                    { 4922, "256gb", null, null, "256GB", 492, 1 },
                    { 4923, "512gb", null, null, "512GB", 492, 2 },
                    { 4924, "1tb", null, null, "1TB", 492, 3 },
                    { 4931, "8gb", null, null, "8GB", 493, 1 },
                    { 4932, "16gb", null, null, "16GB", 493, 2 },
                    { 4933, "32gb", null, null, "32GB", 493, 3 },
                    { 5013, "midnight", "#1f2937", null, "Midnight", 501, 1 },
                    { 5014, "silver", "#d1d5db", null, "Silver", 501, 2 },
                    { 5022, "256gb", null, null, "256GB", 502, 1 },
                    { 5023, "512gb", null, null, "512GB", 502, 2 },
                    { 5024, "1tb", null, null, "1TB", 502, 3 },
                    { 5031, "8gb", null, null, "8GB", 503, 1 },
                    { 5032, "16gb", null, null, "16GB", 503, 2 },
                    { 5033, "32gb", null, null, "32GB", 503, 3 },
                    { 6011, "black", "#111827", null, "Black", 601, 1 },
                    { 6014, "silver", "#d1d5db", null, "Silver", 601, 2 },
                    { 6041, "standard", null, null, "Standard Stand", 604, 1 },
                    { 6042, "height-adjustable", null, null, "Height Adjustable Stand", 604, 2 },
                    { 6613, "midnight", "#1f2937", null, "Midnight", 661, 1 },
                    { 6614, "silver", "#d1d5db", null, "Silver", 661, 2 },
                    { 6622, "256gb", null, null, "256GB", 662, 1 },
                    { 6623, "512gb", null, null, "512GB", 662, 2 },
                    { 6624, "1tb", null, null, "1TB", 662, 3 },
                    { 6631, "8gb", null, null, "8GB", 663, 1 },
                    { 6632, "16gb", null, null, "16GB", 663, 2 },
                    { 6633, "32gb", null, null, "32GB", 663, 3 },
                    { 6713, "midnight", "#1f2937", null, "Midnight", 671, 1 },
                    { 6714, "silver", "#d1d5db", null, "Silver", 671, 2 },
                    { 6722, "256gb", null, null, "256GB", 672, 1 },
                    { 6723, "512gb", null, null, "512GB", 672, 2 },
                    { 6724, "1tb", null, null, "1TB", 672, 3 },
                    { 6731, "8gb", null, null, "8GB", 673, 1 },
                    { 6732, "16gb", null, null, "16GB", 673, 2 },
                    { 6733, "32gb", null, null, "32GB", 673, 3 },
                    { 6813, "midnight", "#1f2937", null, "Midnight", 681, 1 },
                    { 6814, "silver", "#d1d5db", null, "Silver", 681, 2 },
                    { 6822, "256gb", null, null, "256GB", 682, 1 },
                    { 6823, "512gb", null, null, "512GB", 682, 2 },
                    { 6824, "1tb", null, null, "1TB", 682, 3 },
                    { 6831, "8gb", null, null, "8GB", 683, 1 },
                    { 6832, "16gb", null, null, "16GB", 683, 2 },
                    { 6833, "32gb", null, null, "32GB", 683, 3 },
                    { 6913, "midnight", "#1f2937", null, "Midnight", 691, 1 },
                    { 6914, "silver", "#d1d5db", null, "Silver", 691, 2 },
                    { 6922, "256gb", null, null, "256GB", 692, 1 },
                    { 6923, "512gb", null, null, "512GB", 692, 2 },
                    { 6924, "1tb", null, null, "1TB", 692, 3 },
                    { 6931, "8gb", null, null, "8GB", 693, 1 },
                    { 6932, "16gb", null, null, "16GB", 693, 2 },
                    { 6933, "32gb", null, null, "32GB", 693, 3 },
                    { 7013, "midnight", "#1f2937", null, "Midnight", 701, 1 },
                    { 7014, "silver", "#d1d5db", null, "Silver", 701, 2 },
                    { 7022, "256gb", null, null, "256GB", 702, 1 },
                    { 7023, "512gb", null, null, "512GB", 702, 2 },
                    { 7024, "1tb", null, null, "1TB", 702, 3 },
                    { 7031, "8gb", null, null, "8GB", 703, 1 },
                    { 7032, "16gb", null, null, "16GB", 703, 2 },
                    { 7033, "32gb", null, null, "32GB", 703, 3 },
                    { 8011, "black", "#111827", null, "Black", 801, 1 },
                    { 8014, "silver", "#d1d5db", null, "Silver", 801, 2 },
                    { 8041, "standard", null, null, "Standard Stand", 804, 1 },
                    { 8042, "height-adjustable", null, null, "Height Adjustable Stand", 804, 2 },
                    { 8111, "black", "#111827", null, "Black", 811, 1 },
                    { 8114, "silver", "#d1d5db", null, "Silver", 811, 2 },
                    { 8141, "standard", null, null, "Standard Stand", 814, 1 },
                    { 8142, "height-adjustable", null, null, "Height Adjustable Stand", 814, 2 },
                    { 8211, "black", "#111827", null, "Black", 821, 1 },
                    { 8214, "silver", "#d1d5db", null, "Silver", 821, 2 },
                    { 8241, "standard", null, null, "Standard Stand", 824, 1 },
                    { 8242, "height-adjustable", null, null, "Height Adjustable Stand", 824, 2 },
                    { 8311, "black", "#111827", null, "Black", 831, 1 },
                    { 8314, "silver", "#d1d5db", null, "Silver", 831, 2 },
                    { 8341, "standard", null, null, "Standard Stand", 834, 1 },
                    { 8342, "height-adjustable", null, null, "Height Adjustable Stand", 834, 2 },
                    { 8411, "black", "#111827", null, "Black", 841, 1 },
                    { 8414, "silver", "#d1d5db", null, "Silver", 841, 2 },
                    { 8441, "standard", null, null, "Standard Stand", 844, 1 },
                    { 8442, "height-adjustable", null, null, "Height Adjustable Stand", 844, 2 },
                    { 8511, "black", "#111827", null, "Black", 851, 1 },
                    { 8514, "silver", "#d1d5db", null, "Silver", 851, 2 },
                    { 8541, "standard", null, null, "Standard Stand", 854, 1 },
                    { 8542, "height-adjustable", null, null, "Height Adjustable Stand", 854, 2 },
                    { 8611, "black", "#111827", null, "Black", 861, 1 },
                    { 8614, "silver", "#d1d5db", null, "Silver", 861, 2 },
                    { 8641, "standard", null, null, "Standard Stand", 864, 1 },
                    { 8642, "height-adjustable", null, null, "Height Adjustable Stand", 864, 2 },
                    { 8711, "black", "#111827", null, "Black", 871, 1 },
                    { 8714, "silver", "#d1d5db", null, "Silver", 871, 2 },
                    { 8741, "standard", null, null, "Standard Stand", 874, 1 },
                    { 8742, "height-adjustable", null, null, "Height Adjustable Stand", 874, 2 },
                    { 8811, "black", "#111827", null, "Black", 881, 1 },
                    { 8814, "silver", "#d1d5db", null, "Silver", 881, 2 },
                    { 8841, "standard", null, null, "Standard Stand", 884, 1 },
                    { 8842, "height-adjustable", null, null, "Height Adjustable Stand", 884, 2 },
                    { 8911, "black", "#111827", null, "Black", 891, 1 },
                    { 8914, "silver", "#d1d5db", null, "Silver", 891, 2 },
                    { 8941, "standard", null, null, "Standard Stand", 894, 1 },
                    { 8942, "height-adjustable", null, null, "Height Adjustable Stand", 894, 2 },
                    { 9011, "black", "#111827", null, "Black", 901, 1 },
                    { 9014, "silver", "#d1d5db", null, "Silver", 901, 2 },
                    { 9041, "standard", null, null, "Standard Stand", 904, 1 },
                    { 9042, "height-adjustable", null, null, "Height Adjustable Stand", 904, 2 },
                    { 9111, "black", "#111827", null, "Black", 911, 1 },
                    { 9114, "silver", "#d1d5db", null, "Silver", 911, 2 },
                    { 9141, "standard", null, null, "Standard Stand", 914, 1 },
                    { 9142, "height-adjustable", null, null, "Height Adjustable Stand", 914, 2 },
                    { 9211, "black", "#111827", null, "Black", 921, 1 },
                    { 9214, "silver", "#d1d5db", null, "Silver", 921, 2 },
                    { 9241, "standard", null, null, "Standard Stand", 924, 1 },
                    { 9242, "height-adjustable", null, null, "Height Adjustable Stand", 924, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantOptions",
                columns: new[] { "Id", "ProductOptionId", "ProductVariantId" },
                values: new object[,]
                {
                    { 6011, 613, 601 },
                    { 6012, 631, 601 },
                    { 6013, 622, 601 },
                    { 6021, 613, 602 },
                    { 6022, 632, 602 },
                    { 6023, 623, 602 },
                    { 6031, 613, 603 },
                    { 6032, 633, 603 },
                    { 6033, 624, 603 },
                    { 6041, 614, 604 },
                    { 6042, 631, 604 },
                    { 6043, 622, 604 },
                    { 6051, 614, 605 },
                    { 6052, 632, 605 },
                    { 6053, 623, 605 },
                    { 6061, 614, 606 },
                    { 6062, 633, 606 },
                    { 6063, 624, 606 },
                    { 7011, 713, 701 },
                    { 7012, 731, 701 },
                    { 7013, 722, 701 },
                    { 7021, 713, 702 },
                    { 7022, 732, 702 },
                    { 7023, 723, 702 },
                    { 7031, 713, 703 },
                    { 7032, 733, 703 },
                    { 7033, 724, 703 },
                    { 7041, 714, 704 },
                    { 7042, 731, 704 },
                    { 7043, 722, 704 },
                    { 7051, 714, 705 },
                    { 7052, 732, 705 },
                    { 7053, 723, 705 },
                    { 7061, 714, 706 },
                    { 7062, 733, 706 },
                    { 7063, 724, 706 },
                    { 8011, 813, 801 },
                    { 8012, 831, 801 },
                    { 8013, 822, 801 },
                    { 8021, 813, 802 },
                    { 8022, 832, 802 },
                    { 8023, 823, 802 },
                    { 8031, 813, 803 },
                    { 8032, 833, 803 },
                    { 8033, 824, 803 },
                    { 8041, 814, 804 },
                    { 8042, 831, 804 },
                    { 8043, 822, 804 },
                    { 8051, 814, 805 },
                    { 8052, 832, 805 },
                    { 8053, 823, 805 },
                    { 8061, 814, 806 },
                    { 8062, 833, 806 },
                    { 8063, 824, 806 },
                    { 9011, 913, 901 },
                    { 9012, 931, 901 },
                    { 9013, 922, 901 },
                    { 9021, 913, 902 },
                    { 9022, 932, 902 },
                    { 9023, 923, 902 },
                    { 9031, 913, 903 },
                    { 9032, 933, 903 },
                    { 9033, 924, 903 },
                    { 9041, 914, 904 },
                    { 9042, 931, 904 },
                    { 9043, 922, 904 },
                    { 9051, 914, 905 },
                    { 9052, 932, 905 },
                    { 9053, 923, 905 },
                    { 9061, 914, 906 },
                    { 9062, 933, 906 },
                    { 9063, 924, 906 },
                    { 10011, 1013, 1001 },
                    { 10012, 1031, 1001 },
                    { 10013, 1022, 1001 },
                    { 10021, 1013, 1002 },
                    { 10022, 1032, 1002 },
                    { 10023, 1023, 1002 },
                    { 10031, 1013, 1003 },
                    { 10032, 1033, 1003 },
                    { 10033, 1024, 1003 },
                    { 10041, 1014, 1004 },
                    { 10042, 1031, 1004 },
                    { 10043, 1022, 1004 },
                    { 10051, 1014, 1005 },
                    { 10052, 1032, 1005 },
                    { 10053, 1023, 1005 },
                    { 10061, 1014, 1006 },
                    { 10062, 1033, 1006 },
                    { 10063, 1024, 1006 },
                    { 20011, 2011, 2001 },
                    { 20012, 2041, 2001 },
                    { 20021, 2011, 2002 },
                    { 20022, 2042, 2002 },
                    { 20031, 2014, 2003 },
                    { 20032, 2041, 2003 },
                    { 20041, 2014, 2004 },
                    { 20042, 2042, 2004 },
                    { 26011, 2613, 2601 },
                    { 26012, 2631, 2601 },
                    { 26013, 2622, 2601 },
                    { 26021, 2613, 2602 },
                    { 26022, 2632, 2602 },
                    { 26023, 2623, 2602 },
                    { 26031, 2613, 2603 },
                    { 26032, 2633, 2603 },
                    { 26033, 2624, 2603 },
                    { 26041, 2614, 2604 },
                    { 26042, 2631, 2604 },
                    { 26043, 2622, 2604 },
                    { 26051, 2614, 2605 },
                    { 26052, 2632, 2605 },
                    { 26053, 2623, 2605 },
                    { 26061, 2614, 2606 },
                    { 26062, 2633, 2606 },
                    { 26063, 2624, 2606 },
                    { 27011, 2713, 2701 },
                    { 27012, 2731, 2701 },
                    { 27013, 2722, 2701 },
                    { 27021, 2713, 2702 },
                    { 27022, 2732, 2702 },
                    { 27023, 2723, 2702 },
                    { 27031, 2713, 2703 },
                    { 27032, 2733, 2703 },
                    { 27033, 2724, 2703 },
                    { 27041, 2714, 2704 },
                    { 27042, 2731, 2704 },
                    { 27043, 2722, 2704 },
                    { 27051, 2714, 2705 },
                    { 27052, 2732, 2705 },
                    { 27053, 2723, 2705 },
                    { 27061, 2714, 2706 },
                    { 27062, 2733, 2706 },
                    { 27063, 2724, 2706 },
                    { 28011, 2813, 2801 },
                    { 28012, 2831, 2801 },
                    { 28013, 2822, 2801 },
                    { 28021, 2813, 2802 },
                    { 28022, 2832, 2802 },
                    { 28023, 2823, 2802 },
                    { 28031, 2813, 2803 },
                    { 28032, 2833, 2803 },
                    { 28033, 2824, 2803 },
                    { 28041, 2814, 2804 },
                    { 28042, 2831, 2804 },
                    { 28043, 2822, 2804 },
                    { 28051, 2814, 2805 },
                    { 28052, 2832, 2805 },
                    { 28053, 2823, 2805 },
                    { 28061, 2814, 2806 },
                    { 28062, 2833, 2806 },
                    { 28063, 2824, 2806 },
                    { 29011, 2913, 2901 },
                    { 29012, 2931, 2901 },
                    { 29013, 2922, 2901 },
                    { 29021, 2913, 2902 },
                    { 29022, 2932, 2902 },
                    { 29023, 2923, 2902 },
                    { 29031, 2913, 2903 },
                    { 29032, 2933, 2903 },
                    { 29033, 2924, 2903 },
                    { 29041, 2914, 2904 },
                    { 29042, 2931, 2904 },
                    { 29043, 2922, 2904 },
                    { 29051, 2914, 2905 },
                    { 29052, 2932, 2905 },
                    { 29053, 2923, 2905 },
                    { 29061, 2914, 2906 },
                    { 29062, 2933, 2906 },
                    { 29063, 2924, 2906 },
                    { 30011, 3013, 3001 },
                    { 30012, 3031, 3001 },
                    { 30013, 3022, 3001 },
                    { 30021, 3013, 3002 },
                    { 30022, 3032, 3002 },
                    { 30023, 3023, 3002 },
                    { 30031, 3013, 3003 },
                    { 30032, 3033, 3003 },
                    { 30033, 3024, 3003 },
                    { 30041, 3014, 3004 },
                    { 30042, 3031, 3004 },
                    { 30043, 3022, 3004 },
                    { 30051, 3014, 3005 },
                    { 30052, 3032, 3005 },
                    { 30053, 3023, 3005 },
                    { 30061, 3014, 3006 },
                    { 30062, 3033, 3006 },
                    { 30063, 3024, 3006 },
                    { 40011, 4011, 4001 },
                    { 40012, 4041, 4001 },
                    { 40021, 4011, 4002 },
                    { 40022, 4042, 4002 },
                    { 40031, 4014, 4003 },
                    { 40032, 4041, 4003 },
                    { 40041, 4014, 4004 },
                    { 40042, 4042, 4004 },
                    { 46011, 4613, 4601 },
                    { 46012, 4631, 4601 },
                    { 46013, 4622, 4601 },
                    { 46021, 4613, 4602 },
                    { 46022, 4632, 4602 },
                    { 46023, 4623, 4602 },
                    { 46031, 4613, 4603 },
                    { 46032, 4633, 4603 },
                    { 46033, 4624, 4603 },
                    { 46041, 4614, 4604 },
                    { 46042, 4631, 4604 },
                    { 46043, 4622, 4604 },
                    { 46051, 4614, 4605 },
                    { 46052, 4632, 4605 },
                    { 46053, 4623, 4605 },
                    { 46061, 4614, 4606 },
                    { 46062, 4633, 4606 },
                    { 46063, 4624, 4606 },
                    { 47011, 4713, 4701 },
                    { 47012, 4731, 4701 },
                    { 47013, 4722, 4701 },
                    { 47021, 4713, 4702 },
                    { 47022, 4732, 4702 },
                    { 47023, 4723, 4702 },
                    { 47031, 4713, 4703 },
                    { 47032, 4733, 4703 },
                    { 47033, 4724, 4703 },
                    { 47041, 4714, 4704 },
                    { 47042, 4731, 4704 },
                    { 47043, 4722, 4704 },
                    { 47051, 4714, 4705 },
                    { 47052, 4732, 4705 },
                    { 47053, 4723, 4705 },
                    { 47061, 4714, 4706 },
                    { 47062, 4733, 4706 },
                    { 47063, 4724, 4706 },
                    { 48011, 4813, 4801 },
                    { 48012, 4831, 4801 },
                    { 48013, 4822, 4801 },
                    { 48021, 4813, 4802 },
                    { 48022, 4832, 4802 },
                    { 48023, 4823, 4802 },
                    { 48031, 4813, 4803 },
                    { 48032, 4833, 4803 },
                    { 48033, 4824, 4803 },
                    { 48041, 4814, 4804 },
                    { 48042, 4831, 4804 },
                    { 48043, 4822, 4804 },
                    { 48051, 4814, 4805 },
                    { 48052, 4832, 4805 },
                    { 48053, 4823, 4805 },
                    { 48061, 4814, 4806 },
                    { 48062, 4833, 4806 },
                    { 48063, 4824, 4806 },
                    { 49011, 4913, 4901 },
                    { 49012, 4931, 4901 },
                    { 49013, 4922, 4901 },
                    { 49021, 4913, 4902 },
                    { 49022, 4932, 4902 },
                    { 49023, 4923, 4902 },
                    { 49031, 4913, 4903 },
                    { 49032, 4933, 4903 },
                    { 49033, 4924, 4903 },
                    { 49041, 4914, 4904 },
                    { 49042, 4931, 4904 },
                    { 49043, 4922, 4904 },
                    { 49051, 4914, 4905 },
                    { 49052, 4932, 4905 },
                    { 49053, 4923, 4905 },
                    { 49061, 4914, 4906 },
                    { 49062, 4933, 4906 },
                    { 49063, 4924, 4906 },
                    { 50011, 5013, 5001 },
                    { 50012, 5031, 5001 },
                    { 50013, 5022, 5001 },
                    { 50021, 5013, 5002 },
                    { 50022, 5032, 5002 },
                    { 50023, 5023, 5002 },
                    { 50031, 5013, 5003 },
                    { 50032, 5033, 5003 },
                    { 50033, 5024, 5003 },
                    { 50041, 5014, 5004 },
                    { 50042, 5031, 5004 },
                    { 50043, 5022, 5004 },
                    { 50051, 5014, 5005 },
                    { 50052, 5032, 5005 },
                    { 50053, 5023, 5005 },
                    { 50061, 5014, 5006 },
                    { 50062, 5033, 5006 },
                    { 50063, 5024, 5006 },
                    { 60011, 6011, 6001 },
                    { 60012, 6041, 6001 },
                    { 60021, 6011, 6002 },
                    { 60022, 6042, 6002 },
                    { 60031, 6014, 6003 },
                    { 60032, 6041, 6003 },
                    { 60041, 6014, 6004 },
                    { 60042, 6042, 6004 },
                    { 66011, 6613, 6601 },
                    { 66012, 6631, 6601 },
                    { 66013, 6622, 6601 },
                    { 66021, 6613, 6602 },
                    { 66022, 6632, 6602 },
                    { 66023, 6623, 6602 },
                    { 66031, 6613, 6603 },
                    { 66032, 6633, 6603 },
                    { 66033, 6624, 6603 },
                    { 66041, 6614, 6604 },
                    { 66042, 6631, 6604 },
                    { 66043, 6622, 6604 },
                    { 66051, 6614, 6605 },
                    { 66052, 6632, 6605 },
                    { 66053, 6623, 6605 },
                    { 66061, 6614, 6606 },
                    { 66062, 6633, 6606 },
                    { 66063, 6624, 6606 },
                    { 67011, 6713, 6701 },
                    { 67012, 6731, 6701 },
                    { 67013, 6722, 6701 },
                    { 67021, 6713, 6702 },
                    { 67022, 6732, 6702 },
                    { 67023, 6723, 6702 },
                    { 67031, 6713, 6703 },
                    { 67032, 6733, 6703 },
                    { 67033, 6724, 6703 },
                    { 67041, 6714, 6704 },
                    { 67042, 6731, 6704 },
                    { 67043, 6722, 6704 },
                    { 67051, 6714, 6705 },
                    { 67052, 6732, 6705 },
                    { 67053, 6723, 6705 },
                    { 67061, 6714, 6706 },
                    { 67062, 6733, 6706 },
                    { 67063, 6724, 6706 },
                    { 68011, 6813, 6801 },
                    { 68012, 6831, 6801 },
                    { 68013, 6822, 6801 },
                    { 68021, 6813, 6802 },
                    { 68022, 6832, 6802 },
                    { 68023, 6823, 6802 },
                    { 68031, 6813, 6803 },
                    { 68032, 6833, 6803 },
                    { 68033, 6824, 6803 },
                    { 68041, 6814, 6804 },
                    { 68042, 6831, 6804 },
                    { 68043, 6822, 6804 },
                    { 68051, 6814, 6805 },
                    { 68052, 6832, 6805 },
                    { 68053, 6823, 6805 },
                    { 68061, 6814, 6806 },
                    { 68062, 6833, 6806 },
                    { 68063, 6824, 6806 },
                    { 69011, 6913, 6901 },
                    { 69012, 6931, 6901 },
                    { 69013, 6922, 6901 },
                    { 69021, 6913, 6902 },
                    { 69022, 6932, 6902 },
                    { 69023, 6923, 6902 },
                    { 69031, 6913, 6903 },
                    { 69032, 6933, 6903 },
                    { 69033, 6924, 6903 },
                    { 69041, 6914, 6904 },
                    { 69042, 6931, 6904 },
                    { 69043, 6922, 6904 },
                    { 69051, 6914, 6905 },
                    { 69052, 6932, 6905 },
                    { 69053, 6923, 6905 },
                    { 69061, 6914, 6906 },
                    { 69062, 6933, 6906 },
                    { 69063, 6924, 6906 },
                    { 70011, 7013, 7001 },
                    { 70012, 7031, 7001 },
                    { 70013, 7022, 7001 },
                    { 70021, 7013, 7002 },
                    { 70022, 7032, 7002 },
                    { 70023, 7023, 7002 },
                    { 70031, 7013, 7003 },
                    { 70032, 7033, 7003 },
                    { 70033, 7024, 7003 },
                    { 70041, 7014, 7004 },
                    { 70042, 7031, 7004 },
                    { 70043, 7022, 7004 },
                    { 70051, 7014, 7005 },
                    { 70052, 7032, 7005 },
                    { 70053, 7023, 7005 },
                    { 70061, 7014, 7006 },
                    { 70062, 7033, 7006 },
                    { 70063, 7024, 7006 },
                    { 80011, 8011, 8001 },
                    { 80012, 8041, 8001 },
                    { 80021, 8011, 8002 },
                    { 80022, 8042, 8002 },
                    { 80031, 8014, 8003 },
                    { 80032, 8041, 8003 },
                    { 80041, 8014, 8004 },
                    { 80042, 8042, 8004 },
                    { 81011, 8111, 8101 },
                    { 81012, 8141, 8101 },
                    { 81021, 8111, 8102 },
                    { 81022, 8142, 8102 },
                    { 81031, 8114, 8103 },
                    { 81032, 8141, 8103 },
                    { 81041, 8114, 8104 },
                    { 81042, 8142, 8104 },
                    { 82011, 8211, 8201 },
                    { 82012, 8241, 8201 },
                    { 82021, 8211, 8202 },
                    { 82022, 8242, 8202 },
                    { 82031, 8214, 8203 },
                    { 82032, 8241, 8203 },
                    { 82041, 8214, 8204 },
                    { 82042, 8242, 8204 },
                    { 83011, 8311, 8301 },
                    { 83012, 8341, 8301 },
                    { 83021, 8311, 8302 },
                    { 83022, 8342, 8302 },
                    { 83031, 8314, 8303 },
                    { 83032, 8341, 8303 },
                    { 83041, 8314, 8304 },
                    { 83042, 8342, 8304 },
                    { 84011, 8411, 8401 },
                    { 84012, 8441, 8401 },
                    { 84021, 8411, 8402 },
                    { 84022, 8442, 8402 },
                    { 84031, 8414, 8403 },
                    { 84032, 8441, 8403 },
                    { 84041, 8414, 8404 },
                    { 84042, 8442, 8404 },
                    { 85011, 8511, 8501 },
                    { 85012, 8541, 8501 },
                    { 85021, 8511, 8502 },
                    { 85022, 8542, 8502 },
                    { 85031, 8514, 8503 },
                    { 85032, 8541, 8503 },
                    { 85041, 8514, 8504 },
                    { 85042, 8542, 8504 },
                    { 86011, 8611, 8601 },
                    { 86012, 8641, 8601 },
                    { 86021, 8611, 8602 },
                    { 86022, 8642, 8602 },
                    { 86031, 8614, 8603 },
                    { 86032, 8641, 8603 },
                    { 86041, 8614, 8604 },
                    { 86042, 8642, 8604 },
                    { 87011, 8711, 8701 },
                    { 87012, 8741, 8701 },
                    { 87021, 8711, 8702 },
                    { 87022, 8742, 8702 },
                    { 87031, 8714, 8703 },
                    { 87032, 8741, 8703 },
                    { 87041, 8714, 8704 },
                    { 87042, 8742, 8704 },
                    { 88011, 8811, 8801 },
                    { 88012, 8841, 8801 },
                    { 88021, 8811, 8802 },
                    { 88022, 8842, 8802 },
                    { 88031, 8814, 8803 },
                    { 88032, 8841, 8803 },
                    { 88041, 8814, 8804 },
                    { 88042, 8842, 8804 },
                    { 89011, 8911, 8901 },
                    { 89012, 8941, 8901 },
                    { 89021, 8911, 8902 },
                    { 89022, 8942, 8902 },
                    { 89031, 8914, 8903 },
                    { 89032, 8941, 8903 },
                    { 89041, 8914, 8904 },
                    { 89042, 8942, 8904 },
                    { 90011, 9011, 9001 },
                    { 90012, 9041, 9001 },
                    { 90021, 9011, 9002 },
                    { 90022, 9042, 9002 },
                    { 90031, 9014, 9003 },
                    { 90032, 9041, 9003 },
                    { 90041, 9014, 9004 },
                    { 90042, 9042, 9004 },
                    { 91011, 9111, 9101 },
                    { 91012, 9141, 9101 },
                    { 91021, 9111, 9102 },
                    { 91022, 9142, 9102 },
                    { 91031, 9114, 9103 },
                    { 91032, 9141, 9103 },
                    { 91041, 9114, 9104 },
                    { 91042, 9142, 9104 },
                    { 92011, 9211, 9201 },
                    { 92012, 9241, 9201 },
                    { 92021, 9211, 9202 },
                    { 92022, 9242, 9202 },
                    { 92031, 9214, 9203 },
                    { 92032, 9241, 9203 },
                    { 92041, 9214, 9204 },
                    { 92042, 9242, 9204 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 6011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 6012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 6013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 6021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 6022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 6023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 6031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 6032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 6033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 6041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 6042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 6043);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 6051);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 6052);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 6053);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 6061);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 6062);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 6063);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 7011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 7012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 7013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 7021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 7022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 7023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 7031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 7032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 7033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 7041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 7042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 7043);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 7051);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 7052);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 7053);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 7061);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 7062);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 7063);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 8011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 8012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 8013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 8021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 8022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 8023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 8031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 8032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 8033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 8041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 8042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 8043);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 8051);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 8052);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 8053);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 8061);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 8062);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 8063);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 9011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 9012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 9013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 9021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 9022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 9023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 9031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 9032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 9033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 9041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 9042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 9043);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 9051);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 9052);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 9053);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 9061);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 9062);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 9063);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 10011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 10012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 10013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 10021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 10022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 10023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 10031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 10032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 10033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 10041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 10042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 10043);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 10051);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 10052);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 10053);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 10061);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 10062);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 10063);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 20011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 20012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 20021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 20022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 20031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 20032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 20041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 20042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 26011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 26012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 26013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 26021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 26022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 26023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 26031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 26032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 26033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 26041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 26042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 26043);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 26051);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 26052);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 26053);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 26061);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 26062);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 26063);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 27011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 27012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 27013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 27021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 27022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 27023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 27031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 27032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 27033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 27041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 27042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 27043);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 27051);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 27052);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 27053);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 27061);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 27062);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 27063);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 28011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 28012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 28013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 28021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 28022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 28023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 28031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 28032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 28033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 28041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 28042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 28043);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 28051);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 28052);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 28053);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 28061);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 28062);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 28063);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 29011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 29012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 29013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 29021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 29022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 29023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 29031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 29032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 29033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 29041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 29042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 29043);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 29051);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 29052);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 29053);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 29061);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 29062);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 29063);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 30011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 30012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 30013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 30021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 30022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 30023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 30031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 30032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 30033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 30041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 30042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 30043);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 30051);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 30052);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 30053);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 30061);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 30062);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 30063);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 40011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 40012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 40021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 40022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 40031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 40032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 40041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 40042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 46011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 46012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 46013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 46021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 46022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 46023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 46031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 46032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 46033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 46041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 46042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 46043);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 46051);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 46052);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 46053);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 46061);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 46062);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 46063);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 47011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 47012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 47013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 47021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 47022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 47023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 47031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 47032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 47033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 47041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 47042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 47043);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 47051);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 47052);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 47053);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 47061);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 47062);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 47063);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 48011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 48012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 48013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 48021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 48022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 48023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 48031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 48032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 48033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 48041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 48042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 48043);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 48051);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 48052);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 48053);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 48061);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 48062);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 48063);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 49011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 49012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 49013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 49021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 49022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 49023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 49031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 49032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 49033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 49041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 49042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 49043);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 49051);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 49052);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 49053);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 49061);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 49062);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 49063);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 50011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 50012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 50013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 50021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 50022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 50023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 50031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 50032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 50033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 50041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 50042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 50043);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 50051);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 50052);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 50053);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 50061);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 50062);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 50063);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 60011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 60012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 60021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 60022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 60031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 60032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 60041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 60042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 66011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 66012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 66013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 66021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 66022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 66023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 66031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 66032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 66033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 66041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 66042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 66043);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 66051);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 66052);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 66053);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 66061);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 66062);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 66063);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 67011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 67012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 67013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 67021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 67022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 67023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 67031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 67032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 67033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 67041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 67042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 67043);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 67051);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 67052);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 67053);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 67061);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 67062);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 67063);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 68011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 68012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 68013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 68021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 68022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 68023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 68031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 68032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 68033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 68041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 68042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 68043);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 68051);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 68052);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 68053);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 68061);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 68062);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 68063);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 69011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 69012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 69013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 69021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 69022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 69023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 69031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 69032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 69033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 69041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 69042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 69043);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 69051);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 69052);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 69053);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 69061);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 69062);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 69063);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 70011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 70012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 70013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 70021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 70022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 70023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 70031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 70032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 70033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 70041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 70042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 70043);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 70051);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 70052);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 70053);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 70061);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 70062);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 70063);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 80011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 80012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 80021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 80022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 80031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 80032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 80041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 80042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 81011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 81012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 81021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 81022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 81031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 81032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 81041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 81042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 82011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 82012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 82021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 82022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 82031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 82032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 82041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 82042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 83011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 83012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 83021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 83022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 83031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 83032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 83041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 83042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 84011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 84012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 84021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 84022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 84031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 84032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 84041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 84042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 85011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 85012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 85021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 85022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 85031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 85032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 85041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 85042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 86011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 86012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 86021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 86022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 86031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 86032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 86041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 86042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 87011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 87012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 87021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 87022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 87031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 87032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 87041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 87042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 88011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 88012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 88021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 88022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 88031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 88032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 88041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 88042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 89011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 89012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 89021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 89022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 89031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 89032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 89041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 89042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 90011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 90012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 90021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 90022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 90031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 90032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 90041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 90042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 91011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 91012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 91021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 91022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 91031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 91032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 91041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 91042);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 92011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 92012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 92021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 92022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 92031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 92032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 92041);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 92042);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2011);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2014);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2041);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2042);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2613);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2614);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2622);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2623);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2624);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2631);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2632);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2633);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2713);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2714);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2722);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2723);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2724);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2731);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2732);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2733);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2813);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2814);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2822);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2823);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2824);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2831);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2832);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2833);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2913);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2914);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2922);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2923);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2924);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2931);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2932);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2933);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3013);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3014);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3022);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3023);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3024);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3031);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3032);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3033);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4011);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4014);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4041);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4042);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4613);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4614);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4622);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4623);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4624);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4631);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4632);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4633);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4713);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4714);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4722);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4723);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4724);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4731);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4732);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4733);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4813);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4814);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4822);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4823);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4824);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4831);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4832);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4833);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4913);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4914);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4922);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4923);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4924);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4931);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4932);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 4933);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5013);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5014);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5022);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5023);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5024);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5031);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5032);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5033);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6011);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6014);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6041);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6042);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6613);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6614);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6622);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6623);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6624);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6631);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6632);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6633);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6713);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6714);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6722);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6723);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6724);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6731);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6732);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6733);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6813);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6814);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6822);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6823);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6824);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6831);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6832);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6833);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6913);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6914);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6922);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6923);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6924);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6931);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6932);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 6933);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7013);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7014);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7022);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7023);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7024);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7031);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7032);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7033);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8011);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8014);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8041);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8042);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8111);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8114);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8141);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8142);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8211);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8214);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8241);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8242);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8311);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8314);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8341);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8342);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8411);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8414);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8441);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8442);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8511);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8514);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8541);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8542);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8611);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8614);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8641);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8642);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8711);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8714);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8741);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8742);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8811);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8814);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8841);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8842);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8911);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8914);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8941);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 8942);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 9011);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 9014);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 9041);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 9042);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 9111);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 9114);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 9141);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 9142);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 9211);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 9214);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 9241);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 9242);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2001);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2002);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2003);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2004);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2601);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2602);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2603);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2604);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2605);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2606);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2701);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2702);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2703);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2704);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2705);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2706);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2801);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2802);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2803);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2804);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2805);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2806);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2901);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2902);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2903);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2904);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2905);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2906);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3001);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3002);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3003);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3004);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3005);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3006);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4001);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4002);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4003);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4004);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4601);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4602);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4603);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4604);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4605);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4606);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4701);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4702);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4703);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4704);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4705);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4706);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4801);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4802);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4803);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4804);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4805);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4806);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4901);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4902);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4903);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4904);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4905);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4906);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5001);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5002);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5003);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5004);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5005);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5006);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6001);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6002);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6003);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6004);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6601);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6602);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6603);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6604);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6605);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6606);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6701);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6702);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6703);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6704);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6705);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6706);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6801);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6802);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6803);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6804);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6805);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6806);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6901);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6902);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6903);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6904);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6905);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6906);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7001);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7002);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7003);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7004);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7005);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7006);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8001);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8002);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8003);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8004);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8101);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8102);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8103);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8104);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8201);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8202);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8203);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8204);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8301);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8302);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8303);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8304);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8401);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8402);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8403);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8404);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8501);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8502);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8503);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8504);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8601);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8602);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8603);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8604);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8701);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8702);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8703);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8704);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8801);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8802);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8803);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8804);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8901);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8902);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8903);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8904);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9001);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9002);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9003);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9004);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9101);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9102);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9103);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9104);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9201);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9202);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9203);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9204);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 924);

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "Id", "ImageUrl", "Price", "ProductId", "Sku", "StockQuantity" },
                values: new object[,]
                {
                    { 600, "", 69999m, 6, "PROD-6-BASE", 7 },
                    { 700, "", 74999m, 7, "PROD-7-BASE", 6 },
                    { 800, "", 89999m, 8, "PROD-8-BASE", 5 },
                    { 900, "", 94999m, 9, "PROD-9-BASE", 4 },
                    { 1000, "", 39999m, 10, "PROD-10-BASE", 11 },
                    { 2000, "", 12999m, 20, "PROD-20-BASE", 10 },
                    { 2600, "", 1999m, 26, "PROD-26-BASE", 5 },
                    { 2700, "", 1499m, 27, "PROD-27-BASE", 7 },
                    { 2800, "", 1599m, 28, "PROD-28-BASE", 6 },
                    { 2900, "", 1199m, 29, "PROD-29-BASE", 9 },
                    { 3000, "", 999m, 30, "PROD-30-BASE", 11 },
                    { 4000, "", 299m, 40, "PROD-40-BASE", 9 },
                    { 4600, "", 9999m, 46, "PROD-46-BASE", 6 },
                    { 4700, "", 5799m, 47, "PROD-47-BASE", 11 },
                    { 4800, "", 6999m, 48, "PROD-48-BASE", 8 },
                    { 4900, "", 4999m, 49, "PROD-49-BASE", 13 },
                    { 5000, "", 7499m, 50, "PROD-50-BASE", 5 },
                    { 6000, "", 1299m, 60, "PROD-60-BASE", 12 },
                    { 6600, "", 249800m, 66, "PROD-66-BASE", 5 },
                    { 6700, "", 289800m, 67, "PROD-67-BASE", 4 },
                    { 6800, "", 164800m, 68, "PROD-68-BASE", 9 },
                    { 6900, "", 179800m, 69, "PROD-69-BASE", 6 },
                    { 7000, "", 198000m, 70, "PROD-70-BASE", 8 },
                    { 8000, "", 44800m, 80, "PROD-80-BASE", 9 },
                    { 8100, "", 7999m, 81, "PROD-81-BASE", 14 },
                    { 8200, "", 179m, 82, "PROD-82-BASE", 10 },
                    { 8300, "", 799m, 83, "PROD-83-BASE", 18 },
                    { 8400, "", 24800m, 84, "PROD-84-BASE", 14 },
                    { 8500, "", 24999m, 85, "PROD-85-BASE", 8 },
                    { 8600, "", 449m, 86, "PROD-86-BASE", 7 },
                    { 8700, "", 2499m, 87, "PROD-87-BASE", 8 },
                    { 8800, "", 69800m, 88, "PROD-88-BASE", 7 },
                    { 8900, "", 27999m, 89, "PROD-89-BASE", 6 },
                    { 9000, "", 549m, 90, "PROD-90-BASE", 6 },
                    { 9100, "", 2999m, 91, "PROD-91-BASE", 6 },
                    { 9200, "", 79800m, 92, "PROD-92-BASE", 6 }
                });
        }
    }
}
