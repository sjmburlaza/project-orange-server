using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectOrangeApi.Migrations
{
    /// <inheritdoc />
    public partial class AddAccessoryOptionGroupsSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductOptionGroups",
                columns: new[] { "Id", "Code", "Label", "ProductId", "SortOrder" },
                values: new object[,]
                {
                    { 111, "color", "Color", 11, 1 },
                    { 115, "connection", "Connection", 11, 2 },
                    { 116, "form-factor", "Layout", 11, 3 },
                    { 117, "switch", "Switch", 11, 4 },
                    { 121, "color", "Color", 12, 1 },
                    { 125, "connection", "Connection", 12, 2 },
                    { 126, "form-factor", "Shape", 12, 3 },
                    { 128, "feature", "Sensitivity", 12, 4 },
                    { 131, "color", "Color", 13, 1 },
                    { 136, "form-factor", "Fit", 13, 2 },
                    { 138, "feature", "Noise Control", 13, 3 },
                    { 141, "color", "Color", 14, 1 },
                    { 145, "connection", "Connection", 14, 2 },
                    { 149, "microphone", "Microphone", 14, 3 },
                    { 151, "color", "Color", 15, 1 },
                    { 155, "connection", "Connection", 15, 2 },
                    { 158, "feature", "Noise Control", 15, 3 },
                    { 161, "color", "Color", 16, 1 },
                    { 165, "connection", "Connection", 16, 2 },
                    { 166, "form-factor", "Layout", 16, 3 },
                    { 167, "switch", "Switch", 16, 4 },
                    { 171, "color", "Color", 17, 1 },
                    { 175, "connection", "Connection", 17, 2 },
                    { 176, "form-factor", "Shape", 17, 3 },
                    { 178, "feature", "Sensitivity", 17, 4 },
                    { 181, "color", "Color", 18, 1 },
                    { 186, "form-factor", "Fit", 18, 2 },
                    { 188, "feature", "Noise Control", 18, 3 },
                    { 191, "color", "Color", 19, 1 },
                    { 195, "connection", "Connection", 19, 2 },
                    { 199, "microphone", "Microphone", 19, 3 },
                    { 311, "color", "Color", 31, 1 },
                    { 315, "connection", "Connection", 31, 2 },
                    { 316, "form-factor", "Layout", 31, 3 },
                    { 317, "switch", "Switch", 31, 4 },
                    { 321, "color", "Color", 32, 1 },
                    { 325, "connection", "Connection", 32, 2 },
                    { 326, "form-factor", "Shape", 32, 3 },
                    { 328, "feature", "Sensitivity", 32, 4 },
                    { 331, "color", "Color", 33, 1 },
                    { 336, "form-factor", "Fit", 33, 2 },
                    { 338, "feature", "Noise Control", 33, 3 },
                    { 341, "color", "Color", 34, 1 },
                    { 345, "connection", "Connection", 34, 2 },
                    { 348, "feature", "Noise Control", 34, 3 },
                    { 351, "color", "Color", 35, 1 },
                    { 355, "connection", "Connection", 35, 2 },
                    { 359, "microphone", "Microphone", 35, 3 },
                    { 361, "color", "Color", 36, 1 },
                    { 365, "connection", "Connection", 36, 2 },
                    { 366, "form-factor", "Layout", 36, 3 },
                    { 367, "switch", "Switch", 36, 4 },
                    { 371, "color", "Color", 37, 1 },
                    { 375, "connection", "Connection", 37, 2 },
                    { 376, "form-factor", "Shape", 37, 3 },
                    { 378, "feature", "Sensitivity", 37, 4 },
                    { 381, "color", "Color", 38, 1 },
                    { 386, "form-factor", "Fit", 38, 2 },
                    { 388, "feature", "Noise Control", 38, 3 },
                    { 391, "color", "Color", 39, 1 },
                    { 395, "connection", "Connection", 39, 2 },
                    { 399, "microphone", "Microphone", 39, 3 },
                    { 511, "color", "Color", 51, 1 },
                    { 515, "connection", "Connection", 51, 2 },
                    { 516, "form-factor", "Layout", 51, 3 },
                    { 517, "switch", "Switch", 51, 4 },
                    { 521, "color", "Color", 52, 1 },
                    { 525, "connection", "Connection", 52, 2 },
                    { 526, "form-factor", "Shape", 52, 3 },
                    { 528, "feature", "Sensitivity", 52, 4 },
                    { 531, "color", "Color", 53, 1 },
                    { 536, "form-factor", "Fit", 53, 2 },
                    { 538, "feature", "Noise Control", 53, 3 },
                    { 541, "color", "Color", 54, 1 },
                    { 545, "connection", "Connection", 54, 2 },
                    { 548, "feature", "Noise Control", 54, 3 },
                    { 551, "color", "Color", 55, 1 },
                    { 555, "connection", "Connection", 55, 2 },
                    { 559, "microphone", "Microphone", 55, 3 },
                    { 561, "color", "Color", 56, 1 },
                    { 565, "connection", "Connection", 56, 2 },
                    { 566, "form-factor", "Layout", 56, 3 },
                    { 567, "switch", "Switch", 56, 4 },
                    { 571, "color", "Color", 57, 1 },
                    { 575, "connection", "Connection", 57, 2 },
                    { 576, "form-factor", "Shape", 57, 3 },
                    { 578, "feature", "Sensitivity", 57, 4 },
                    { 581, "color", "Color", 58, 1 },
                    { 585, "connection", "Connection", 58, 2 },
                    { 586, "form-factor", "Layout", 58, 3 },
                    { 587, "switch", "Switch", 58, 4 },
                    { 591, "color", "Color", 59, 1 },
                    { 596, "form-factor", "Fit", 59, 2 },
                    { 598, "feature", "Noise Control", 59, 3 },
                    { 711, "color", "Color", 71, 1 },
                    { 715, "connection", "Connection", 71, 2 },
                    { 716, "form-factor", "Layout", 71, 3 },
                    { 717, "switch", "Switch", 71, 4 },
                    { 721, "color", "Color", 72, 1 },
                    { 725, "connection", "Connection", 72, 2 },
                    { 728, "feature", "Noise Control", 72, 3 },
                    { 731, "color", "Color", 73, 1 },
                    { 736, "form-factor", "Fit", 73, 2 },
                    { 738, "feature", "Noise Control", 73, 3 },
                    { 741, "color", "Color", 74, 1 },
                    { 745, "connection", "Connection", 74, 2 },
                    { 749, "microphone", "Microphone", 74, 3 },
                    { 751, "color", "Color", 75, 1 },
                    { 755, "connection", "Connection", 75, 2 },
                    { 756, "form-factor", "Shape", 75, 3 },
                    { 758, "feature", "Sensitivity", 75, 4 },
                    { 761, "color", "Color", 76, 1 },
                    { 765, "connection", "Connection", 76, 2 },
                    { 766, "form-factor", "Layout", 76, 3 },
                    { 767, "switch", "Switch", 76, 4 },
                    { 771, "color", "Color", 77, 1 },
                    { 775, "connection", "Connection", 77, 2 },
                    { 776, "form-factor", "Shape", 77, 3 },
                    { 778, "feature", "Sensitivity", 77, 4 },
                    { 781, "color", "Color", 78, 1 },
                    { 785, "connection", "Connection", 78, 2 },
                    { 786, "form-factor", "Layout", 78, 3 },
                    { 787, "switch", "Switch", 78, 4 },
                    { 791, "color", "Color", 79, 1 },
                    { 795, "connection", "Connection", 79, 2 },
                    { 799, "microphone", "Microphone", 79, 3 }
                });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1100,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-11-BLACK-WIRED-USB-C-COMPACT-TACTILE", 11 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1200,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-12-BLACK-BLUETOOTH-ERGONOMIC-4000-DPI", 16 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1300,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-13-BLACK-IN-EAR-STANDARD", 12 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1400,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-14-BLACK-WIRED-USB-C-BOOM", 8 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1500,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-15-BLACK-BLUETOOTH-STANDARD", 6 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1600,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-16-BLACK-WIRED-USB-C-COMPACT-TACTILE", 8 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1700,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-17-BLACK-BLUETOOTH-ERGONOMIC-4000-DPI", 9 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1800,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-18-BLACK-IN-EAR-STANDARD", 11 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1900,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-19-BLACK-WIRED-USB-C-BOOM", 12 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3100,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-31-BLACK-WIRED-USB-C-COMPACT-TACTILE", 9 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3200,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-32-BLACK-BLUETOOTH-ERGONOMIC-4000-DPI", 16 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3300,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-33-BLACK-IN-EAR-STANDARD", 10 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3400,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-34-BLACK-BLUETOOTH-STANDARD", 7 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3500,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-35-BLACK-WIRED-USB-C-BOOM", 12 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3600,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-36-BLACK-WIRED-USB-C-COMPACT-TACTILE", 8 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3700,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-37-BLACK-BLUETOOTH-ERGONOMIC-4000-DPI", 12 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3800,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-38-BLACK-IN-EAR-STANDARD", 11 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3900,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-39-BLACK-WIRED-USB-C-BOOM", 8 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5100,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-51-BLACK-WIRED-USB-C-COMPACT-TACTILE", 12 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5200,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-52-BLACK-BLUETOOTH-ERGONOMIC-4000-DPI", 20 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5300,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-53-BLACK-IN-EAR-STANDARD", 10 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5400,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-54-BLACK-BLUETOOTH-STANDARD", 8 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5500,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-55-BLACK-WIRED-USB-C-BOOM", 12 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5600,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-56-BLACK-WIRED-USB-C-COMPACT-TACTILE", 13 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5700,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-57-BLACK-BLUETOOTH-ERGONOMIC-4000-DPI", 15 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5800,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-58-BLACK-WIRED-USB-C-COMPACT-TACTILE", 9 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5900,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-59-BLACK-IN-EAR-STANDARD", 11 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7100,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-71-BLACK-WIRED-USB-C-COMPACT-TACTILE", 10 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7200,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-72-BLACK-BLUETOOTH-STANDARD", 5 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7300,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-73-BLACK-IN-EAR-STANDARD", 11 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7400,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-74-BLACK-WIRED-USB-C-BOOM", 8 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7500,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-75-BLACK-BLUETOOTH-ERGONOMIC-4000-DPI", 8 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7600,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-76-BLACK-WIRED-USB-C-COMPACT-TACTILE", 7 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7700,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-77-BLACK-BLUETOOTH-ERGONOMIC-4000-DPI", 12 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7800,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-78-BLACK-WIRED-USB-C-COMPACT-TACTILE", 7 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7900,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-79-BLACK-WIRED-USB-C-BOOM", 9 });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "Id", "ImageUrl", "Price", "ProductId", "Sku", "StockQuantity" },
                values: new object[,]
                {
                    { 1101, "", 3780.00m, 11, "PROD-11-BLACK-BLUETOOTH-COMPACT-TACTILE", 7 },
                    { 1102, "", 3920.00m, 11, "PROD-11-SILVER-BLUETOOTH-COMPACT-LINEAR", 5 },
                    { 1103, "", 4025.00m, 11, "PROD-11-SILVER-WIRED-USB-C-FULL-SIZE-TACTILE", 2 },
                    { 1201, "", 1344.00m, 12, "PROD-12-BLACK-WIRELESS-2-4GHZ-ERGONOMIC-8000-DPI", 12 },
                    { 1202, "", 1260.00m, 12, "PROD-12-SILVER-BLUETOOTH-AMBIDEXTROUS-4000-DPI", 8 },
                    { 1203, "", 1392.00m, 12, "PROD-12-SILVER-WIRELESS-2-4GHZ-AMBIDEXTROUS-8000-DPI", 4 },
                    { 1301, "", 3538.82m, 13, "PROD-13-BLACK-IN-EAR-ANC", 9 },
                    { 1302, "", 3598.8m, 13, "PROD-13-WHITE-IN-EAR-ANC", 6 },
                    { 1303, "", 3238.92m, 13, "PROD-13-WHITE-OPEN-EAR-STANDARD", 3 },
                    { 1401, "", 2698.92m, 14, "PROD-14-BLACK-WIRED-USB-C-DETACHABLE", 6 },
                    { 1402, "", 2798.88m, 14, "PROD-14-BLACK-WIRELESS-2-4GHZ-BOOM", 4 },
                    { 1403, "", 2948.82m, 14, "PROD-14-WHITE-WIRELESS-2-4GHZ-DETACHABLE", 2 },
                    { 1501, "", 10348.85m, 15, "PROD-15-BLACK-BLUETOOTH-ANC", 5 },
                    { 1502, "", 10618.82m, 15, "PROD-15-SILVER-BLUETOOTH-ANC", 2 },
                    { 1503, "", 9448.95m, 15, "PROD-15-SILVER-WIRED-USB-C-STANDARD", 1 },
                    { 1601, "", 2376.00m, 16, "PROD-16-BLACK-BLUETOOTH-COMPACT-TACTILE", 6 },
                    { 1602, "", 2464.00m, 16, "PROD-16-SILVER-BLUETOOTH-COMPACT-LINEAR", 3 },
                    { 1603, "", 2530.00m, 16, "PROD-16-SILVER-WIRED-USB-C-FULL-SIZE-TACTILE", 1 },
                    { 1701, "", 1904.00m, 17, "PROD-17-BLACK-WIRELESS-2-4GHZ-ERGONOMIC-8000-DPI", 7 },
                    { 1702, "", 1785.00m, 17, "PROD-17-SILVER-BLUETOOTH-AMBIDEXTROUS-4000-DPI", 4 },
                    { 1703, "", 1972.00m, 17, "PROD-17-SILVER-WIRELESS-2-4GHZ-AMBIDEXTROUS-8000-DPI", 2 },
                    { 1801, "", 2948.82m, 18, "PROD-18-BLACK-IN-EAR-ANC", 8 },
                    { 1802, "", 2998.8m, 18, "PROD-18-WHITE-IN-EAR-ANC", 5 },
                    { 1803, "", 2698.92m, 18, "PROD-18-WHITE-OPEN-EAR-STANDARD", 2 },
                    { 1901, "", 2158.92m, 19, "PROD-19-BLACK-WIRED-USB-C-DETACHABLE", 9 },
                    { 1902, "", 2238.88m, 19, "PROD-19-BLACK-WIRELESS-2-4GHZ-BOOM", 5 },
                    { 1903, "", 2358.82m, 19, "PROD-19-WHITE-WIRELESS-2-4GHZ-DETACHABLE", 2 },
                    { 3101, "", 117.72m, 31, "PROD-31-BLACK-BLUETOOTH-COMPACT-TACTILE", 7 },
                    { 3102, "", 122.08m, 31, "PROD-31-SILVER-BLUETOOTH-COMPACT-LINEAR", 4 },
                    { 3103, "", 125.35m, 31, "PROD-31-SILVER-WIRED-USB-C-FULL-SIZE-TACTILE", 2 },
                    { 3201, "", 43.68m, 32, "PROD-32-BLACK-WIRELESS-2-4GHZ-ERGONOMIC-8000-DPI", 12 },
                    { 3202, "", 40.95m, 32, "PROD-32-SILVER-BLUETOOTH-AMBIDEXTROUS-4000-DPI", 7 },
                    { 3203, "", 45.24m, 32, "PROD-32-SILVER-WIRELESS-2-4GHZ-AMBIDEXTROUS-8000-DPI", 3 },
                    { 3301, "", 152.22m, 33, "PROD-33-BLACK-IN-EAR-ANC", 8 },
                    { 3302, "", 154.8m, 33, "PROD-33-WHITE-IN-EAR-ANC", 4 },
                    { 3303, "", 139.32m, 33, "PROD-33-WHITE-OPEN-EAR-STANDARD", 2 },
                    { 3401, "", 228.85m, 34, "PROD-34-BLACK-BLUETOOTH-ANC", 5 },
                    { 3402, "", 234.82m, 34, "PROD-34-SILVER-BLUETOOTH-ANC", 3 },
                    { 3403, "", 208.95m, 34, "PROD-34-SILVER-WIRED-USB-C-STANDARD", 1 },
                    { 3501, "", 85.32m, 35, "PROD-35-BLACK-WIRED-USB-C-DETACHABLE", 9 },
                    { 3502, "", 88.48m, 35, "PROD-35-BLACK-WIRELESS-2-4GHZ-BOOM", 5 },
                    { 3503, "", 93.22m, 35, "PROD-35-WHITE-WIRELESS-2-4GHZ-DETACHABLE", 2 },
                    { 3601, "", 74.52m, 36, "PROD-36-BLACK-BLUETOOTH-COMPACT-TACTILE", 6 },
                    { 3602, "", 77.28m, 36, "PROD-36-SILVER-BLUETOOTH-COMPACT-LINEAR", 3 },
                    { 3603, "", 79.35m, 36, "PROD-36-SILVER-WIRED-USB-C-FULL-SIZE-TACTILE", 1 },
                    { 3701, "", 66.08m, 37, "PROD-37-BLACK-WIRELESS-2-4GHZ-ERGONOMIC-8000-DPI", 9 },
                    { 3702, "", 61.95m, 37, "PROD-37-SILVER-BLUETOOTH-AMBIDEXTROUS-4000-DPI", 6 },
                    { 3703, "", 68.44m, 37, "PROD-37-SILVER-WIRELESS-2-4GHZ-AMBIDEXTROUS-8000-DPI", 3 },
                    { 3801, "", 105.02m, 38, "PROD-38-BLACK-IN-EAR-ANC", 8 },
                    { 3802, "", 106.8m, 38, "PROD-38-WHITE-IN-EAR-ANC", 5 },
                    { 3803, "", 96.12m, 38, "PROD-38-WHITE-OPEN-EAR-STANDARD", 2 },
                    { 3901, "", 106.92m, 39, "PROD-39-BLACK-WIRED-USB-C-DETACHABLE", 6 },
                    { 3902, "", 110.88m, 39, "PROD-39-BLACK-WIRELESS-2-4GHZ-BOOM", 4 },
                    { 3903, "", 116.82m, 39, "PROD-39-WHITE-WIRELESS-2-4GHZ-DETACHABLE", 2 },
                    { 5101, "", 355.32m, 51, "PROD-51-BLACK-BLUETOOTH-COMPACT-TACTILE", 9 },
                    { 5102, "", 368.48m, 51, "PROD-51-SILVER-BLUETOOTH-COMPACT-LINEAR", 6 },
                    { 5103, "", 378.35m, 51, "PROD-51-SILVER-WIRED-USB-C-FULL-SIZE-TACTILE", 3 },
                    { 5201, "", 110.88m, 52, "PROD-52-BLACK-WIRELESS-2-4GHZ-ERGONOMIC-8000-DPI", 15 },
                    { 5202, "", 103.95m, 52, "PROD-52-SILVER-BLUETOOTH-AMBIDEXTROUS-4000-DPI", 9 },
                    { 5203, "", 114.84m, 52, "PROD-52-SILVER-WIRELESS-2-4GHZ-AMBIDEXTROUS-8000-DPI", 4 },
                    { 5301, "", 824.82m, 53, "PROD-53-BLACK-IN-EAR-ANC", 8 },
                    { 5302, "", 838.8m, 53, "PROD-53-WHITE-IN-EAR-ANC", 4 },
                    { 5303, "", 754.92m, 53, "PROD-53-WHITE-OPEN-EAR-STANDARD", 2 },
                    { 5401, "", 1033.85m, 54, "PROD-54-BLACK-BLUETOOTH-ANC", 6 },
                    { 5402, "", 1060.82m, 54, "PROD-54-SILVER-BLUETOOTH-ANC", 3 },
                    { 5403, "", 943.95m, 54, "PROD-54-SILVER-WIRED-USB-C-STANDARD", 1 },
                    { 5501, "", 322.92m, 55, "PROD-55-BLACK-WIRED-USB-C-DETACHABLE", 9 },
                    { 5502, "", 334.88m, 55, "PROD-55-BLACK-WIRELESS-2-4GHZ-BOOM", 5 },
                    { 5503, "", 352.82m, 55, "PROD-55-WHITE-WIRELESS-2-4GHZ-DETACHABLE", 2 },
                    { 5601, "", 214.92m, 56, "PROD-56-BLACK-BLUETOOTH-COMPACT-TACTILE", 10 },
                    { 5602, "", 222.88m, 56, "PROD-56-SILVER-BLUETOOTH-COMPACT-LINEAR", 6 },
                    { 5603, "", 228.85m, 56, "PROD-56-SILVER-WIRED-USB-C-FULL-SIZE-TACTILE", 3 },
                    { 5701, "", 222.88m, 57, "PROD-57-BLACK-WIRELESS-2-4GHZ-ERGONOMIC-8000-DPI", 10 },
                    { 5702, "", 208.95m, 57, "PROD-57-SILVER-BLUETOOTH-AMBIDEXTROUS-4000-DPI", 7 },
                    { 5703, "", 230.84m, 57, "PROD-57-SILVER-WIRELESS-2-4GHZ-AMBIDEXTROUS-8000-DPI", 3 },
                    { 5801, "", 355.32m, 58, "PROD-58-BLACK-BLUETOOTH-COMPACT-TACTILE", 7 },
                    { 5802, "", 368.48m, 58, "PROD-58-SILVER-BLUETOOTH-COMPACT-LINEAR", 4 },
                    { 5803, "", 378.35m, 58, "PROD-58-SILVER-WIRED-USB-C-FULL-SIZE-TACTILE", 2 },
                    { 5901, "", 588.82m, 59, "PROD-59-BLACK-IN-EAR-ANC", 8 },
                    { 5902, "", 598.8m, 59, "PROD-59-WHITE-IN-EAR-ANC", 5 },
                    { 5903, "", 538.92m, 59, "PROD-59-WHITE-OPEN-EAR-STANDARD", 2 },
                    { 7101, "", 9698.40m, 71, "PROD-71-BLACK-BLUETOOTH-COMPACT-TACTILE", 8 },
                    { 7102, "", 10057.60m, 71, "PROD-71-SILVER-BLUETOOTH-COMPACT-LINEAR", 4 },
                    { 7103, "", 10327.00m, 71, "PROD-71-SILVER-WIRED-USB-C-FULL-SIZE-TACTILE", 2 },
                    { 7201, "", 68310.00m, 72, "PROD-72-BLACK-BLUETOOTH-ANC", 4 },
                    { 7202, "", 70092.00m, 72, "PROD-72-SILVER-BLUETOOTH-ANC", 2 },
                    { 7203, "", 62370.00m, 72, "PROD-72-SILVER-WIRED-USB-C-STANDARD", 1 },
                    { 7301, "", 15104.00m, 73, "PROD-73-BLACK-IN-EAR-ANC", 8 },
                    { 7302, "", 15360.0m, 73, "PROD-73-WHITE-IN-EAR-ANC", 5 },
                    { 7303, "", 13824.00m, 73, "PROD-73-WHITE-OPEN-EAR-STANDARD", 2 },
                    { 7401, "", 10778.40m, 74, "PROD-74-BLACK-WIRED-USB-C-DETACHABLE", 6 },
                    { 7402, "", 11177.60m, 74, "PROD-74-BLACK-WIRELESS-2-4GHZ-BOOM", 3 },
                    { 7403, "", 11776.40m, 74, "PROD-74-WHITE-WIRELESS-2-4GHZ-DETACHABLE", 1 },
                    { 7501, "", 8937.60m, 75, "PROD-75-BLACK-WIRELESS-2-4GHZ-ERGONOMIC-8000-DPI", 6 },
                    { 7502, "", 8379.00m, 75, "PROD-75-SILVER-BLUETOOTH-AMBIDEXTROUS-4000-DPI", 3 },
                    { 7503, "", 9256.80m, 75, "PROD-75-SILVER-WIRELESS-2-4GHZ-AMBIDEXTROUS-8000-DPI", 1 },
                    { 7601, "", 15984.00m, 76, "PROD-76-BLACK-BLUETOOTH-COMPACT-TACTILE", 5 },
                    { 7602, "", 16576.00m, 76, "PROD-76-SILVER-BLUETOOTH-COMPACT-LINEAR", 3 },
                    { 7603, "", 17020.00m, 76, "PROD-76-SILVER-WIRED-USB-C-FULL-SIZE-TACTILE", 1 },
                    { 7701, "", 5577.60m, 77, "PROD-77-BLACK-WIRELESS-2-4GHZ-ERGONOMIC-8000-DPI", 9 },
                    { 7702, "", 5229.00m, 77, "PROD-77-SILVER-BLUETOOTH-AMBIDEXTROUS-4000-DPI", 5 },
                    { 7703, "", 5776.80m, 77, "PROD-77-SILVER-WIRELESS-2-4GHZ-AMBIDEXTROUS-8000-DPI", 2 },
                    { 7801, "", 13824.00m, 78, "PROD-78-BLACK-BLUETOOTH-COMPACT-TACTILE", 5 },
                    { 7802, "", 14336.00m, 78, "PROD-78-SILVER-BLUETOOTH-COMPACT-LINEAR", 3 },
                    { 7803, "", 14720.00m, 78, "PROD-78-SILVER-WIRED-USB-C-FULL-SIZE-TACTILE", 1 },
                    { 7901, "", 12744.00m, 79, "PROD-79-BLACK-WIRED-USB-C-DETACHABLE", 7 },
                    { 7902, "", 13216.00m, 79, "PROD-79-BLACK-WIRELESS-2-4GHZ-BOOM", 4 },
                    { 7903, "", 13924.00m, 79, "PROD-79-WHITE-WIRELESS-2-4GHZ-DETACHABLE", 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductOptions",
                columns: new[] { "Id", "Code", "Hex", "ImageUrl", "Label", "ProductOptionGroupId", "SortOrder" },
                values: new object[,]
                {
                    { 1111, "black", "#111827", null, "Black", 111, 1 },
                    { 1114, "silver", "#d1d5db", null, "Silver", 111, 2 },
                    { 1151, "wired-usb-c", null, null, "Wired USB-C", 115, 1 },
                    { 1152, "bluetooth", null, null, "Bluetooth", 115, 2 },
                    { 1161, "compact", null, null, "Compact", 116, 1 },
                    { 1162, "full-size", null, null, "Full-size", 116, 2 },
                    { 1171, "tactile", null, null, "Tactile", 117, 1 },
                    { 1172, "linear", null, null, "Linear", 117, 2 },
                    { 1211, "black", "#111827", null, "Black", 121, 1 },
                    { 1214, "silver", "#d1d5db", null, "Silver", 121, 2 },
                    { 1252, "bluetooth", null, null, "Bluetooth", 125, 1 },
                    { 1253, "wireless-2-4ghz", null, null, "2.4GHz Wireless", 125, 2 },
                    { 1263, "ergonomic", null, null, "Ergonomic", 126, 1 },
                    { 1264, "ambidextrous", null, null, "Ambidextrous", 126, 2 },
                    { 1281, "4000-dpi", null, null, "4,000 DPI", 128, 1 },
                    { 1282, "8000-dpi", null, null, "8,000 DPI", 128, 2 },
                    { 1311, "black", "#111827", null, "Black", 131, 1 },
                    { 1315, "white", "#f9fafb", null, "White", 131, 2 },
                    { 1365, "in-ear", null, null, "In-ear", 136, 1 },
                    { 1366, "open-ear", null, null, "Open-ear", 136, 2 },
                    { 1383, "standard", null, null, "Standard", 138, 1 },
                    { 1384, "anc", null, null, "Active Noise Cancelling", 138, 2 },
                    { 1411, "black", "#111827", null, "Black", 141, 1 },
                    { 1415, "white", "#f9fafb", null, "White", 141, 2 },
                    { 1451, "wired-usb-c", null, null, "Wired USB-C", 145, 1 },
                    { 1453, "wireless-2-4ghz", null, null, "2.4GHz Wireless", 145, 2 },
                    { 1491, "boom", null, null, "Boom Mic", 149, 1 },
                    { 1492, "detachable", null, null, "Detachable Mic", 149, 2 },
                    { 1511, "black", "#111827", null, "Black", 151, 1 },
                    { 1514, "silver", "#d1d5db", null, "Silver", 151, 2 },
                    { 1551, "wired-usb-c", null, null, "Wired USB-C", 155, 2 },
                    { 1552, "bluetooth", null, null, "Bluetooth", 155, 1 },
                    { 1583, "standard", null, null, "Standard", 158, 1 },
                    { 1584, "anc", null, null, "Active Noise Cancelling", 158, 2 },
                    { 1611, "black", "#111827", null, "Black", 161, 1 },
                    { 1614, "silver", "#d1d5db", null, "Silver", 161, 2 },
                    { 1651, "wired-usb-c", null, null, "Wired USB-C", 165, 1 },
                    { 1652, "bluetooth", null, null, "Bluetooth", 165, 2 },
                    { 1661, "compact", null, null, "Compact", 166, 1 },
                    { 1662, "full-size", null, null, "Full-size", 166, 2 },
                    { 1671, "tactile", null, null, "Tactile", 167, 1 },
                    { 1672, "linear", null, null, "Linear", 167, 2 },
                    { 1711, "black", "#111827", null, "Black", 171, 1 },
                    { 1714, "silver", "#d1d5db", null, "Silver", 171, 2 },
                    { 1752, "bluetooth", null, null, "Bluetooth", 175, 1 },
                    { 1753, "wireless-2-4ghz", null, null, "2.4GHz Wireless", 175, 2 },
                    { 1763, "ergonomic", null, null, "Ergonomic", 176, 1 },
                    { 1764, "ambidextrous", null, null, "Ambidextrous", 176, 2 },
                    { 1781, "4000-dpi", null, null, "4,000 DPI", 178, 1 },
                    { 1782, "8000-dpi", null, null, "8,000 DPI", 178, 2 },
                    { 1811, "black", "#111827", null, "Black", 181, 1 },
                    { 1815, "white", "#f9fafb", null, "White", 181, 2 },
                    { 1865, "in-ear", null, null, "In-ear", 186, 1 },
                    { 1866, "open-ear", null, null, "Open-ear", 186, 2 },
                    { 1883, "standard", null, null, "Standard", 188, 1 },
                    { 1884, "anc", null, null, "Active Noise Cancelling", 188, 2 },
                    { 1911, "black", "#111827", null, "Black", 191, 1 },
                    { 1915, "white", "#f9fafb", null, "White", 191, 2 },
                    { 1951, "wired-usb-c", null, null, "Wired USB-C", 195, 1 },
                    { 1953, "wireless-2-4ghz", null, null, "2.4GHz Wireless", 195, 2 },
                    { 1991, "boom", null, null, "Boom Mic", 199, 1 },
                    { 1992, "detachable", null, null, "Detachable Mic", 199, 2 },
                    { 3111, "black", "#111827", null, "Black", 311, 1 },
                    { 3114, "silver", "#d1d5db", null, "Silver", 311, 2 },
                    { 3151, "wired-usb-c", null, null, "Wired USB-C", 315, 1 },
                    { 3152, "bluetooth", null, null, "Bluetooth", 315, 2 },
                    { 3161, "compact", null, null, "Compact", 316, 1 },
                    { 3162, "full-size", null, null, "Full-size", 316, 2 },
                    { 3171, "tactile", null, null, "Tactile", 317, 1 },
                    { 3172, "linear", null, null, "Linear", 317, 2 },
                    { 3211, "black", "#111827", null, "Black", 321, 1 },
                    { 3214, "silver", "#d1d5db", null, "Silver", 321, 2 },
                    { 3252, "bluetooth", null, null, "Bluetooth", 325, 1 },
                    { 3253, "wireless-2-4ghz", null, null, "2.4GHz Wireless", 325, 2 },
                    { 3263, "ergonomic", null, null, "Ergonomic", 326, 1 },
                    { 3264, "ambidextrous", null, null, "Ambidextrous", 326, 2 },
                    { 3281, "4000-dpi", null, null, "4,000 DPI", 328, 1 },
                    { 3282, "8000-dpi", null, null, "8,000 DPI", 328, 2 },
                    { 3311, "black", "#111827", null, "Black", 331, 1 },
                    { 3315, "white", "#f9fafb", null, "White", 331, 2 },
                    { 3365, "in-ear", null, null, "In-ear", 336, 1 },
                    { 3366, "open-ear", null, null, "Open-ear", 336, 2 },
                    { 3383, "standard", null, null, "Standard", 338, 1 },
                    { 3384, "anc", null, null, "Active Noise Cancelling", 338, 2 },
                    { 3411, "black", "#111827", null, "Black", 341, 1 },
                    { 3414, "silver", "#d1d5db", null, "Silver", 341, 2 },
                    { 3451, "wired-usb-c", null, null, "Wired USB-C", 345, 2 },
                    { 3452, "bluetooth", null, null, "Bluetooth", 345, 1 },
                    { 3483, "standard", null, null, "Standard", 348, 1 },
                    { 3484, "anc", null, null, "Active Noise Cancelling", 348, 2 },
                    { 3511, "black", "#111827", null, "Black", 351, 1 },
                    { 3515, "white", "#f9fafb", null, "White", 351, 2 },
                    { 3551, "wired-usb-c", null, null, "Wired USB-C", 355, 1 },
                    { 3553, "wireless-2-4ghz", null, null, "2.4GHz Wireless", 355, 2 },
                    { 3591, "boom", null, null, "Boom Mic", 359, 1 },
                    { 3592, "detachable", null, null, "Detachable Mic", 359, 2 },
                    { 3611, "black", "#111827", null, "Black", 361, 1 },
                    { 3614, "silver", "#d1d5db", null, "Silver", 361, 2 },
                    { 3651, "wired-usb-c", null, null, "Wired USB-C", 365, 1 },
                    { 3652, "bluetooth", null, null, "Bluetooth", 365, 2 },
                    { 3661, "compact", null, null, "Compact", 366, 1 },
                    { 3662, "full-size", null, null, "Full-size", 366, 2 },
                    { 3671, "tactile", null, null, "Tactile", 367, 1 },
                    { 3672, "linear", null, null, "Linear", 367, 2 },
                    { 3711, "black", "#111827", null, "Black", 371, 1 },
                    { 3714, "silver", "#d1d5db", null, "Silver", 371, 2 },
                    { 3752, "bluetooth", null, null, "Bluetooth", 375, 1 },
                    { 3753, "wireless-2-4ghz", null, null, "2.4GHz Wireless", 375, 2 },
                    { 3763, "ergonomic", null, null, "Ergonomic", 376, 1 },
                    { 3764, "ambidextrous", null, null, "Ambidextrous", 376, 2 },
                    { 3781, "4000-dpi", null, null, "4,000 DPI", 378, 1 },
                    { 3782, "8000-dpi", null, null, "8,000 DPI", 378, 2 },
                    { 3811, "black", "#111827", null, "Black", 381, 1 },
                    { 3815, "white", "#f9fafb", null, "White", 381, 2 },
                    { 3865, "in-ear", null, null, "In-ear", 386, 1 },
                    { 3866, "open-ear", null, null, "Open-ear", 386, 2 },
                    { 3883, "standard", null, null, "Standard", 388, 1 },
                    { 3884, "anc", null, null, "Active Noise Cancelling", 388, 2 },
                    { 3911, "black", "#111827", null, "Black", 391, 1 },
                    { 3915, "white", "#f9fafb", null, "White", 391, 2 },
                    { 3951, "wired-usb-c", null, null, "Wired USB-C", 395, 1 },
                    { 3953, "wireless-2-4ghz", null, null, "2.4GHz Wireless", 395, 2 },
                    { 3991, "boom", null, null, "Boom Mic", 399, 1 },
                    { 3992, "detachable", null, null, "Detachable Mic", 399, 2 },
                    { 5111, "black", "#111827", null, "Black", 511, 1 },
                    { 5114, "silver", "#d1d5db", null, "Silver", 511, 2 },
                    { 5151, "wired-usb-c", null, null, "Wired USB-C", 515, 1 },
                    { 5152, "bluetooth", null, null, "Bluetooth", 515, 2 },
                    { 5161, "compact", null, null, "Compact", 516, 1 },
                    { 5162, "full-size", null, null, "Full-size", 516, 2 },
                    { 5171, "tactile", null, null, "Tactile", 517, 1 },
                    { 5172, "linear", null, null, "Linear", 517, 2 },
                    { 5211, "black", "#111827", null, "Black", 521, 1 },
                    { 5214, "silver", "#d1d5db", null, "Silver", 521, 2 },
                    { 5252, "bluetooth", null, null, "Bluetooth", 525, 1 },
                    { 5253, "wireless-2-4ghz", null, null, "2.4GHz Wireless", 525, 2 },
                    { 5263, "ergonomic", null, null, "Ergonomic", 526, 1 },
                    { 5264, "ambidextrous", null, null, "Ambidextrous", 526, 2 },
                    { 5281, "4000-dpi", null, null, "4,000 DPI", 528, 1 },
                    { 5282, "8000-dpi", null, null, "8,000 DPI", 528, 2 },
                    { 5311, "black", "#111827", null, "Black", 531, 1 },
                    { 5315, "white", "#f9fafb", null, "White", 531, 2 },
                    { 5365, "in-ear", null, null, "In-ear", 536, 1 },
                    { 5366, "open-ear", null, null, "Open-ear", 536, 2 },
                    { 5383, "standard", null, null, "Standard", 538, 1 },
                    { 5384, "anc", null, null, "Active Noise Cancelling", 538, 2 },
                    { 5411, "black", "#111827", null, "Black", 541, 1 },
                    { 5414, "silver", "#d1d5db", null, "Silver", 541, 2 },
                    { 5451, "wired-usb-c", null, null, "Wired USB-C", 545, 2 },
                    { 5452, "bluetooth", null, null, "Bluetooth", 545, 1 },
                    { 5483, "standard", null, null, "Standard", 548, 1 },
                    { 5484, "anc", null, null, "Active Noise Cancelling", 548, 2 },
                    { 5511, "black", "#111827", null, "Black", 551, 1 },
                    { 5515, "white", "#f9fafb", null, "White", 551, 2 },
                    { 5551, "wired-usb-c", null, null, "Wired USB-C", 555, 1 },
                    { 5553, "wireless-2-4ghz", null, null, "2.4GHz Wireless", 555, 2 },
                    { 5591, "boom", null, null, "Boom Mic", 559, 1 },
                    { 5592, "detachable", null, null, "Detachable Mic", 559, 2 },
                    { 5611, "black", "#111827", null, "Black", 561, 1 },
                    { 5614, "silver", "#d1d5db", null, "Silver", 561, 2 },
                    { 5651, "wired-usb-c", null, null, "Wired USB-C", 565, 1 },
                    { 5652, "bluetooth", null, null, "Bluetooth", 565, 2 },
                    { 5661, "compact", null, null, "Compact", 566, 1 },
                    { 5662, "full-size", null, null, "Full-size", 566, 2 },
                    { 5671, "tactile", null, null, "Tactile", 567, 1 },
                    { 5672, "linear", null, null, "Linear", 567, 2 },
                    { 5711, "black", "#111827", null, "Black", 571, 1 },
                    { 5714, "silver", "#d1d5db", null, "Silver", 571, 2 },
                    { 5752, "bluetooth", null, null, "Bluetooth", 575, 1 },
                    { 5753, "wireless-2-4ghz", null, null, "2.4GHz Wireless", 575, 2 },
                    { 5763, "ergonomic", null, null, "Ergonomic", 576, 1 },
                    { 5764, "ambidextrous", null, null, "Ambidextrous", 576, 2 },
                    { 5781, "4000-dpi", null, null, "4,000 DPI", 578, 1 },
                    { 5782, "8000-dpi", null, null, "8,000 DPI", 578, 2 },
                    { 5811, "black", "#111827", null, "Black", 581, 1 },
                    { 5814, "silver", "#d1d5db", null, "Silver", 581, 2 },
                    { 5851, "wired-usb-c", null, null, "Wired USB-C", 585, 1 },
                    { 5852, "bluetooth", null, null, "Bluetooth", 585, 2 },
                    { 5861, "compact", null, null, "Compact", 586, 1 },
                    { 5862, "full-size", null, null, "Full-size", 586, 2 },
                    { 5871, "tactile", null, null, "Tactile", 587, 1 },
                    { 5872, "linear", null, null, "Linear", 587, 2 },
                    { 5911, "black", "#111827", null, "Black", 591, 1 },
                    { 5915, "white", "#f9fafb", null, "White", 591, 2 },
                    { 5965, "in-ear", null, null, "In-ear", 596, 1 },
                    { 5966, "open-ear", null, null, "Open-ear", 596, 2 },
                    { 5983, "standard", null, null, "Standard", 598, 1 },
                    { 5984, "anc", null, null, "Active Noise Cancelling", 598, 2 },
                    { 7111, "black", "#111827", null, "Black", 711, 1 },
                    { 7114, "silver", "#d1d5db", null, "Silver", 711, 2 },
                    { 7151, "wired-usb-c", null, null, "Wired USB-C", 715, 1 },
                    { 7152, "bluetooth", null, null, "Bluetooth", 715, 2 },
                    { 7161, "compact", null, null, "Compact", 716, 1 },
                    { 7162, "full-size", null, null, "Full-size", 716, 2 },
                    { 7171, "tactile", null, null, "Tactile", 717, 1 },
                    { 7172, "linear", null, null, "Linear", 717, 2 },
                    { 7211, "black", "#111827", null, "Black", 721, 1 },
                    { 7214, "silver", "#d1d5db", null, "Silver", 721, 2 },
                    { 7251, "wired-usb-c", null, null, "Wired USB-C", 725, 2 },
                    { 7252, "bluetooth", null, null, "Bluetooth", 725, 1 },
                    { 7283, "standard", null, null, "Standard", 728, 1 },
                    { 7284, "anc", null, null, "Active Noise Cancelling", 728, 2 },
                    { 7311, "black", "#111827", null, "Black", 731, 1 },
                    { 7315, "white", "#f9fafb", null, "White", 731, 2 },
                    { 7365, "in-ear", null, null, "In-ear", 736, 1 },
                    { 7366, "open-ear", null, null, "Open-ear", 736, 2 },
                    { 7383, "standard", null, null, "Standard", 738, 1 },
                    { 7384, "anc", null, null, "Active Noise Cancelling", 738, 2 },
                    { 7411, "black", "#111827", null, "Black", 741, 1 },
                    { 7415, "white", "#f9fafb", null, "White", 741, 2 },
                    { 7451, "wired-usb-c", null, null, "Wired USB-C", 745, 1 },
                    { 7453, "wireless-2-4ghz", null, null, "2.4GHz Wireless", 745, 2 },
                    { 7491, "boom", null, null, "Boom Mic", 749, 1 },
                    { 7492, "detachable", null, null, "Detachable Mic", 749, 2 },
                    { 7511, "black", "#111827", null, "Black", 751, 1 },
                    { 7514, "silver", "#d1d5db", null, "Silver", 751, 2 },
                    { 7552, "bluetooth", null, null, "Bluetooth", 755, 1 },
                    { 7553, "wireless-2-4ghz", null, null, "2.4GHz Wireless", 755, 2 },
                    { 7563, "ergonomic", null, null, "Ergonomic", 756, 1 },
                    { 7564, "ambidextrous", null, null, "Ambidextrous", 756, 2 },
                    { 7581, "4000-dpi", null, null, "4,000 DPI", 758, 1 },
                    { 7582, "8000-dpi", null, null, "8,000 DPI", 758, 2 },
                    { 7611, "black", "#111827", null, "Black", 761, 1 },
                    { 7614, "silver", "#d1d5db", null, "Silver", 761, 2 },
                    { 7651, "wired-usb-c", null, null, "Wired USB-C", 765, 1 },
                    { 7652, "bluetooth", null, null, "Bluetooth", 765, 2 },
                    { 7661, "compact", null, null, "Compact", 766, 1 },
                    { 7662, "full-size", null, null, "Full-size", 766, 2 },
                    { 7671, "tactile", null, null, "Tactile", 767, 1 },
                    { 7672, "linear", null, null, "Linear", 767, 2 },
                    { 7711, "black", "#111827", null, "Black", 771, 1 },
                    { 7714, "silver", "#d1d5db", null, "Silver", 771, 2 },
                    { 7752, "bluetooth", null, null, "Bluetooth", 775, 1 },
                    { 7753, "wireless-2-4ghz", null, null, "2.4GHz Wireless", 775, 2 },
                    { 7763, "ergonomic", null, null, "Ergonomic", 776, 1 },
                    { 7764, "ambidextrous", null, null, "Ambidextrous", 776, 2 },
                    { 7781, "4000-dpi", null, null, "4,000 DPI", 778, 1 },
                    { 7782, "8000-dpi", null, null, "8,000 DPI", 778, 2 },
                    { 7811, "black", "#111827", null, "Black", 781, 1 },
                    { 7814, "silver", "#d1d5db", null, "Silver", 781, 2 },
                    { 7851, "wired-usb-c", null, null, "Wired USB-C", 785, 1 },
                    { 7852, "bluetooth", null, null, "Bluetooth", 785, 2 },
                    { 7861, "compact", null, null, "Compact", 786, 1 },
                    { 7862, "full-size", null, null, "Full-size", 786, 2 },
                    { 7871, "tactile", null, null, "Tactile", 787, 1 },
                    { 7872, "linear", null, null, "Linear", 787, 2 },
                    { 7911, "black", "#111827", null, "Black", 791, 1 },
                    { 7915, "white", "#f9fafb", null, "White", 791, 2 },
                    { 7951, "wired-usb-c", null, null, "Wired USB-C", 795, 1 },
                    { 7953, "wireless-2-4ghz", null, null, "2.4GHz Wireless", 795, 2 },
                    { 7991, "boom", null, null, "Boom Mic", 799, 1 },
                    { 7992, "detachable", null, null, "Detachable Mic", 799, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantOptions",
                columns: new[] { "Id", "ProductOptionId", "ProductVariantId" },
                values: new object[,]
                {
                    { 11001, 1111, 1100 },
                    { 11002, 1151, 1100 },
                    { 11003, 1161, 1100 },
                    { 11004, 1171, 1100 },
                    { 11011, 1111, 1101 },
                    { 11012, 1152, 1101 },
                    { 11013, 1161, 1101 },
                    { 11014, 1171, 1101 },
                    { 11021, 1114, 1102 },
                    { 11022, 1152, 1102 },
                    { 11023, 1161, 1102 },
                    { 11024, 1172, 1102 },
                    { 11031, 1114, 1103 },
                    { 11032, 1151, 1103 },
                    { 11033, 1162, 1103 },
                    { 11034, 1171, 1103 },
                    { 12001, 1211, 1200 },
                    { 12002, 1252, 1200 },
                    { 12003, 1263, 1200 },
                    { 12004, 1281, 1200 },
                    { 12011, 1211, 1201 },
                    { 12012, 1253, 1201 },
                    { 12013, 1263, 1201 },
                    { 12014, 1282, 1201 },
                    { 12021, 1214, 1202 },
                    { 12022, 1252, 1202 },
                    { 12023, 1264, 1202 },
                    { 12024, 1281, 1202 },
                    { 12031, 1214, 1203 },
                    { 12032, 1253, 1203 },
                    { 12033, 1264, 1203 },
                    { 12034, 1282, 1203 },
                    { 13001, 1311, 1300 },
                    { 13002, 1365, 1300 },
                    { 13003, 1383, 1300 },
                    { 13011, 1311, 1301 },
                    { 13012, 1365, 1301 },
                    { 13013, 1384, 1301 },
                    { 13021, 1315, 1302 },
                    { 13022, 1365, 1302 },
                    { 13023, 1384, 1302 },
                    { 13031, 1315, 1303 },
                    { 13032, 1366, 1303 },
                    { 13033, 1383, 1303 },
                    { 14001, 1411, 1400 },
                    { 14002, 1451, 1400 },
                    { 14003, 1491, 1400 },
                    { 14011, 1411, 1401 },
                    { 14012, 1451, 1401 },
                    { 14013, 1492, 1401 },
                    { 14021, 1411, 1402 },
                    { 14022, 1453, 1402 },
                    { 14023, 1491, 1402 },
                    { 14031, 1415, 1403 },
                    { 14032, 1453, 1403 },
                    { 14033, 1492, 1403 },
                    { 15001, 1511, 1500 },
                    { 15002, 1552, 1500 },
                    { 15003, 1583, 1500 },
                    { 15011, 1511, 1501 },
                    { 15012, 1552, 1501 },
                    { 15013, 1584, 1501 },
                    { 15021, 1514, 1502 },
                    { 15022, 1552, 1502 },
                    { 15023, 1584, 1502 },
                    { 15031, 1514, 1503 },
                    { 15032, 1551, 1503 },
                    { 15033, 1583, 1503 },
                    { 16001, 1611, 1600 },
                    { 16002, 1651, 1600 },
                    { 16003, 1661, 1600 },
                    { 16004, 1671, 1600 },
                    { 16011, 1611, 1601 },
                    { 16012, 1652, 1601 },
                    { 16013, 1661, 1601 },
                    { 16014, 1671, 1601 },
                    { 16021, 1614, 1602 },
                    { 16022, 1652, 1602 },
                    { 16023, 1661, 1602 },
                    { 16024, 1672, 1602 },
                    { 16031, 1614, 1603 },
                    { 16032, 1651, 1603 },
                    { 16033, 1662, 1603 },
                    { 16034, 1671, 1603 },
                    { 17001, 1711, 1700 },
                    { 17002, 1752, 1700 },
                    { 17003, 1763, 1700 },
                    { 17004, 1781, 1700 },
                    { 17011, 1711, 1701 },
                    { 17012, 1753, 1701 },
                    { 17013, 1763, 1701 },
                    { 17014, 1782, 1701 },
                    { 17021, 1714, 1702 },
                    { 17022, 1752, 1702 },
                    { 17023, 1764, 1702 },
                    { 17024, 1781, 1702 },
                    { 17031, 1714, 1703 },
                    { 17032, 1753, 1703 },
                    { 17033, 1764, 1703 },
                    { 17034, 1782, 1703 },
                    { 18001, 1811, 1800 },
                    { 18002, 1865, 1800 },
                    { 18003, 1883, 1800 },
                    { 18011, 1811, 1801 },
                    { 18012, 1865, 1801 },
                    { 18013, 1884, 1801 },
                    { 18021, 1815, 1802 },
                    { 18022, 1865, 1802 },
                    { 18023, 1884, 1802 },
                    { 18031, 1815, 1803 },
                    { 18032, 1866, 1803 },
                    { 18033, 1883, 1803 },
                    { 19001, 1911, 1900 },
                    { 19002, 1951, 1900 },
                    { 19003, 1991, 1900 },
                    { 19011, 1911, 1901 },
                    { 19012, 1951, 1901 },
                    { 19013, 1992, 1901 },
                    { 19021, 1911, 1902 },
                    { 19022, 1953, 1902 },
                    { 19023, 1991, 1902 },
                    { 19031, 1915, 1903 },
                    { 19032, 1953, 1903 },
                    { 19033, 1992, 1903 },
                    { 31001, 3111, 3100 },
                    { 31002, 3151, 3100 },
                    { 31003, 3161, 3100 },
                    { 31004, 3171, 3100 },
                    { 31011, 3111, 3101 },
                    { 31012, 3152, 3101 },
                    { 31013, 3161, 3101 },
                    { 31014, 3171, 3101 },
                    { 31021, 3114, 3102 },
                    { 31022, 3152, 3102 },
                    { 31023, 3161, 3102 },
                    { 31024, 3172, 3102 },
                    { 31031, 3114, 3103 },
                    { 31032, 3151, 3103 },
                    { 31033, 3162, 3103 },
                    { 31034, 3171, 3103 },
                    { 32001, 3211, 3200 },
                    { 32002, 3252, 3200 },
                    { 32003, 3263, 3200 },
                    { 32004, 3281, 3200 },
                    { 32011, 3211, 3201 },
                    { 32012, 3253, 3201 },
                    { 32013, 3263, 3201 },
                    { 32014, 3282, 3201 },
                    { 32021, 3214, 3202 },
                    { 32022, 3252, 3202 },
                    { 32023, 3264, 3202 },
                    { 32024, 3281, 3202 },
                    { 32031, 3214, 3203 },
                    { 32032, 3253, 3203 },
                    { 32033, 3264, 3203 },
                    { 32034, 3282, 3203 },
                    { 33001, 3311, 3300 },
                    { 33002, 3365, 3300 },
                    { 33003, 3383, 3300 },
                    { 33011, 3311, 3301 },
                    { 33012, 3365, 3301 },
                    { 33013, 3384, 3301 },
                    { 33021, 3315, 3302 },
                    { 33022, 3365, 3302 },
                    { 33023, 3384, 3302 },
                    { 33031, 3315, 3303 },
                    { 33032, 3366, 3303 },
                    { 33033, 3383, 3303 },
                    { 34001, 3411, 3400 },
                    { 34002, 3452, 3400 },
                    { 34003, 3483, 3400 },
                    { 34011, 3411, 3401 },
                    { 34012, 3452, 3401 },
                    { 34013, 3484, 3401 },
                    { 34021, 3414, 3402 },
                    { 34022, 3452, 3402 },
                    { 34023, 3484, 3402 },
                    { 34031, 3414, 3403 },
                    { 34032, 3451, 3403 },
                    { 34033, 3483, 3403 },
                    { 35001, 3511, 3500 },
                    { 35002, 3551, 3500 },
                    { 35003, 3591, 3500 },
                    { 35011, 3511, 3501 },
                    { 35012, 3551, 3501 },
                    { 35013, 3592, 3501 },
                    { 35021, 3511, 3502 },
                    { 35022, 3553, 3502 },
                    { 35023, 3591, 3502 },
                    { 35031, 3515, 3503 },
                    { 35032, 3553, 3503 },
                    { 35033, 3592, 3503 },
                    { 36001, 3611, 3600 },
                    { 36002, 3651, 3600 },
                    { 36003, 3661, 3600 },
                    { 36004, 3671, 3600 },
                    { 36011, 3611, 3601 },
                    { 36012, 3652, 3601 },
                    { 36013, 3661, 3601 },
                    { 36014, 3671, 3601 },
                    { 36021, 3614, 3602 },
                    { 36022, 3652, 3602 },
                    { 36023, 3661, 3602 },
                    { 36024, 3672, 3602 },
                    { 36031, 3614, 3603 },
                    { 36032, 3651, 3603 },
                    { 36033, 3662, 3603 },
                    { 36034, 3671, 3603 },
                    { 37001, 3711, 3700 },
                    { 37002, 3752, 3700 },
                    { 37003, 3763, 3700 },
                    { 37004, 3781, 3700 },
                    { 37011, 3711, 3701 },
                    { 37012, 3753, 3701 },
                    { 37013, 3763, 3701 },
                    { 37014, 3782, 3701 },
                    { 37021, 3714, 3702 },
                    { 37022, 3752, 3702 },
                    { 37023, 3764, 3702 },
                    { 37024, 3781, 3702 },
                    { 37031, 3714, 3703 },
                    { 37032, 3753, 3703 },
                    { 37033, 3764, 3703 },
                    { 37034, 3782, 3703 },
                    { 38001, 3811, 3800 },
                    { 38002, 3865, 3800 },
                    { 38003, 3883, 3800 },
                    { 38011, 3811, 3801 },
                    { 38012, 3865, 3801 },
                    { 38013, 3884, 3801 },
                    { 38021, 3815, 3802 },
                    { 38022, 3865, 3802 },
                    { 38023, 3884, 3802 },
                    { 38031, 3815, 3803 },
                    { 38032, 3866, 3803 },
                    { 38033, 3883, 3803 },
                    { 39001, 3911, 3900 },
                    { 39002, 3951, 3900 },
                    { 39003, 3991, 3900 },
                    { 39011, 3911, 3901 },
                    { 39012, 3951, 3901 },
                    { 39013, 3992, 3901 },
                    { 39021, 3911, 3902 },
                    { 39022, 3953, 3902 },
                    { 39023, 3991, 3902 },
                    { 39031, 3915, 3903 },
                    { 39032, 3953, 3903 },
                    { 39033, 3992, 3903 },
                    { 51001, 5111, 5100 },
                    { 51002, 5151, 5100 },
                    { 51003, 5161, 5100 },
                    { 51004, 5171, 5100 },
                    { 51011, 5111, 5101 },
                    { 51012, 5152, 5101 },
                    { 51013, 5161, 5101 },
                    { 51014, 5171, 5101 },
                    { 51021, 5114, 5102 },
                    { 51022, 5152, 5102 },
                    { 51023, 5161, 5102 },
                    { 51024, 5172, 5102 },
                    { 51031, 5114, 5103 },
                    { 51032, 5151, 5103 },
                    { 51033, 5162, 5103 },
                    { 51034, 5171, 5103 },
                    { 52001, 5211, 5200 },
                    { 52002, 5252, 5200 },
                    { 52003, 5263, 5200 },
                    { 52004, 5281, 5200 },
                    { 52011, 5211, 5201 },
                    { 52012, 5253, 5201 },
                    { 52013, 5263, 5201 },
                    { 52014, 5282, 5201 },
                    { 52021, 5214, 5202 },
                    { 52022, 5252, 5202 },
                    { 52023, 5264, 5202 },
                    { 52024, 5281, 5202 },
                    { 52031, 5214, 5203 },
                    { 52032, 5253, 5203 },
                    { 52033, 5264, 5203 },
                    { 52034, 5282, 5203 },
                    { 53001, 5311, 5300 },
                    { 53002, 5365, 5300 },
                    { 53003, 5383, 5300 },
                    { 53011, 5311, 5301 },
                    { 53012, 5365, 5301 },
                    { 53013, 5384, 5301 },
                    { 53021, 5315, 5302 },
                    { 53022, 5365, 5302 },
                    { 53023, 5384, 5302 },
                    { 53031, 5315, 5303 },
                    { 53032, 5366, 5303 },
                    { 53033, 5383, 5303 },
                    { 54001, 5411, 5400 },
                    { 54002, 5452, 5400 },
                    { 54003, 5483, 5400 },
                    { 54011, 5411, 5401 },
                    { 54012, 5452, 5401 },
                    { 54013, 5484, 5401 },
                    { 54021, 5414, 5402 },
                    { 54022, 5452, 5402 },
                    { 54023, 5484, 5402 },
                    { 54031, 5414, 5403 },
                    { 54032, 5451, 5403 },
                    { 54033, 5483, 5403 },
                    { 55001, 5511, 5500 },
                    { 55002, 5551, 5500 },
                    { 55003, 5591, 5500 },
                    { 55011, 5511, 5501 },
                    { 55012, 5551, 5501 },
                    { 55013, 5592, 5501 },
                    { 55021, 5511, 5502 },
                    { 55022, 5553, 5502 },
                    { 55023, 5591, 5502 },
                    { 55031, 5515, 5503 },
                    { 55032, 5553, 5503 },
                    { 55033, 5592, 5503 },
                    { 56001, 5611, 5600 },
                    { 56002, 5651, 5600 },
                    { 56003, 5661, 5600 },
                    { 56004, 5671, 5600 },
                    { 56011, 5611, 5601 },
                    { 56012, 5652, 5601 },
                    { 56013, 5661, 5601 },
                    { 56014, 5671, 5601 },
                    { 56021, 5614, 5602 },
                    { 56022, 5652, 5602 },
                    { 56023, 5661, 5602 },
                    { 56024, 5672, 5602 },
                    { 56031, 5614, 5603 },
                    { 56032, 5651, 5603 },
                    { 56033, 5662, 5603 },
                    { 56034, 5671, 5603 },
                    { 57001, 5711, 5700 },
                    { 57002, 5752, 5700 },
                    { 57003, 5763, 5700 },
                    { 57004, 5781, 5700 },
                    { 57011, 5711, 5701 },
                    { 57012, 5753, 5701 },
                    { 57013, 5763, 5701 },
                    { 57014, 5782, 5701 },
                    { 57021, 5714, 5702 },
                    { 57022, 5752, 5702 },
                    { 57023, 5764, 5702 },
                    { 57024, 5781, 5702 },
                    { 57031, 5714, 5703 },
                    { 57032, 5753, 5703 },
                    { 57033, 5764, 5703 },
                    { 57034, 5782, 5703 },
                    { 58001, 5811, 5800 },
                    { 58002, 5851, 5800 },
                    { 58003, 5861, 5800 },
                    { 58004, 5871, 5800 },
                    { 58011, 5811, 5801 },
                    { 58012, 5852, 5801 },
                    { 58013, 5861, 5801 },
                    { 58014, 5871, 5801 },
                    { 58021, 5814, 5802 },
                    { 58022, 5852, 5802 },
                    { 58023, 5861, 5802 },
                    { 58024, 5872, 5802 },
                    { 58031, 5814, 5803 },
                    { 58032, 5851, 5803 },
                    { 58033, 5862, 5803 },
                    { 58034, 5871, 5803 },
                    { 59001, 5911, 5900 },
                    { 59002, 5965, 5900 },
                    { 59003, 5983, 5900 },
                    { 59011, 5911, 5901 },
                    { 59012, 5965, 5901 },
                    { 59013, 5984, 5901 },
                    { 59021, 5915, 5902 },
                    { 59022, 5965, 5902 },
                    { 59023, 5984, 5902 },
                    { 59031, 5915, 5903 },
                    { 59032, 5966, 5903 },
                    { 59033, 5983, 5903 },
                    { 71001, 7111, 7100 },
                    { 71002, 7151, 7100 },
                    { 71003, 7161, 7100 },
                    { 71004, 7171, 7100 },
                    { 71011, 7111, 7101 },
                    { 71012, 7152, 7101 },
                    { 71013, 7161, 7101 },
                    { 71014, 7171, 7101 },
                    { 71021, 7114, 7102 },
                    { 71022, 7152, 7102 },
                    { 71023, 7161, 7102 },
                    { 71024, 7172, 7102 },
                    { 71031, 7114, 7103 },
                    { 71032, 7151, 7103 },
                    { 71033, 7162, 7103 },
                    { 71034, 7171, 7103 },
                    { 72001, 7211, 7200 },
                    { 72002, 7252, 7200 },
                    { 72003, 7283, 7200 },
                    { 72011, 7211, 7201 },
                    { 72012, 7252, 7201 },
                    { 72013, 7284, 7201 },
                    { 72021, 7214, 7202 },
                    { 72022, 7252, 7202 },
                    { 72023, 7284, 7202 },
                    { 72031, 7214, 7203 },
                    { 72032, 7251, 7203 },
                    { 72033, 7283, 7203 },
                    { 73001, 7311, 7300 },
                    { 73002, 7365, 7300 },
                    { 73003, 7383, 7300 },
                    { 73011, 7311, 7301 },
                    { 73012, 7365, 7301 },
                    { 73013, 7384, 7301 },
                    { 73021, 7315, 7302 },
                    { 73022, 7365, 7302 },
                    { 73023, 7384, 7302 },
                    { 73031, 7315, 7303 },
                    { 73032, 7366, 7303 },
                    { 73033, 7383, 7303 },
                    { 74001, 7411, 7400 },
                    { 74002, 7451, 7400 },
                    { 74003, 7491, 7400 },
                    { 74011, 7411, 7401 },
                    { 74012, 7451, 7401 },
                    { 74013, 7492, 7401 },
                    { 74021, 7411, 7402 },
                    { 74022, 7453, 7402 },
                    { 74023, 7491, 7402 },
                    { 74031, 7415, 7403 },
                    { 74032, 7453, 7403 },
                    { 74033, 7492, 7403 },
                    { 75001, 7511, 7500 },
                    { 75002, 7552, 7500 },
                    { 75003, 7563, 7500 },
                    { 75004, 7581, 7500 },
                    { 75011, 7511, 7501 },
                    { 75012, 7553, 7501 },
                    { 75013, 7563, 7501 },
                    { 75014, 7582, 7501 },
                    { 75021, 7514, 7502 },
                    { 75022, 7552, 7502 },
                    { 75023, 7564, 7502 },
                    { 75024, 7581, 7502 },
                    { 75031, 7514, 7503 },
                    { 75032, 7553, 7503 },
                    { 75033, 7564, 7503 },
                    { 75034, 7582, 7503 },
                    { 76001, 7611, 7600 },
                    { 76002, 7651, 7600 },
                    { 76003, 7661, 7600 },
                    { 76004, 7671, 7600 },
                    { 76011, 7611, 7601 },
                    { 76012, 7652, 7601 },
                    { 76013, 7661, 7601 },
                    { 76014, 7671, 7601 },
                    { 76021, 7614, 7602 },
                    { 76022, 7652, 7602 },
                    { 76023, 7661, 7602 },
                    { 76024, 7672, 7602 },
                    { 76031, 7614, 7603 },
                    { 76032, 7651, 7603 },
                    { 76033, 7662, 7603 },
                    { 76034, 7671, 7603 },
                    { 77001, 7711, 7700 },
                    { 77002, 7752, 7700 },
                    { 77003, 7763, 7700 },
                    { 77004, 7781, 7700 },
                    { 77011, 7711, 7701 },
                    { 77012, 7753, 7701 },
                    { 77013, 7763, 7701 },
                    { 77014, 7782, 7701 },
                    { 77021, 7714, 7702 },
                    { 77022, 7752, 7702 },
                    { 77023, 7764, 7702 },
                    { 77024, 7781, 7702 },
                    { 77031, 7714, 7703 },
                    { 77032, 7753, 7703 },
                    { 77033, 7764, 7703 },
                    { 77034, 7782, 7703 },
                    { 78001, 7811, 7800 },
                    { 78002, 7851, 7800 },
                    { 78003, 7861, 7800 },
                    { 78004, 7871, 7800 },
                    { 78011, 7811, 7801 },
                    { 78012, 7852, 7801 },
                    { 78013, 7861, 7801 },
                    { 78014, 7871, 7801 },
                    { 78021, 7814, 7802 },
                    { 78022, 7852, 7802 },
                    { 78023, 7861, 7802 },
                    { 78024, 7872, 7802 },
                    { 78031, 7814, 7803 },
                    { 78032, 7851, 7803 },
                    { 78033, 7862, 7803 },
                    { 78034, 7871, 7803 },
                    { 79001, 7911, 7900 },
                    { 79002, 7951, 7900 },
                    { 79003, 7991, 7900 },
                    { 79011, 7911, 7901 },
                    { 79012, 7951, 7901 },
                    { 79013, 7992, 7901 },
                    { 79021, 7911, 7902 },
                    { 79022, 7953, 7902 },
                    { 79023, 7991, 7902 },
                    { 79031, 7915, 7903 },
                    { 79032, 7953, 7903 },
                    { 79033, 7992, 7903 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 11001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 11002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 11003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 11004);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 11011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 11012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 11013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 11014);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 11021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 11022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 11023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 11024);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 11031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 11032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 11033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 11034);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 12001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 12002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 12003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 12004);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 12011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 12012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 12013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 12014);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 12021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 12022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 12023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 12024);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 12031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 12032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 12033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 12034);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 13001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 13002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 13003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 13011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 13012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 13013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 13021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 13022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 13023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 13031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 13032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 13033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 14001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 14002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 14003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 14011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 14012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 14013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 14021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 14022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 14023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 14031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 14032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 14033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 15001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 15002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 15003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 15011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 15012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 15013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 15021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 15022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 15023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 15031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 15032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 15033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 16001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 16002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 16003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 16004);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 16011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 16012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 16013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 16014);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 16021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 16022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 16023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 16024);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 16031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 16032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 16033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 16034);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 17001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 17002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 17003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 17004);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 17011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 17012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 17013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 17014);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 17021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 17022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 17023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 17024);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 17031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 17032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 17033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 17034);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 18001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 18002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 18003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 18011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 18012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 18013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 18021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 18022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 18023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 18031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 18032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 18033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 19001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 19002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 19003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 19011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 19012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 19013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 19021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 19022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 19023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 19031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 19032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 19033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 31001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 31002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 31003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 31004);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 31011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 31012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 31013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 31014);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 31021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 31022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 31023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 31024);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 31031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 31032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 31033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 31034);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 32001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 32002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 32003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 32004);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 32011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 32012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 32013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 32014);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 32021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 32022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 32023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 32024);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 32031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 32032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 32033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 32034);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 33001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 33002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 33003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 33011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 33012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 33013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 33021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 33022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 33023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 33031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 33032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 33033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 34001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 34002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 34003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 34011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 34012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 34013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 34021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 34022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 34023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 34031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 34032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 34033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 35001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 35002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 35003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 35011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 35012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 35013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 35021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 35022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 35023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 35031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 35032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 35033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 36001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 36002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 36003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 36004);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 36011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 36012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 36013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 36014);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 36021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 36022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 36023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 36024);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 36031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 36032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 36033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 36034);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 37001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 37002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 37003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 37004);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 37011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 37012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 37013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 37014);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 37021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 37022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 37023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 37024);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 37031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 37032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 37033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 37034);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 38001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 38002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 38003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 38011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 38012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 38013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 38021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 38022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 38023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 38031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 38032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 38033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 39001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 39002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 39003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 39011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 39012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 39013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 39021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 39022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 39023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 39031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 39032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 39033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 51001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 51002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 51003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 51004);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 51011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 51012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 51013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 51014);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 51021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 51022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 51023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 51024);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 51031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 51032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 51033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 51034);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 52001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 52002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 52003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 52004);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 52011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 52012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 52013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 52014);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 52021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 52022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 52023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 52024);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 52031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 52032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 52033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 52034);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 53001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 53002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 53003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 53011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 53012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 53013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 53021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 53022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 53023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 53031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 53032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 53033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 54001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 54002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 54003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 54011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 54012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 54013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 54021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 54022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 54023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 54031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 54032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 54033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 55001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 55002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 55003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 55011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 55012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 55013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 55021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 55022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 55023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 55031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 55032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 55033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 56001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 56002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 56003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 56004);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 56011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 56012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 56013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 56014);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 56021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 56022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 56023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 56024);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 56031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 56032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 56033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 56034);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 57001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 57002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 57003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 57004);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 57011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 57012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 57013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 57014);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 57021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 57022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 57023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 57024);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 57031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 57032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 57033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 57034);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 58001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 58002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 58003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 58004);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 58011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 58012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 58013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 58014);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 58021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 58022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 58023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 58024);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 58031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 58032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 58033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 58034);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 59001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 59002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 59003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 59011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 59012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 59013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 59021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 59022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 59023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 59031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 59032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 59033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 71001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 71002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 71003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 71004);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 71011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 71012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 71013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 71014);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 71021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 71022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 71023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 71024);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 71031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 71032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 71033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 71034);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 72001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 72002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 72003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 72011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 72012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 72013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 72021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 72022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 72023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 72031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 72032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 72033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 73001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 73002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 73003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 73011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 73012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 73013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 73021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 73022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 73023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 73031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 73032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 73033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 74001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 74002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 74003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 74011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 74012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 74013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 74021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 74022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 74023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 74031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 74032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 74033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 75001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 75002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 75003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 75004);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 75011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 75012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 75013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 75014);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 75021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 75022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 75023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 75024);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 75031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 75032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 75033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 75034);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 76001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 76002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 76003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 76004);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 76011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 76012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 76013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 76014);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 76021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 76022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 76023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 76024);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 76031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 76032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 76033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 76034);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 77001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 77002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 77003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 77004);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 77011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 77012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 77013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 77014);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 77021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 77022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 77023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 77024);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 77031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 77032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 77033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 77034);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 78001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 78002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 78003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 78004);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 78011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 78012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 78013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 78014);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 78021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 78022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 78023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 78024);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 78031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 78032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 78033);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 78034);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 79001);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 79002);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 79003);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 79011);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 79012);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 79013);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 79021);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 79022);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 79023);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 79031);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 79032);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptions",
                keyColumn: "Id",
                keyValue: 79033);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1152);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1161);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1162);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1171);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1172);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1211);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1214);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1252);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1253);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1263);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1264);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1281);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1282);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1311);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1315);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1365);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1366);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1383);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1384);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1411);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1415);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1451);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1453);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1491);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1492);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1511);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1514);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1551);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1552);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1583);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1584);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1611);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1614);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1651);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1652);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1661);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1662);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1671);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1672);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1711);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1714);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1752);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1753);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1763);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1764);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1781);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1782);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1811);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1815);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1865);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1866);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1883);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1884);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1911);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1915);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1951);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1953);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1991);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1992);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3111);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3114);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3151);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3152);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3161);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3162);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3171);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3172);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3211);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3214);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3252);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3253);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3263);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3264);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3281);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3282);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3311);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3315);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3365);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3366);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3383);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3384);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3411);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3414);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3451);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3452);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3483);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3484);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3511);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3515);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3551);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3553);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3591);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3592);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3611);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3614);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3651);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3652);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3661);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3662);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3671);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3672);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3711);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3714);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3752);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3753);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3763);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3764);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3781);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3782);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3811);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3815);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3865);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3866);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3883);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3884);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3911);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3915);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3951);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3953);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3991);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 3992);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5111);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5114);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5151);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5152);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5161);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5162);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5171);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5172);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5211);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5214);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5252);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5253);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5263);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5264);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5281);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5282);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5311);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5315);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5365);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5366);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5383);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5384);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5411);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5414);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5451);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5452);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5483);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5484);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5511);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5515);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5551);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5553);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5591);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5592);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5611);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5614);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5651);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5652);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5661);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5662);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5671);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5672);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5711);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5714);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5752);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5753);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5763);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5764);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5781);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5782);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5811);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5814);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5851);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5852);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5861);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5862);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5871);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5872);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5911);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5915);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5965);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5966);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5983);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 5984);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7111);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7114);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7151);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7152);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7161);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7162);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7171);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7172);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7211);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7214);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7251);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7252);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7283);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7284);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7311);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7315);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7365);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7366);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7383);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7384);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7411);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7415);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7451);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7453);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7491);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7492);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7511);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7514);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7552);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7553);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7563);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7564);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7581);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7582);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7611);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7614);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7651);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7652);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7661);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7662);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7671);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7672);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7711);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7714);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7752);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7753);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7763);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7764);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7781);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7782);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7811);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7814);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7851);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7852);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7861);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7862);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7871);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7872);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7911);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7915);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7951);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7953);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7991);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 7992);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1201);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1202);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1203);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1301);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1302);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1303);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1401);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1402);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1403);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1501);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1502);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1503);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1601);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1602);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1603);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1701);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1702);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1703);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1801);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1802);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1803);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1901);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1902);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1903);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3101);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3102);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3103);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3201);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3202);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3203);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3301);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3302);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3303);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3401);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3402);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3403);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3501);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3502);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3503);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3601);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3602);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3603);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3701);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3702);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3703);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3801);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3802);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3803);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3901);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3902);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3903);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5101);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5102);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5103);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5201);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5202);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5203);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5301);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5302);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5303);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5401);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5402);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5403);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5501);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5502);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5503);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5601);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5602);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5603);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5701);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5702);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5703);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5801);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5802);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5803);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5901);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5902);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5903);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7101);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7102);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7103);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7201);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7202);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7203);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7301);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7302);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7303);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7401);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7402);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7403);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7501);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7502);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7503);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7601);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7602);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7603);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7701);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7702);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7703);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7801);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7802);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7803);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7901);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7902);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7903);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "ProductOptionGroups",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1100,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-11-BASE", 25 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1200,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-12-BASE", 40 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1300,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-13-BASE", 30 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1400,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-14-BASE", 20 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1500,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-15-BASE", 14 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1600,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-16-BASE", 18 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1700,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-17-BASE", 22 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1800,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-18-BASE", 26 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1900,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-19-BASE", 28 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3100,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-31-BASE", 22 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3200,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-32-BASE", 38 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3300,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-33-BASE", 24 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3400,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-34-BASE", 16 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3500,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-35-BASE", 28 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3600,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-36-BASE", 18 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3700,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-37-BASE", 30 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3800,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-38-BASE", 26 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3900,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-39-BASE", 20 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5100,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-51-BASE", 30 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5200,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-52-BASE", 48 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5300,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-53-BASE", 24 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5400,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-54-BASE", 18 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5500,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-55-BASE", 28 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5600,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-56-BASE", 32 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5700,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-57-BASE", 35 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5800,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-58-BASE", 22 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5900,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-59-BASE", 26 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7100,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-71-BASE", 24 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7200,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-72-BASE", 12 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7300,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-73-BASE", 26 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7400,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-74-BASE", 18 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7500,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-75-BASE", 18 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7600,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-76-BASE", 16 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7700,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-77-BASE", 28 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7800,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-78-BASE", 16 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7900,
                columns: new[] { "Sku", "StockQuantity" },
                values: new object[] { "PROD-79-BASE", 22 });
        }
    }
}
