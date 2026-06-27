using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectOrangeApi.Migrations
{
    /// <inheritdoc />
    public partial class AddProductPresentationDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FeaturesJson",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<string>(
                name: "WhatsInTheBoxJson",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"iPhone 15 with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "[\"iPhone 15\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Samsung Galaxy S24 with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "[\"Samsung Galaxy S24\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Google Pixel 8 with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "[\"Google Pixel 8\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Xiaomi 14 with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "[\"Xiaomi 14\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"OnePlus 12 with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "[\"OnePlus 12\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"MacBook Air M3 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "[\"MacBook Air M3\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Dell XPS 13 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "[\"Dell XPS 13\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Lenovo ThinkPad X1 Carbon built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "[\"Lenovo ThinkPad X1 Carbon\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"ASUS ROG Zephyrus G14 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "[\"ASUS ROG Zephyrus G14\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Acer Swift Go 14 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "[\"Acer Swift Go 14\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Mechanical Keyboard ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"Mechanical Keyboard\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Wireless Mouse ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"Wireless Mouse\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"USB-C Hub ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"USB-C Hub\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Laptop Stand ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"Laptop Stand\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Noise Cancelling Headphones ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"Noise Cancelling Headphones\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Bluetooth Speaker ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"Bluetooth Speaker\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Webcam 1080p ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"Webcam 1080p\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"External SSD 1TB ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"External SSD 1TB\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Power Bank 20000mAh ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"Power Bank 20000mAh\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"27-inch Monitor with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "[\"27-inch Monitor\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"iPhone 15 Pro with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "[\"iPhone 15 Pro\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Samsung Galaxy A55 5G with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "[\"Samsung Galaxy A55 5G\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Fairphone 5 with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "[\"Fairphone 5\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Nothing Phone (2a) with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "[\"Nothing Phone (2a)\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Xiaomi Redmi Note 13 Pro with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "[\"Xiaomi Redmi Note 13 Pro\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"MacBook Pro 14 M3 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "[\"MacBook Pro 14 M3\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Surface Laptop 6 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "[\"Surface Laptop 6\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"HP Spectre x360 14 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "[\"HP Spectre x360 14\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"ASUS Zenbook 14 OLED built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "[\"ASUS Zenbook 14 OLED\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Lenovo Yoga Slim 7 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "[\"Lenovo Yoga Slim 7\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Chargeur MagSafe ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"Chargeur MagSafe\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Adaptateur USB-C Europe ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"Adaptateur USB-C Europe\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Clavier AZERTY Bluetooth ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"Clavier AZERTY Bluetooth\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Souris Ergonomique ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"Souris Ergonomique\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Casque Audio ANC ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"Casque Audio ANC\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Station USB-C 8-en-1 ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"Station USB-C 8-en-1\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Housse Laptop 14 pouces ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"Housse Laptop 14 pouces\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"SSD Externe 2 To ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"SSD Externe 2 To\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Batterie Externe 10000mAh ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"Batterie Externe 10000mAh\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Moniteur 27 pouces QHD with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "[\"Moniteur 27 pouces QHD\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Huawei Mate 60 Pro with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "[\"Huawei Mate 60 Pro\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Xiaomi 14 Ultra with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "[\"Xiaomi 14 Ultra\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Honor Magic6 Pro with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "[\"Honor Magic6 Pro\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"vivo X100 with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "[\"vivo X100\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"OPPO Find X7 with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "[\"OPPO Find X7\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Huawei MateBook X Pro built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "[\"Huawei MateBook X Pro\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Lenovo Xiaoxin Pro 14 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "[\"Lenovo Xiaoxin Pro 14\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Xiaomi Notebook Pro 16 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "[\"Xiaomi Notebook Pro 16\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Honor MagicBook 14 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "[\"Honor MagicBook 14\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"ASUS Tianxuan Air built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "[\"ASUS Tianxuan Air\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"120W GaN Charger ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"120W GaN Charger\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"USB-C Braided Cable ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"USB-C Braided Cable\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"True Wireless Earbuds Pro ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"True Wireless Earbuds Pro\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Magnetic Phone Stand ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"Magnetic Phone Stand\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Wi-Fi 6 Router ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"Wi-Fi 6 Router\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Portable SSD 1TB ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"Portable SSD 1TB\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Gaming Mouse ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"Gaming Mouse\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Mechanical Keyboard 87-Key ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"Mechanical Keyboard 87-Key\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"20000mAh Power Bank ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"20000mAh Power Bank\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"27\\u82F1\\u5BF8 2K\\u663E\\u793A\\u5668 with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "[\"27\\u82F1\\u5BF8 2K\\u663E\\u793A\\u5668\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"iPhone 15 with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "[\"iPhone 15\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Sony Xperia 1 VI with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "[\"Sony Xperia 1 VI\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Google Pixel 8a with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "[\"Google Pixel 8a\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Sharp AQUOS R9 with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "[\"Sharp AQUOS R9\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Galaxy Z Flip6 with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "[\"Galaxy Z Flip6\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"VAIO SX14 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "[\"VAIO SX14\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Panasonic Let\\u0027s note FV5 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "[\"Panasonic Let\\u0027s note FV5\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"MacBook Air M3 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "[\"MacBook Air M3\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Dynabook RZ built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "[\"Dynabook RZ\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"ThinkPad X13 Gen 5 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "[\"ThinkPad X13 Gen 5\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Anker Nano Charger ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"Anker Nano Charger\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Sony WH-1000XM5 ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"Sony WH-1000XM5\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"USB-C Multiport Adapter ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"USB-C Multiport Adapter\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Laptop Sleeve 13-inch ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"Laptop Sleeve 13-inch\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Wireless Trackball Mouse ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"Wireless Trackball Mouse\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Portable SSD 1TB ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"Portable SSD 1TB\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Desk Monitor Light ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"Desk Monitor Light\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Compact Mechanical Keyboard ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"Compact Mechanical Keyboard\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Power Bank 10000mAh ready for everyday use\",\"Simple setup\",\"Covered by standard manufacturer warranty\"]", "[\"Power Bank 10000mAh\",\"Quick start guide\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"27\\u30A4\\u30F3\\u30C1 QHD \\u30E2\\u30CB\\u30BF\\u30FC with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "[\"27\\u30A4\\u30F3\\u30C1 QHD \\u30E2\\u30CB\\u30BF\\u30FC\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"24-inch FHD Monitor with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "[\"24-inch FHD Monitor\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Moniteur 24 pouces FHD with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "[\"Moniteur 24 pouces FHD\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"24\\u82F1\\u5BF8 \\u5168\\u9AD8\\u6E05\\u663E\\u793A\\u5668 with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "[\"24\\u82F1\\u5BF8 \\u5168\\u9AD8\\u6E05\\u663E\\u793A\\u5668\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"24\\u30A4\\u30F3\\u30C1 FHD \\u30E2\\u30CB\\u30BF\\u30FC with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "[\"24\\u30A4\\u30F3\\u30C1 FHD \\u30E2\\u30CB\\u30BF\\u30FC\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"32-inch 4K Monitor with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "[\"32-inch 4K Monitor\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Moniteur 32 pouces 4K with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "[\"Moniteur 32 pouces 4K\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"32\\u82F1\\u5BF8 4K\\u663E\\u793A\\u5668 with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "[\"32\\u82F1\\u5BF8 4K\\u663E\\u793A\\u5668\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"32\\u30A4\\u30F3\\u30C1 4K \\u30E2\\u30CB\\u30BF\\u30FC with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "[\"32\\u30A4\\u30F3\\u30C1 4K \\u30E2\\u30CB\\u30BF\\u30FC\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"34-inch Ultrawide Monitor with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "[\"34-inch Ultrawide Monitor\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"Moniteur Ultrawide 34 pouces with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "[\"Moniteur Ultrawide 34 pouces\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"34\\u82F1\\u5BF8 \\u5E26\\u9C7C\\u5C4F\\u663E\\u793A\\u5668 with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "[\"34\\u82F1\\u5BF8 \\u5E26\\u9C7C\\u5C4F\\u663E\\u793A\\u5668\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "FeaturesJson", "WhatsInTheBoxJson" },
                values: new object[] { "[\"34\\u30A4\\u30F3\\u30C1 \\u30A6\\u30EB\\u30C8\\u30E9\\u30EF\\u30A4\\u30C9\\u30E2\\u30CB\\u30BF\\u30FC with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "[\"34\\u30A4\\u30F3\\u30C1 \\u30A6\\u30EB\\u30C8\\u30E9\\u30EF\\u30A4\\u30C9\\u30E2\\u30CB\\u30BF\\u30FC\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeaturesJson",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "WhatsInTheBoxJson",
                table: "Products");
        }
    }
}
