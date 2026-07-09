using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectOrangeApi.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ExpandCountryProductSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "FeaturesJson", "ImageUrl", "Name", "Price", "SiteId", "StockQuantity", "SubcategoryName", "WhatsInTheBoxJson" },
                values: new object[,]
                {
                    { 93, 1, "Midrange 5G phone with a bright AMOLED display and dependable battery.", "[\"Samsung Galaxy A55 5G with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "", "Samsung Galaxy A55 5G", 24999m, 1, 18, "", "[\"Samsung Galaxy A55 5G\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 94, 4, "Smartphone compact avec fonctions photo assistées par IA.", "[\"Google Pixel 8a with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "", "Google Pixel 8a", 549m, 2, 15, "", "[\"Google Pixel 8a\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 95, 7, "影像旗舰手机，配备高亮度屏幕和快速充电。", "[\"Huawei Pura 70 with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "", "Huawei Pura 70", 5499m, 3, 14, "", "[\"Huawei Pura 70\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 96, 10, "軽量ボディと長時間バッテリーを備えたミドルレンジスマートフォン。", "[\"Sony Xperia 10 VI with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "", "Sony Xperia 10 VI", 69300m, 4, 15, "", "[\"Sony Xperia 10 VI\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 97, 1, "Slim 5G smartphone with portrait cameras and fast charging.", "[\"OPPO Reno12 5G with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "", "OPPO Reno12 5G", 28999m, 1, 14, "", "[\"OPPO Reno12 5G\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 98, 4, "Smartphone premium avec écran lumineux et fonctions Galaxy AI.", "[\"Samsung Galaxy S24 with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "", "Samsung Galaxy S24", 899m, 2, 11, "", "[\"Samsung Galaxy S24\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 99, 7, "高性能手机，兼顾流畅游戏与日常使用。", "[\"Xiaomi Redmi K70 with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "", "Xiaomi Redmi K70", 2499m, 3, 22, "", "[\"Xiaomi Redmi K70\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 100, 10, "使いやすさと電池持ちを重視した国産 Android スマートフォン。", "[\"Sharp AQUOS sense9 with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "", "Sharp AQUOS sense9", 64800m, 4, 17, "", "[\"Sharp AQUOS sense9\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 101, 1, "Camera-focused smartphone with a vivid display and long battery life.", "[\"vivo V40 with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "", "vivo V40", 26999m, 1, 16, "", "[\"vivo V40\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 102, 4, "Smartphone 5G orienté portrait avec écran OLED.", "[\"Honor 200 Pro with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "", "Honor 200 Pro", 699m, 2, 12, "", "[\"Honor 200 Pro\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 103, 7, "大电池性能手机，支持快速有线充电。", "[\"OnePlus Ace 3 with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "", "OnePlus Ace 3", 2599m, 3, 19, "", "[\"OnePlus Ace 3\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 104, 10, "高度な AI 機能と高性能カメラを搭載したスマートフォン。", "[\"Google Pixel 9 with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "", "Google Pixel 9", 128900m, 4, 11, "", "[\"Google Pixel 9\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 105, 1, "Performance smartphone with fast charging and a smooth AMOLED screen.", "[\"realme GT 6 with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "", "realme GT 6", 34999m, 1, 11, "", "[\"realme GT 6\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 106, 4, "Smartphone fin avec charge rapide et écran incurvé.", "[\"Motorola Edge 50 Pro with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "", "Motorola Edge 50 Pro", 699m, 2, 13, "", "[\"Motorola Edge 50 Pro\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 107, 7, "面向游戏的智能手机，配备高刷新率屏幕。", "[\"iQOO Neo9 with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "", "iQOO Neo9", 2299m, 3, 20, "", "[\"iQOO Neo9\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 108, 10, "明るいディスプレイと便利な AI 機能を備えたフラッグシップ。", "[\"Galaxy S24 with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "", "Galaxy S24", 124700m, 4, 10, "", "[\"Galaxy S24\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 109, 1, "Portrait-focused 5G phone with a high-resolution OLED display.", "[\"HONOR 200 with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "", "HONOR 200", 29999m, 1, 13, "", "[\"HONOR 200\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 110, 4, "Smartphone fluide avec châssis métallique et grande autonomie.", "[\"OnePlus Nord 4 with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "", "OnePlus Nord 4", 499m, 2, 17, "", "[\"OnePlus Nord 4\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 111, 7, "轻薄直屏手机，提供简洁流畅的使用体验。", "[\"Meizu 21 with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "", "Meizu 21", 3199m, 3, 13, "", "[\"Meizu 21\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 112, 10, "急速充電と大容量バッテリーに対応した 5G スマートフォン。", "[\"OPPO Reno11 A with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "", "OPPO Reno11 A", 48800m, 4, 19, "", "[\"OPPO Reno11 A\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 113, 1, "Distinctive Android smartphone with a clean interface and Glyph design.", "[\"Nothing Phone (2a) with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "", "Nothing Phone (2a)", 22999m, 1, 17, "", "[\"Nothing Phone (2a)\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 114, 4, "Smartphone léger avec écran OLED et autonomie prolongée.", "[\"Sony Xperia 10 VI with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "", "Sony Xperia 10 VI", 399m, 2, 14, "", "[\"Sony Xperia 10 VI\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 115, 7, "高性能 5G 手机，拥有明亮的 AMOLED 屏幕。", "[\"realme GT Neo6 with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "", "realme GT Neo6", 2099m, 3, 21, "", "[\"realme GT Neo6\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 116, 10, "滑らかな有機 EL ディスプレイを備えた薄型スマートフォン。", "[\"motorola edge 50 pro with unlocked connectivity\",\"All-day battery for everyday use\",\"Advanced camera system\",\"Fast USB-C charging support\"]", "", "motorola edge 50 pro", 79800m, 4, 13, "", "[\"motorola edge 50 pro\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 117, 2, "Versatile laptop for school, office work, and daily entertainment.", "[\"Lenovo IdeaPad Slim 5 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "", "Lenovo IdeaPad Slim 5", 45999m, 1, 10, "", "[\"Lenovo IdeaPad Slim 5\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 118, 5, "PC portable polyvalent pour la bureautique et la création.", "[\"Dell Inspiron 14 Plus built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "", "Dell Inspiron 14 Plus", 1099m, 2, 8, "", "[\"Dell Inspiron 14 Plus\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 119, 8, "高性能轻薄笔记本，适合移动创作和办公。", "[\"Lenovo Yoga Pro 14s built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "", "Lenovo Yoga Pro 14s", 7999m, 3, 8, "", "[\"Lenovo Yoga Pro 14s\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 120, 11, "持ち運びに適した超軽量モバイルノート。", "[\"Fujitsu FMV LIFEBOOK UH built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "", "Fujitsu FMV LIFEBOOK UH", 218000m, 4, 7, "", "[\"Fujitsu FMV LIFEBOOK UH\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 121, 2, "Compact productivity laptop with a sharp display and premium finish.", "[\"HP Pavilion Plus 14 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "", "HP Pavilion Plus 14", 57999m, 1, 7, "", "[\"HP Pavilion Plus 14\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 122, 5, "Ultrabook OLED compact pour le travail en déplacement.", "[\"Acer Swift Go 14 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "", "Acer Swift Go 14", 899m, 2, 10, "", "[\"Acer Swift Go 14\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 123, 8, "高分辨率触控屏笔记本，适合日常生产力任务。", "[\"Huawei MateBook 14 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "", "Huawei MateBook 14", 6499m, 3, 10, "", "[\"Huawei MateBook 14\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 124, 11, "家庭学習と日常作業に使いやすい薄型ノート PC。", "[\"NEC LAVIE N14 Slim built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "", "NEC LAVIE N14 Slim", 159800m, 4, 9, "", "[\"NEC LAVIE N14 Slim\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 125, 2, "Thin laptop with a spacious OLED display for mobile productivity.", "[\"ASUS Vivobook S 15 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "", "ASUS Vivobook S 15", 64999m, 1, 8, "", "[\"ASUS Vivobook S 15\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 126, 5, "Ordinateur portable modulaire conçu pour être réparé et amélioré.", "[\"Framework Laptop 13 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "", "Framework Laptop 13", 1349m, 2, 6, "", "[\"Framework Laptop 13\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 127, 8, "金属机身大屏笔记本，兼顾学习与办公。", "[\"Xiaomi RedmiBook Pro 15 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "", "Xiaomi RedmiBook Pro 15", 5499m, 3, 12, "", "[\"Xiaomi RedmiBook Pro 15\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 128, 11, "鮮やかな OLED 画面を搭載した軽量モバイルノート。", "[\"ASUS Zenbook 14 OLED built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "", "ASUS Zenbook 14 OLED", 169800m, 4, 8, "", "[\"ASUS Zenbook 14 OLED\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 129, 2, "Gaming laptop with dedicated graphics and efficient cooling.", "[\"Acer Nitro V 15 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "", "Acer Nitro V 15", 52999m, 1, 6, "", "[\"Acer Nitro V 15\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 130, 5, "Portable professionnel léger avec processeur basse consommation.", "[\"MSI Prestige 14 AI built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "", "MSI Prestige 14 AI", 1299m, 2, 7, "", "[\"MSI Prestige 14 AI\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 131, 8, "大屏高性能笔记本，适合多任务和娱乐。", "[\"Honor MagicBook Pro 16 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "", "Honor MagicBook Pro 16", 6999m, 3, 9, "", "[\"Honor MagicBook Pro 16\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 132, 11, "コンパクトで軽量な日常向けノート PC。", "[\"HP Pavilion Aero 13 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "", "HP Pavilion Aero 13", 139800m, 4, 10, "", "[\"HP Pavilion Aero 13\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 133, 2, "Lightweight everyday laptop for business and study.", "[\"MSI Modern 14 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "", "MSI Modern 14", 34999m, 1, 12, "", "[\"MSI Modern 14\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 134, 5, "Grand ordinateur portable particulièrement léger pour sa taille.", "[\"LG Gram 16 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "", "LG Gram 16", 1599m, 2, 5, "", "[\"LG Gram 16\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 135, 8, "轻量大屏 OLED 笔记本，便于携带。", "[\"Acer Swift Edge 16 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "", "Acer Swift Edge 16", 7299m, 3, 7, "", "[\"Acer Swift Edge 16\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 136, 11, "仕事とクリエイティブ用途に対応する高性能ノート。", "[\"Dell Inspiron 14 Plus built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "", "Dell Inspiron 14 Plus", 179800m, 4, 7, "", "[\"Dell Inspiron 14 Plus\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 137, 2, "Large-screen productivity laptop with a full-size keyboard.", "[\"Huawei MateBook D 16 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "", "Huawei MateBook D 16", 48999m, 1, 9, "", "[\"Huawei MateBook D 16\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 138, 5, "PC portable gaming robuste avec écran à fréquence élevée.", "[\"ASUS TUF Gaming A15 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "", "ASUS TUF Gaming A15", 1199m, 2, 8, "", "[\"ASUS TUF Gaming A15\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 139, 8, "面向设计与办公的便携高性能笔记本。", "[\"MSI Star 15 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "", "MSI Star 15", 6699m, 3, 8, "", "[\"MSI Star 15\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 140, 11, "高リフレッシュレート画面を備えたゲーミングノート。", "[\"Acer Nitro V 15 built for productivity\",\"Portable design for work anywhere\",\"High-resolution display\",\"Fast USB-C charging support\"]", "", "Acer Nitro V 15", 149800m, 4, 6, "", "[\"Acer Nitro V 15\",\"Power adapter\",\"USB-C charge cable\",\"Documentation\"]" },
                    { 141, 13, "Fast IPS gaming display with fluid motion and low input lag.", "[\"27-inch 180Hz Gaming Monitor with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "", "27-inch 180Hz Gaming Monitor", 15999m, 1, 9, "", "[\"27-inch 180Hz Gaming Monitor\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" },
                    { 142, 14, "Écran IPS rapide pour des jeux fluides et réactifs.", "[\"Moniteur Gaming 27 pouces 180 Hz with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "", "Moniteur Gaming 27 pouces 180 Hz", 329m, 2, 9, "", "[\"Moniteur Gaming 27 pouces 180 Hz\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" },
                    { 143, 15, "快速 IPS 电竞屏，提供流畅清晰的动态画面。", "[\"27\\u82F1\\u5BF8 180Hz \\u7535\\u7ADE\\u663E\\u793A\\u5668 with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "", "27英寸 180Hz 电竞显示器", 1599m, 3, 13, "", "[\"27\\u82F1\\u5BF8 180Hz \\u7535\\u7ADE\\u663E\\u793A\\u5668\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" },
                    { 144, 16, "滑らかな映像表示に対応する高速 IPS ゲーミングディスプレイ。", "[\"27\\u30A4\\u30F3\\u30C1 180Hz \\u30B2\\u30FC\\u30DF\\u30F3\\u30B0\\u30E2\\u30CB\\u30BF\\u30FC with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "", "27インチ 180Hz ゲーミングモニター", 49800m, 4, 10, "", "[\"27\\u30A4\\u30F3\\u30C1 180Hz \\u30B2\\u30FC\\u30DF\\u30F3\\u30B0\\u30E2\\u30CB\\u30BF\\u30FC\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" },
                    { 145, 13, "Compact office display with convenient USB-C connectivity.", "[\"24-inch USB-C Office Monitor with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "", "24-inch USB-C Office Monitor", 10999m, 1, 12, "", "[\"24-inch USB-C Office Monitor\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" },
                    { 146, 14, "Écran de bureau compact avec connexion USB-C pratique.", "[\"Moniteur USB-C 24 pouces with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "", "Moniteur USB-C 24 pouces", 249m, 2, 11, "", "[\"Moniteur USB-C 24 pouces\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" },
                    { 147, 15, "支持 USB-C 连接的紧凑办公显示屏。", "[\"24\\u82F1\\u5BF8 USB-C \\u529E\\u516C\\u663E\\u793A\\u5668 with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "", "24英寸 USB-C 办公显示器", 1099m, 3, 16, "", "[\"24\\u82F1\\u5BF8 USB-C \\u529E\\u516C\\u663E\\u793A\\u5668\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" },
                    { 148, 16, "USB-C 接続に対応した省スペースの業務用ディスプレイ。", "[\"24\\u30A4\\u30F3\\u30C1 USB-C \\u30AA\\u30D5\\u30A3\\u30B9\\u30E2\\u30CB\\u30BF\\u30FC with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "", "24インチ USB-C オフィスモニター", 34800m, 4, 12, "", "[\"24\\u30A4\\u30F3\\u30C1 USB-C \\u30AA\\u30D5\\u30A3\\u30B9\\u30E2\\u30CB\\u30BF\\u30FC\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" },
                    { 149, 13, "Curved QHD screen for immersive work and entertainment.", "[\"32-inch Curved QHD Monitor with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "", "32-inch Curved QHD Monitor", 18999m, 1, 7, "", "[\"32-inch Curved QHD Monitor\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" },
                    { 150, 14, "Grand écran incurvé pour le travail et le divertissement.", "[\"Moniteur Incurv\\u00E9 32 pouces QHD with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "", "Moniteur Incurvé 32 pouces QHD", 399m, 2, 7, "", "[\"Moniteur Incurv\\u00E9 32 pouces QHD\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" },
                    { 151, 15, "宽阔曲面屏幕，适合办公、游戏和影音。", "[\"32\\u82F1\\u5BF8 \\u66F2\\u9762 2K\\u663E\\u793A\\u5668 with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "", "32英寸 曲面 2K显示器", 1899m, 3, 10, "", "[\"32\\u82F1\\u5BF8 \\u66F2\\u9762 2K\\u663E\\u793A\\u5668\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" },
                    { 152, 16, "仕事と映像鑑賞に適した大型曲面ディスプレイ。", "[\"32\\u30A4\\u30F3\\u30C1 \\u66F2\\u9762 QHD \\u30E2\\u30CB\\u30BF\\u30FC with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "", "32インチ 曲面 QHD モニター", 59800m, 4, 8, "", "[\"32\\u30A4\\u30F3\\u30C1 \\u66F2\\u9762 QHD \\u30E2\\u30CB\\u30BF\\u30FC\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" },
                    { 153, 13, "Color-accurate UHD monitor for photo, video, and design work.", "[\"28-inch 4K Creator Monitor with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "", "28-inch 4K Creator Monitor", 22999m, 1, 5, "", "[\"28-inch 4K Creator Monitor\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" },
                    { 154, 14, "Écran UHD aux couleurs précises pour la création visuelle.", "[\"Moniteur Cr\\u00E9atif 28 pouces 4K with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "", "Moniteur Créatif 28 pouces 4K", 499m, 2, 6, "", "[\"Moniteur Cr\\u00E9atif 28 pouces 4K\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" },
                    { 155, 15, "色彩准确的 UHD 显示器，适合视觉创作。", "[\"28\\u82F1\\u5BF8 4K\\u4E13\\u4E1A\\u663E\\u793A\\u5668 with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "", "28英寸 4K专业显示器", 2799m, 3, 7, "", "[\"28\\u82F1\\u5BF8 4K\\u4E13\\u4E1A\\u663E\\u793A\\u5668\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" },
                    { 156, 16, "写真や動画編集に適した高色精度 UHD ディスプレイ。", "[\"28\\u30A4\\u30F3\\u30C1 4K \\u30AF\\u30EA\\u30A8\\u30A4\\u30BF\\u30FC\\u30E2\\u30CB\\u30BF\\u30FC with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "", "28インチ 4K クリエイターモニター", 74800m, 4, 6, "", "[\"28\\u30A4\\u30F3\\u30C1 4K \\u30AF\\u30EA\\u30A8\\u30A4\\u30BF\\u30FC\\u30E2\\u30CB\\u30BF\\u30FC\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" },
                    { 157, 13, "Slim portable Full HD display for travel and flexible workspaces.", "[\"15.6-inch Portable Monitor with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "", "15.6-inch Portable Monitor", 8999m, 1, 15, "", "[\"15.6-inch Portable Monitor\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" },
                    { 158, 14, "Second écran Full HD fin pour les déplacements.", "[\"Moniteur Portable 15,6 pouces with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "", "Moniteur Portable 15,6 pouces", 189m, 2, 14, "", "[\"Moniteur Portable 15,6 pouces\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" },
                    { 159, 15, "轻薄全高清便携屏，适合移动办公和扩展显示。", "[\"15.6\\u82F1\\u5BF8 \\u4FBF\\u643A\\u663E\\u793A\\u5668 with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "", "15.6英寸 便携显示器", 999m, 3, 18, "", "[\"15.6\\u82F1\\u5BF8 \\u4FBF\\u643A\\u663E\\u793A\\u5668\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" },
                    { 160, 16, "出張や在宅勤務で使いやすい薄型フル HD サブディスプレイ。", "[\"15.6\\u30A4\\u30F3\\u30C1 \\u30E2\\u30D0\\u30A4\\u30EB\\u30E2\\u30CB\\u30BF\\u30FC with crisp display clarity\",\"Comfortable screen size for multitasking\",\"Easy desk setup\",\"Designed for everyday productivity\"]", "", "15.6インチ モバイルモニター", 29800m, 4, 14, "", "[\"15.6\\u30A4\\u30F3\\u30C1 \\u30E2\\u30D0\\u30A4\\u30EB\\u30E2\\u30CB\\u30BF\\u30FC\",\"Stand\",\"Power cable\",\"Display cable\",\"Documentation\"]" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "Id", "ImageUrl", "Price", "ProductId", "Sku", "StockQuantity" },
                values: new object[,]
                {
                    { 9300, "", 24999m, 93, "PROD-93-BASE", 18 },
                    { 9400, "", 549m, 94, "PROD-94-BASE", 15 },
                    { 9500, "", 5499m, 95, "PROD-95-BASE", 14 },
                    { 9600, "", 69300m, 96, "PROD-96-BASE", 15 },
                    { 9700, "", 28999m, 97, "PROD-97-BASE", 14 },
                    { 9800, "", 899m, 98, "PROD-98-BASE", 11 },
                    { 9900, "", 2499m, 99, "PROD-99-BASE", 22 },
                    { 10000, "", 64800m, 100, "PROD-100-BASE", 17 },
                    { 10100, "", 26999m, 101, "PROD-101-BASE", 16 },
                    { 10200, "", 699m, 102, "PROD-102-BASE", 12 },
                    { 10300, "", 2599m, 103, "PROD-103-BASE", 19 },
                    { 10400, "", 128900m, 104, "PROD-104-BASE", 11 },
                    { 10500, "", 34999m, 105, "PROD-105-BASE", 11 },
                    { 10600, "", 699m, 106, "PROD-106-BASE", 13 },
                    { 10700, "", 2299m, 107, "PROD-107-BASE", 20 },
                    { 10800, "", 124700m, 108, "PROD-108-BASE", 10 },
                    { 10900, "", 29999m, 109, "PROD-109-BASE", 13 },
                    { 11000, "", 499m, 110, "PROD-110-BASE", 17 },
                    { 11100, "", 3199m, 111, "PROD-111-BASE", 13 },
                    { 11200, "", 48800m, 112, "PROD-112-BASE", 19 },
                    { 11300, "", 22999m, 113, "PROD-113-BASE", 17 },
                    { 11400, "", 399m, 114, "PROD-114-BASE", 14 },
                    { 11500, "", 2099m, 115, "PROD-115-BASE", 21 },
                    { 11600, "", 79800m, 116, "PROD-116-BASE", 13 },
                    { 11700, "", 45999m, 117, "PROD-117-BASE", 10 },
                    { 11800, "", 1099m, 118, "PROD-118-BASE", 8 },
                    { 11900, "", 7999m, 119, "PROD-119-BASE", 8 },
                    { 12000, "", 218000m, 120, "PROD-120-BASE", 7 },
                    { 12100, "", 57999m, 121, "PROD-121-BASE", 7 },
                    { 12200, "", 899m, 122, "PROD-122-BASE", 10 },
                    { 12300, "", 6499m, 123, "PROD-123-BASE", 10 },
                    { 12400, "", 159800m, 124, "PROD-124-BASE", 9 },
                    { 12500, "", 64999m, 125, "PROD-125-BASE", 8 },
                    { 12600, "", 1349m, 126, "PROD-126-BASE", 6 },
                    { 12700, "", 5499m, 127, "PROD-127-BASE", 12 },
                    { 12800, "", 169800m, 128, "PROD-128-BASE", 8 },
                    { 12900, "", 52999m, 129, "PROD-129-BASE", 6 },
                    { 13000, "", 1299m, 130, "PROD-130-BASE", 7 },
                    { 13100, "", 6999m, 131, "PROD-131-BASE", 9 },
                    { 13200, "", 139800m, 132, "PROD-132-BASE", 10 },
                    { 13300, "", 34999m, 133, "PROD-133-BASE", 12 },
                    { 13400, "", 1599m, 134, "PROD-134-BASE", 5 },
                    { 13500, "", 7299m, 135, "PROD-135-BASE", 7 },
                    { 13600, "", 179800m, 136, "PROD-136-BASE", 7 },
                    { 13700, "", 48999m, 137, "PROD-137-BASE", 9 },
                    { 13800, "", 1199m, 138, "PROD-138-BASE", 8 },
                    { 13900, "", 6699m, 139, "PROD-139-BASE", 8 },
                    { 14000, "", 149800m, 140, "PROD-140-BASE", 6 },
                    { 14100, "", 15999m, 141, "PROD-141-BASE", 9 },
                    { 14200, "", 329m, 142, "PROD-142-BASE", 9 },
                    { 14300, "", 1599m, 143, "PROD-143-BASE", 13 },
                    { 14400, "", 49800m, 144, "PROD-144-BASE", 10 },
                    { 14500, "", 10999m, 145, "PROD-145-BASE", 12 },
                    { 14600, "", 249m, 146, "PROD-146-BASE", 11 },
                    { 14700, "", 1099m, 147, "PROD-147-BASE", 16 },
                    { 14800, "", 34800m, 148, "PROD-148-BASE", 12 },
                    { 14900, "", 18999m, 149, "PROD-149-BASE", 7 },
                    { 15000, "", 399m, 150, "PROD-150-BASE", 7 },
                    { 15100, "", 1899m, 151, "PROD-151-BASE", 10 },
                    { 15200, "", 59800m, 152, "PROD-152-BASE", 8 },
                    { 15300, "", 22999m, 153, "PROD-153-BASE", 5 },
                    { 15400, "", 499m, 154, "PROD-154-BASE", 6 },
                    { 15500, "", 2799m, 155, "PROD-155-BASE", 7 },
                    { 15600, "", 74800m, 156, "PROD-156-BASE", 6 },
                    { 15700, "", 8999m, 157, "PROD-157-BASE", 15 },
                    { 15800, "", 189m, 158, "PROD-158-BASE", 14 },
                    { 15900, "", 999m, 159, "PROD-159-BASE", 18 },
                    { 16000, "", 29800m, 160, "PROD-160-BASE", 14 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9300);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9400);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9500);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9600);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9700);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9800);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9900);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 10000);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 10100);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 10200);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 10300);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 10400);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 10500);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 10600);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 10700);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 10800);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 10900);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 11000);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 11100);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 11200);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 11300);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 11400);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 11500);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 11600);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 11700);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 11800);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 11900);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 12000);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 12100);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 12200);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 12300);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 12400);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 12500);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 12600);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 12700);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 12800);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 12900);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 13000);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 13100);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 13200);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 13300);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 13400);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 13500);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 13600);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 13700);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 13800);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 13900);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 14000);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 14100);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 14200);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 14300);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 14400);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 14500);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 14600);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 14700);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 14800);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 14900);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 15000);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 15100);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 15200);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 15300);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 15400);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 15500);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 15600);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 15700);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 15800);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 15900);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 16000);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160);
        }
    }
}
