using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectOrangeApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAccessorySubcategorySeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1300,
                column: "Price",
                value: 2999m);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1400,
                column: "Price",
                value: 2499m);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1600,
                column: "Price",
                value: 2200m);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1700,
                column: "Price",
                value: 1700m);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1800,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 2499m, 26 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1900,
                column: "Price",
                value: 1999m);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3100,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 109m, 22 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3200,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 39m, 38 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3300,
                column: "Price",
                value: 129m);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3400,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 199m, 16 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3500,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 79m, 28 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3600,
                column: "Price",
                value: 69m);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3700,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 59m, 30 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3800,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 89m, 26 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3900,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 99m, 20 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5100,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 329m, 30 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5200,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 99m, 48 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5400,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 899m, 18 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5500,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 299m, 28 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5600,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 199m, 32 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5900,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 499m, 26 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7100,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 8980m, 24 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7300,
                column: "Price",
                value: 12800m);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7400,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 9980m, 18 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7600,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 14800m, 16 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7700,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 4980m, 28 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7900,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 11800m, 22 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Pocket-sized earbuds with clear calls and touch controls.", "[\"True Wireless Earbuds ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "True Wireless Earbuds", 2999m, "Earbuds", "[\"True Wireless Earbuds\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Wired gaming headset with a noise-reducing boom mic.", "[\"Gaming Headset ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Gaming Headset", 2499m, "Headset", "[\"Gaming Headset\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Slim wireless keyboard for tablets and desktop setups.", "[\"Bluetooth Keyboard ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Bluetooth Keyboard", 2200m, "Keyboard", "[\"Bluetooth Keyboard\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Low-latency mouse with adjustable DPI for work and gaming.", "[\"Precision Wireless Mouse ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Precision Wireless Mouse", 1700m, "Mouse", "[\"Precision Wireless Mouse\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Sweat-resistant earbuds with secure-fit tips.", "[\"Sport Earbuds ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Sport Earbuds", 2499m, 26, "Earbuds", "[\"Sport Earbuds\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Lightweight headset with inline controls for meetings.", "[\"USB-C Office Headset ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "USB-C Office Headset", 1999m, "Headset", "[\"USB-C Office Headset\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Clavier mécanique rétroéclairé pour bureau et jeu.", "[\"Clavier M\\u00E9canique AZERTY ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Clavier Mécanique AZERTY", 109m, 22, "Keyboard", "[\"Clavier M\\u00E9canique AZERTY\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Souris sans fil compacte pour ordinateur portable et tablette.", "[\"Souris Bluetooth Compacte ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Souris Bluetooth Compacte", 39m, 38, "Mouse", "[\"Souris Bluetooth Compacte\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Écouteurs Bluetooth avec réduction du bruit et boîtier de charge.", "[\"\\u00C9couteurs Sans Fil Pro ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Écouteurs Sans Fil Pro", 129m, "Earbuds", "[\"\\u00C9couteurs Sans Fil Pro\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Casque sans fil confortable avec réduction active du bruit.", "[\"Casque Audio Circum-Aural ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Casque Audio Circum-Aural", 199m, 16, "Headphones", "[\"Casque Audio Circum-Aural\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Micro-casque léger pour appels vidéo et travail hybride.", "[\"Micro-Casque USB-C ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Micro-Casque USB-C", 79m, 28, "Headset", "[\"Micro-Casque USB-C\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Clavier sans fil fin pour bureau et tablette.", "[\"Clavier Bluetooth Compact ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Clavier Bluetooth Compact", 69m, "Keyboard", "[\"Clavier Bluetooth Compact\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Souris basse latence avec DPI réglable.", "[\"Souris Gaming Sans Fil ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Souris Gaming Sans Fil", 59m, 30, "Mouse", "[\"Souris Gaming Sans Fil\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Écouteurs résistants à la transpiration avec maintien sécurisé.", "[\"\\u00C9couteurs Sport ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Écouteurs Sport", 89m, 26, "Earbuds", "[\"\\u00C9couteurs Sport\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Micro-casque gaming avec micro perche et son immersif.", "[\"Micro-Casque Gaming RGB ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Micro-Casque Gaming RGB", 99m, 20, "Headset", "[\"Micro-Casque Gaming RGB\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "紧凑型低轴机械键盘，适合办公和游戏。", "[\"Low-Profile Mechanical Keyboard ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Low-Profile Mechanical Keyboard", 329m, 30, "Keyboard", "[\"Low-Profile Mechanical Keyboard\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "静音无线鼠标，适合办公和学习。", "[\"Silent Wireless Mouse ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Silent Wireless Mouse", 99m, 48, "Mouse", "[\"Silent Wireless Mouse\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "无线头戴式耳机，支持主动降噪。", "[\"ANC Headphones ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "ANC Headphones", 899m, 18, "Headphones", "[\"ANC Headphones\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "带麦克风的游戏耳麦，适合语音通话和电竞。", "[\"USB-C Gaming Headset ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "USB-C Gaming Headset", 299m, 28, "Headset", "[\"USB-C Gaming Headset\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "便携蓝牙键盘，适合平板和桌面使用。", "[\"Compact Bluetooth Keyboard ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Compact Bluetooth Keyboard", 199m, 32, "Keyboard", "[\"Compact Bluetooth Keyboard\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "开放式蓝牙耳机，佩戴轻便舒适。", "[\"Open-Ear Earbuds ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Open-Ear Earbuds", 499m, 26, "Earbuds", "[\"Open-Ear Earbuds\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "省スペースで使える薄型 Bluetooth キーボード。", "[\"Compact Bluetooth Keyboard ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Compact Bluetooth Keyboard", 8980m, 24, "Keyboard", "[\"Compact Bluetooth Keyboard\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "通話と音楽に使いやすい完全ワイヤレスイヤホン。", "[\"Wireless Earbuds ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Wireless Earbuds", 12800m, "Earbuds", "[\"Wireless Earbuds\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "着脱式マイク付きの USB-C ゲーミングヘッドセット。", "[\"USB-C Gaming Headset ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "USB-C Gaming Headset", 9980m, 18, "Headset", "[\"USB-C Gaming Headset\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "持ち運びしやすいコンパクトなメカニカルキーボード。", "[\"Portable Mechanical Keyboard ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Portable Mechanical Keyboard", 14800m, 16, "Keyboard", "[\"Portable Mechanical Keyboard\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "クリック音を抑えた薄型ワイヤレスマウス。", "[\"Silent Wireless Mouse ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Silent Wireless Mouse", 4980m, 28, "Mouse", "[\"Silent Wireless Mouse\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "オンライン会議向けの軽量ワイヤレスヘッドセット。", "[\"Work Headset ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Work Headset", 11800m, 22, "Headset", "[\"Work Headset\",\"Quick start guide\"]" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1300,
                column: "Price",
                value: 1800m);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1400,
                column: "Price",
                value: 1500m);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1600,
                column: "Price",
                value: 2500m);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1700,
                column: "Price",
                value: 2200m);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1800,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 6500m, 16 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1900,
                column: "Price",
                value: 2000m);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3100,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 49m, 35 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3200,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 29m, 45 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3300,
                column: "Price",
                value: 79m);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3400,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 59m, 30 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3500,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 199m, 13 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3600,
                column: "Price",
                value: 89m);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3700,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 39m, 28 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3800,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 159m, 12 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3900,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 39m, 32 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5100,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 249m, 40 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5200,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 49m, 80 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5400,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 129m, 30 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5500,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 399m, 18 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5600,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 599m, 20 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5900,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 199m, 38 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7100,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 3990m, 45 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7300,
                column: "Price",
                value: 6980m);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7400,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 3480m, 32 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7600,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 16800m, 14 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7700,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 5980m, 20 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7900,
                columns: new[] { "Price", "StockQuantity" },
                values: new object[] { 4980m, 36 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Multi-port USB-C adapter for laptops and tablets.", "[\"USB-C Hub ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "USB-C Hub", 1800m, "", "[\"USB-C Hub\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Aluminum adjustable stand for better desk ergonomics.", "[\"Laptop Stand ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Laptop Stand", 1500m, "", "[\"Laptop Stand\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Portable speaker with splash resistance.", "[\"Bluetooth Speaker ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Bluetooth Speaker", 2500m, "", "[\"Bluetooth Speaker\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Full HD webcam for video meetings.", "[\"Webcam 1080p ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Webcam 1080p", 2200m, "", "[\"Webcam 1080p\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Portable high-speed SSD for file backups.", "[\"External SSD 1TB ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "External SSD 1TB", 6500m, 16, "", "[\"External SSD 1TB\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Fast-charging power bank for phones and tablets.", "[\"Power Bank 20000mAh ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Power Bank 20000mAh", 2000m, "", "[\"Power Bank 20000mAh\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Chargeur magnétique compatible avec l’iPhone.", "[\"Chargeur MagSafe ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Chargeur MagSafe", 49m, 35, "", "[\"Chargeur MagSafe\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Chargeur secteur USB-C compact pour prise européenne.", "[\"Adaptateur USB-C Europe ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Adaptateur USB-C Europe", 29m, 45, "", "[\"Adaptateur USB-C Europe\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Clavier sans fil AZERTY pour bureau et tablette.", "[\"Clavier AZERTY Bluetooth ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Clavier AZERTY Bluetooth", 79m, "Keyboard", "[\"Clavier AZERTY Bluetooth\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Souris sans fil conçue pour une utilisation prolongée.", "[\"Souris Ergonomique ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Souris Ergonomique", 59m, 30, "Mouse", "[\"Souris Ergonomique\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Casque Bluetooth avec réduction active du bruit.", "[\"Casque Audio ANC ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Casque Audio ANC", 199m, 13, "Headphones", "[\"Casque Audio ANC\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Station compacte avec HDMI, Ethernet et ports USB.", "[\"Station USB-C 8-en-1 ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Station USB-C 8-en-1", 89m, "", "[\"Station USB-C 8-en-1\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Housse rembourrée pour ordinateur portable.", "[\"Housse Laptop 14 pouces ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Housse Laptop 14 pouces", 39m, 28, "", "[\"Housse Laptop 14 pouces\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Stockage externe rapide pour photos et vidéos.", "[\"SSD Externe 2 To ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "SSD Externe 2 To", 159m, 12, "", "[\"SSD Externe 2 To\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "Batterie compacte avec USB-C Power Delivery.", "[\"Batterie Externe 10000mAh ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Batterie Externe 10000mAh", 39m, 32, "", "[\"Batterie Externe 10000mAh\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "小巧高功率充电器，适用于手机和笔记本。", "[\"120W GaN Charger ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "120W GaN Charger", 249m, 40, "", "[\"120W GaN Charger\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "耐用编织快充线。", "[\"USB-C Braided Cable ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "USB-C Braided Cable", 49m, 80, "", "[\"USB-C Braided Cable\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "可折叠磁吸手机支架。", "[\"Magnetic Phone Stand ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Magnetic Phone Stand", 129m, 30, "", "[\"Magnetic Phone Stand\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "双频路由器，适合家庭网络。", "[\"Wi-Fi 6 Router ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Wi-Fi 6 Router", 399m, 18, "", "[\"Wi-Fi 6 Router\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "高速 USB-C 移动固态硬盘。", "[\"Portable SSD 1TB ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Portable SSD 1TB", 599m, 20, "", "[\"Portable SSD 1TB\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "大容量移动电源，支持快速充电。", "[\"20000mAh Power Bank ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "20000mAh Power Bank", 199m, 38, "", "[\"20000mAh Power Bank\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "毎日の持ち歩きに便利な小型 USB-C 充電器。", "[\"Anker Nano Charger ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Anker Nano Charger", 3990m, 45, "", "[\"Anker Nano Charger\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "ノート PC 向けの HDMI・USB 対応マルチポートアダプター。", "[\"USB-C Multiport Adapter ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "USB-C Multiport Adapter", 6980m, "", "[\"USB-C Multiport Adapter\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "外出時に使いやすい薄型ノート PC スリーブ。", "[\"Laptop Sleeve 13-inch ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Laptop Sleeve 13-inch", 3480m, 32, "", "[\"Laptop Sleeve 13-inch\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "写真や書類の保存に便利な高速外付け SSD。", "[\"Portable SSD 1TB ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Portable SSD 1TB", 16800m, 14, "", "[\"Portable SSD 1TB\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "モニター周りを照らす USB 給電式ライトバー。", "[\"Desk Monitor Light ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Desk Monitor Light", 5980m, 20, "", "[\"Desk Monitor Light\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Description", "FeaturesJson", "Name", "Price", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[] { "USB-C 充電対応の薄型モバイルバッテリー。", "[\"Power Bank 10000mAh ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "Power Bank 10000mAh", 4980m, 36, "", "[\"Power Bank 10000mAh\",\"Quick start guide\"]" });
        }
    }
}
