using ProjectOrangeApi.Models;

namespace ProjectOrangeApi.Data.Seeds;

public static class ProductSeed
{
    private const int ProductsPerSite = 20;

    private static readonly Dictionary<string, ProductSeedEntry[]> ProductsBySite =
        new(StringComparer.OrdinalIgnoreCase)
        {
            ["ph"] =
            [
                new(1, "iPhone 15", "Apple smartphone with all-day battery life.", 59999, 10, "", 1),
                new(2, "Samsung Galaxy S24", "Android flagship smartphone with Galaxy AI features.", 54999, 12, "", 1),
                new(3, "Google Pixel 8", "Google AI smartphone with clean Android software.", 39999, 8, "", 1),
                new(4, "Xiaomi 14", "High-performance Android phone with Leica-tuned cameras.", 32999, 15, "", 1),
                new(5, "OnePlus 12", "Fast charging flagship phone with a smooth display.", 45999, 9, "", 1),

                new(6, "MacBook Air M3", "Lightweight Apple laptop for everyday productivity.", 69999, 7, "", 2),
                new(7, "Dell XPS 13", "Premium Windows ultrabook with a compact build.", 74999, 6, "", 2),
                new(8, "Lenovo ThinkPad X1 Carbon", "Business laptop with durable carbon-fiber design.", 89999, 5, "", 2),
                new(9, "ASUS ROG Zephyrus G14", "Portable gaming laptop with high-refresh display.", 94999, 4, "", 2),
                new(10, "Acer Swift Go 14", "Portable productivity laptop for students and professionals.", 39999, 11, "", 2),

                new(11, "Mechanical Keyboard", "Compact RGB mechanical keyboard.", 3500, 25, "", 3),
                new(12, "Wireless Mouse", "Ergonomic wireless mouse for work and gaming.", 1200, 40, "", 3),
                new(13, "USB-C Hub", "Multi-port USB-C adapter for laptops and tablets.", 1800, 30, "", 3),
                new(14, "Laptop Stand", "Aluminum adjustable stand for better desk ergonomics.", 1500, 20, "", 3),
                new(15, "Noise Cancelling Headphones", "Wireless over-ear headphones with active noise cancelling.", 8999, 14, "", 3),
                new(16, "Bluetooth Speaker", "Portable speaker with splash resistance.", 2500, 18, "", 3),
                new(17, "Webcam 1080p", "Full HD webcam for video meetings.", 2200, 22, "", 3),
                new(18, "External SSD 1TB", "Portable high-speed SSD for file backups.", 6500, 16, "", 3),
                new(19, "Power Bank 20000mAh", "Fast-charging power bank for phones and tablets.", 2000, 28, "", 3),
                new(20, "27-inch Monitor", "QHD productivity monitor for hybrid work.", 12999, 10, "", 3)
            ],
            ["fr"] =
            [
                new(1, "iPhone 15 Pro", "Smartphone Apple en titane avec puce A17 Pro.", 1229, 8, "", 1),
                new(2, "Samsung Galaxy A55 5G", "Smartphone 5G avec écran AMOLED et grande autonomie.", 499, 18, "", 1),
                new(3, "Fairphone 5", "Smartphone durable conçu pour être réparé plus facilement.", 699, 10, "", 1),
                new(4, "Nothing Phone (2a)", "Smartphone Android au design Glyph distinctif.", 349, 16, "", 1),
                new(5, "Xiaomi Redmi Note 13 Pro", "Smartphone photo 200 MP avec charge rapide.", 399, 20, "", 1),

                new(6, "MacBook Pro 14 M3", "Ordinateur portable Apple pour les flux créatifs exigeants.", 1999, 5, "", 2),
                new(7, "Surface Laptop 6", "PC portable professionnel avec Windows 11 Pro.", 1499, 7, "", 2),
                new(8, "HP Spectre x360 14", "PC convertible OLED pour le travail mobile.", 1599, 6, "", 2),
                new(9, "ASUS Zenbook 14 OLED", "Ultrabook OLED léger avec processeur Intel Core Ultra.", 1199, 9, "", 2),
                new(10, "Lenovo Yoga Slim 7", "Portable fin et silencieux pour la productivité quotidienne.", 999, 11, "", 2),

                new(11, "Chargeur MagSafe", "Chargeur magnétique compatible avec l’iPhone.", 49, 35, "", 3),
                new(12, "Adaptateur USB-C Europe", "Chargeur secteur USB-C compact pour prise européenne.", 29, 45, "", 3),
                new(13, "Clavier AZERTY Bluetooth", "Clavier sans fil AZERTY pour bureau et tablette.", 79, 24, "", 3),
                new(14, "Souris Ergonomique", "Souris sans fil conçue pour une utilisation prolongée.", 59, 30, "", 3),
                new(15, "Casque Audio ANC", "Casque Bluetooth avec réduction active du bruit.", 199, 13, "", 3),
                new(16, "Station USB-C 8-en-1", "Station compacte avec HDMI, Ethernet et ports USB.", 89, 18, "", 3),
                new(17, "Housse Laptop 14 pouces", "Housse rembourrée pour ordinateur portable.", 39, 28, "", 3),
                new(18, "SSD Externe 2 To", "Stockage externe rapide pour photos et vidéos.", 159, 12, "", 3),
                new(19, "Batterie Externe 10000mAh", "Batterie compacte avec USB-C Power Delivery.", 39, 32, "", 3),
                new(20, "Moniteur 24 pouces FHD", "Écran bureautique Full HD avec pied réglable.", 179, 10, "", 3)
            ],
            ["cn"] =
            [
                new(1, "Huawei Mate 60 Pro", "高端智能手机，配备先进的移动影像能力。", 6999, 14, "", 1),
                new(2, "Xiaomi 14 Ultra", "旗舰影像手机，搭载徕卡光学系统。", 6499, 12, "", 1),
                new(3, "Honor Magic6 Pro", "高端安卓手机，拥有持久续航表现。", 5699, 15, "", 1),
                new(4, "vivo X100", "专注影像体验的手机，采用蔡司影像调校。", 3999, 18, "", 1),
                new(5, "OPPO Find X7", "轻薄旗舰手机，支持快速充电。", 4299, 16, "", 1),

                new(6, "Huawei MateBook X Pro", "轻薄高端笔记本，配备高分辨率显示屏。", 9999, 6, "", 2),
                new(7, "Lenovo Xiaoxin Pro 14", "便携高性能笔记本，适合日常办公与创作。", 5799, 11, "", 2),
                new(8, "Xiaomi Notebook Pro 16", "大屏笔记本，兼顾工作与影音娱乐。", 6999, 8, "", 2),
                new(9, "Honor MagicBook 14", "日常办公笔记本，拥有长续航表现。", 4999, 13, "", 2),
                new(10, "ASUS Tianxuan Air", "轻薄游戏本，配备独立显卡。", 7499, 5, "", 2),

                new(11, "120W GaN Charger", "小巧高功率充电器，适用于手机和笔记本。", 249, 40, "", 3),
                new(12, "USB-C Braided Cable", "耐用编织快充线。", 49, 80, "", 3),
                new(13, "True Wireless Earbuds Pro", "降噪真无线耳机，适合通话和音乐。", 699, 24, "", 3),
                new(14, "Magnetic Phone Stand", "可折叠磁吸手机支架。", 129, 30, "", 3),
                new(15, "Wi-Fi 6 Router", "双频路由器，适合家庭网络。", 399, 18, "", 3),
                new(16, "Portable SSD 1TB", "高速 USB-C 移动固态硬盘。", 599, 20, "", 3),
                new(17, "Gaming Mouse", "低延迟无线鼠标，支持可调 DPI。", 199, 35, "", 3),
                new(18, "Mechanical Keyboard 87-Key", "紧凑型机械键盘，适合桌面办公和游戏。", 329, 22, "", 3),
                new(19, "20000mAh Power Bank", "大容量移动电源，支持快速充电。", 199, 38, "", 3),
                new(20, "27-inch 2K Monitor", "清晰 2K 显示器，适合办公和游戏。", 1299, 12, "", 3)
            ],
            ["jp"] =
            [
                new(1, "iPhone 15", "USB-C と高性能カメラを備えた Apple のスマートフォン。", 124800, 11, "", 1),
                new(2, "Sony Xperia 1 VI", "クリエイター向けのディスプレイとカメラを備えた Sony の上位モデル。", 189200, 6, "", 1),
                new(3, "Google Pixel 8a", "AI 機能を搭載したコンパクトな Google スマートフォン。", 72600, 18, "", 1),
                new(4, "Sharp AQUOS R9", "明るい Pro IGZO OLED ディスプレイを備えた国産 Android スマートフォン。", 99800, 10, "", 1),
                new(5, "Galaxy Z Flip6", "コンパクトなカバーディスプレイを備えた折りたたみスマートフォン。", 159700, 7, "", 1),

                new(6, "VAIO SX14", "持ち運びやすさを重視した軽量ビジネスノート。", 249800, 5, "", 2),
                new(7, "Panasonic Let's note FV5", "軽量ボディと高い耐久性を備えたビジネスノート。", 289800, 4, "", 2),
                new(8, "MacBook Air M3", "静音設計と長時間バッテリーを備えた Apple ノートブック。", 164800, 9, "", 2),
                new(9, "Dynabook RZ", "学生やビジネスユーザーに適した携帯性の高いノート PC。", 179800, 6, "", 2),
                new(10, "ThinkPad X13 Gen 5", "打ちやすいキーボードを備えたコンパクトなビジネスノート。", 198000, 8, "", 2),

                new(11, "Anker Nano Charger", "毎日の持ち歩きに便利な小型 USB-C 充電器。", 3990, 45, "", 3),
                new(12, "Sony WH-1000XM5", "通勤や仕事に適したノイズキャンセリングヘッドホン。", 59400, 12, "", 3),
                new(13, "USB-C Multiport Adapter", "ノート PC 向けの HDMI・USB 対応マルチポートアダプター。", 6980, 26, "", 3),
                new(14, "Laptop Sleeve 13-inch", "外出時に使いやすい薄型ノート PC スリーブ。", 3480, 32, "", 3),
                new(15, "Wireless Trackball Mouse", "デスク作業に適したエルゴノミックトラックボールマウス。", 7980, 18, "", 3),
                new(16, "Portable SSD 1TB", "写真や書類の保存に便利な高速外付け SSD。", 16800, 14, "", 3),
                new(17, "Desk Monitor Light", "モニター周りを照らす USB 給電式ライトバー。", 5980, 20, "", 3),
                new(18, "Compact Mechanical Keyboard", "省スペースで使えるタクタイルスイッチ搭載キーボード。", 12800, 16, "", 3),
                new(19, "Power Bank 10000mAh", "USB-C 充電対応の薄型モバイルバッテリー。", 4980, 36, "", 3),
                new(20, "27-inch 4K Monitor", "作業効率を高める高解像度 4K ディスプレイ。", 54800, 9, "", 3)
            ]
        };

    public static Product[] Products =>
        SiteSeed.Sites
            .SelectMany((site, siteIndex) =>
                ProductsBySite[site.Code].Select(product => new Product
                {
                    Id = (siteIndex * ProductsPerSite) + product.Id,
                    SiteId = site.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    StockQuantity = product.StockQuantity,
                    ImageUrl = product.ImageUrl,
                    CategoryId = CategorySeed.GetCategoryId(site.Id, product.CategoryId)
                }))
            .ToArray();

    private sealed record ProductSeedEntry(
        int Id,
        string Name,
        string Description,
        decimal Price,
        int StockQuantity,
        string ImageUrl,
        int CategoryId);
}
