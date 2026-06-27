using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectOrangeApi.Migrations
{
    /// <inheritdoc />
    public partial class MakeSiteProductsDistinct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Apple smartphone with all-day battery life.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Android flagship smartphone with Galaxy AI features.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Google AI smartphone with clean Android software.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "High-performance Android phone with Leica-tuned cameras.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Fast charging flagship phone with a smooth display.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Lightweight Apple laptop for everyday productivity.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Premium Windows ultrabook with a compact build.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Business laptop with durable carbon-fiber design.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Portable gaming laptop with high-refresh display.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Portable productivity laptop for students and professionals.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "Compact RGB mechanical keyboard.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "Ergonomic wireless mouse for work and gaming.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "Multi-port USB-C adapter for laptops and tablets.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "Aluminum adjustable stand for better desk ergonomics.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "Wireless over-ear headphones with active noise cancelling.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "Portable speaker with splash resistance.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "Description",
                value: "Full HD webcam for video meetings.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "Portable high-speed SSD for file backups.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "Description",
                value: "Fast-charging power bank for phones and tablets.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "Description",
                value: "QHD productivity monitor for hybrid work.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Smartphone Apple en titane avec puce A17 Pro.", "iPhone 15 Pro", 1229m, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Smartphone 5G avec ecran AMOLED et grande autonomie.", "Samsung Galaxy A55 5G", 499m, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Smartphone durable concu pour etre repare plus facilement.", "Fairphone 5", 699m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Smartphone Android au design Glyph distinctif.", "Nothing Phone (2a)", 349m, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Smartphone photo 200 MP avec charge rapide.", "Xiaomi Redmi Note 13 Pro", 399m, 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Ordinateur portable Apple pour les flux creatifs exigeants.", "MacBook Pro 14 M3", 1999m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "PC portable professionnel avec Windows 11 Pro.", "Surface Laptop 6", 1499m, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "PC convertible OLED pour travail mobile.", "HP Spectre x360 14", 1599m, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Ultrabook OLED leger avec processeur Intel Core Ultra.", "ASUS Zenbook 14 OLED", 1199m, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Portable fin et silencieux pour productivite quotidienne.", "Lenovo Yoga Slim 7", 999m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Chargeur magnetique compatible iPhone.", "Chargeur MagSafe", 49m, 35 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Chargeur secteur USB-C compact pour prise europeenne.", "Adaptateur USB-C Europe", 29m, 45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Clavier sans fil AZERTY pour bureau et tablette.", "Clavier AZERTY Bluetooth", 79m, 24 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Souris sans fil concue pour une utilisation prolongee.", "Souris Ergonomique", 59m, 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Casque Bluetooth avec reduction active du bruit.", "Casque Audio ANC", 199m, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Station compacte avec HDMI, Ethernet et ports USB.", "Station USB-C 8-en-1", 89m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Housse rembourree pour ordinateur portable.", "Housse Laptop 14 pouces", 39m, 28 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Stockage externe rapide pour photos et videos.", "SSD Externe 2 To", 159m, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Batterie compacte avec USB-C Power Delivery.", "Batterie Externe 10000mAh", 39m, 32 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Ecran bureautique Full HD avec pied reglable.", "Moniteur 24 pouces FHD", 179m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "High-end smartphone with advanced mobile photography.", "Huawei Mate 60 Pro", 6999m, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Flagship camera phone with Leica optics.", "Xiaomi 14 Ultra", 6499m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Premium Android phone with long battery life.", "Honor Magic6 Pro", 5699m, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Imaging-focused phone with Zeiss camera tuning.", "vivo X100", 3999m, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Slim flagship phone with fast charging.", "OPPO Find X7", 4299m, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Lightweight premium laptop with high-resolution display.", "Huawei MateBook X Pro", 9999m, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Portable productivity laptop with strong performance.", "Lenovo Xiaoxin Pro 14", 5799m, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Large-screen laptop for work and entertainment.", "Xiaomi Notebook Pro 16", 6999m, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Everyday laptop with long battery life.", "Honor MagicBook 14", 4999m, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Thin gaming laptop with dedicated graphics.", "ASUS Tianxuan Air", 7499m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Compact high-wattage charger for phones and laptops.", "120W GaN Charger", 249m, 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Durable fast-charging cable.", "USB-C Braided Cable", 49m, 80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Noise-cancelling earbuds for calls and music.", "True Wireless Earbuds Pro", 699m, 24 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Foldable phone stand with magnetic mount.", "Magnetic Phone Stand", 129m, 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Dual-band router for home networks.", "Wi-Fi 6 Router", 399m, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Fast external storage with USB-C.", "Portable SSD 1TB", 599m, 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Low-latency wireless mouse with adjustable DPI.", "Gaming Mouse", 199m, 35 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Compact mechanical keyboard for desktop setups.", "Mechanical Keyboard 87-Key", 329m, 22 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Large-capacity power bank with fast charging.", "20000mAh Power Bank", 199m, 38 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Sharp display for work and gaming.", "27-inch 2K Monitor", 1299m, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Apple smartphone with USB-C and advanced camera features.", 124800m, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Premium Sony smartphone with creator-focused display and camera.", "Sony Xperia 1 VI", 189200m, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Compact Google phone with AI features.", "Google Pixel 8a", 72600m, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Japanese Android phone with bright Pro IGZO OLED display.", "Sharp AQUOS R9", 99800m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Foldable smartphone with compact cover display.", "Galaxy Z Flip6", 159700m, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Lightweight business laptop built for mobility.", "VAIO SX14", 249800m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Durable business laptop with lightweight chassis.", "Panasonic Let's note FV5", 289800m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Silent Apple laptop with all-day battery life.", "MacBook Air M3", 164800m, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Portable laptop for students and professionals.", "Dynabook RZ", 179800m, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Compact business laptop with strong keyboard feel.", "ThinkPad X13 Gen 5", 198000m, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Compact USB-C charger for daily carry.", "Anker Nano Charger", 3990m, 45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Noise-cancelling headphones for commuting and work.", "Sony WH-1000XM5", 59400m, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "HDMI and USB hub for laptops.", "USB-C Multiport Adapter", 6980m, 26 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Slim protective sleeve for mobile work.", "Laptop Sleeve 13-inch", 3480m, 32 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Ergonomic mouse for desk setups.", "Wireless Trackball Mouse", 7980m, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Fast external SSD for photos and documents.", "Portable SSD 1TB", 16800m, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "USB-powered light bar for monitor setups.", "Desk Monitor Light", 5980m, 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Space-saving keyboard with tactile switches.", "Compact Mechanical Keyboard", 12800m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Slim portable battery with USB-C charging.", "Power Bank 10000mAh", 4980m, 36 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "High-resolution display for productivity.", "27-inch 4K Monitor", 54800m, 9 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Apple smartphone");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Android flagship smartphone");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Google AI smartphone");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "High-performance Android phone");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Fast charging flagship phone");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Lightweight Apple laptop");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Premium Windows ultrabook");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Business laptop");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Gaming laptop");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Portable productivity laptop");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "RGB keyboard");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "Ergonomic wireless mouse");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "Multi-port USB-C adapter");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "Aluminum adjustable stand");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "Wireless over-ear headphones");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "Portable speaker");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "Description",
                value: "Full HD webcam");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "Portable high-speed SSD");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "Description",
                value: "Fast-charging power bank");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "Description",
                value: "QHD productivity monitor");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Apple smartphone", "iPhone 15", 999.98m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Android flagship smartphone", "Samsung Galaxy S24", 916.65m, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Google AI smartphone", "Google Pixel 8", 666.65m, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "High-performance Android phone", "Xiaomi 14", 549.98m, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Fast charging flagship phone", "OnePlus 12", 766.65m, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Lightweight Apple laptop", "MacBook Air M3", 1166.65m, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Premium Windows ultrabook", "Dell XPS 13", 1249.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Business laptop", "Lenovo ThinkPad X1 Carbon", 1499.98m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Gaming laptop", "ASUS ROG Zephyrus G14", 1583.32m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Portable productivity laptop", "Acer Swift Go 14", 666.65m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "RGB keyboard", "Mechanical Keyboard", 58.33m, 25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Ergonomic wireless mouse", "Wireless Mouse", 20m, 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Multi-port USB-C adapter", "USB-C Hub", 30m, 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Aluminum adjustable stand", "Laptop Stand", 25m, 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Wireless over-ear headphones", "Noise Cancelling Headphones", 149.98m, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Portable speaker", "Bluetooth Speaker", 41.67m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Full HD webcam", "Webcam 1080p", 36.67m, 22 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Portable high-speed SSD", "External SSD 1TB", 108.33m, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Fast-charging power bank", "Power Bank 20000mAh", 33.33m, 28 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "QHD productivity monitor", "27-inch Monitor", 216.65m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Apple smartphone", "iPhone 15", 7692.18m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Android flagship smartphone", "Samsung Galaxy S24", 7051.15m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Google AI smartphone", "Google Pixel 8", 5128.08m, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "High-performance Android phone", "Xiaomi 14", 4230.64m, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Fast charging flagship phone", "OnePlus 12", 5897.31m, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Lightweight Apple laptop", "MacBook Air M3", 8974.23m, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Premium Windows ultrabook", "Dell XPS 13", 9615.26m, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Business laptop", "Lenovo ThinkPad X1 Carbon", 11538.33m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Gaming laptop", "ASUS ROG Zephyrus G14", 12179.36m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Portable productivity laptop", "Acer Swift Go 14", 5128.08m, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "RGB keyboard", "Mechanical Keyboard", 448.72m, 25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Ergonomic wireless mouse", "Wireless Mouse", 153.85m, 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Multi-port USB-C adapter", "USB-C Hub", 230.77m, 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Aluminum adjustable stand", "Laptop Stand", 192.31m, 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Wireless over-ear headphones", "Noise Cancelling Headphones", 1153.72m, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Portable speaker", "Bluetooth Speaker", 320.51m, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Full HD webcam", "Webcam 1080p", 282.05m, 22 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Portable high-speed SSD", "External SSD 1TB", 833.33m, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Fast-charging power bank", "Power Bank 20000mAh", 256.41m, 28 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "QHD productivity monitor", "27-inch Monitor", 1666.54m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Description", "Price", "StockQuantity" },
                values: new object[] { "Apple smartphone", 161997m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Android flagship smartphone", "Samsung Galaxy S24", 148497m, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Google AI smartphone", "Google Pixel 8", 107997m, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "High-performance Android phone", "Xiaomi 14", 89097m, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Fast charging flagship phone", "OnePlus 12", 124197m, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Lightweight Apple laptop", "MacBook Air M3", 188997m, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Premium Windows ultrabook", "Dell XPS 13", 202497m, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Business laptop", "Lenovo ThinkPad X1 Carbon", 242997m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Gaming laptop", "ASUS ROG Zephyrus G14", 256497m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Portable productivity laptop", "Acer Swift Go 14", 107997m, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "RGB keyboard", "Mechanical Keyboard", 9450m, 25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Ergonomic wireless mouse", "Wireless Mouse", 3240m, 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Multi-port USB-C adapter", "USB-C Hub", 4860m, 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Aluminum adjustable stand", "Laptop Stand", 4050m, 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Wireless over-ear headphones", "Noise Cancelling Headphones", 24297m, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Portable speaker", "Bluetooth Speaker", 6750m, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Full HD webcam", "Webcam 1080p", 5940m, 22 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Portable high-speed SSD", "External SSD 1TB", 17550m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "Fast-charging power bank", "Power Bank 20000mAh", 5400m, 28 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { "QHD productivity monitor", "27-inch Monitor", 35097m, 10 });
        }
    }
}
