using ProjectOrangeApi.Models;

namespace ProjectOrangeApi.Data.Seeds;

public static class ProductSeed
{
    private const int LegacyProductsPerSite = 20;
    private const int FirstAdditionalProductId = LegacyProductsPerSite + 1;

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

                new(11, "Mechanical Keyboard", "Compact RGB mechanical keyboard.", 3500, 25, "", 3, "Keyboard"),
                new(12, "Wireless Mouse", "Ergonomic wireless mouse for work and gaming.", 1200, 40, "", 3, "Mouse"),
                new(13, "True Wireless Earbuds", "Pocket-sized earbuds with clear calls and touch controls.", 2999, 30, "", 3, "Earbuds"),
                new(14, "Gaming Headset", "Wired gaming headset with a noise-reducing boom mic.", 2499, 20, "", 3, "Headset"),
                new(15, "Noise Cancelling Headphones", "Wireless over-ear headphones with active noise cancelling.", 8999, 14, "", 3, "Headphones"),
                new(16, "Bluetooth Keyboard", "Slim wireless keyboard for tablets and desktop setups.", 2200, 18, "", 3, "Keyboard"),
                new(17, "Precision Wireless Mouse", "Low-latency mouse with adjustable DPI for work and gaming.", 1700, 22, "", 3, "Mouse"),
                new(18, "Sport Earbuds", "Sweat-resistant earbuds with secure-fit tips.", 2499, 26, "", 3, "Earbuds"),
                new(19, "USB-C Office Headset", "Lightweight headset with inline controls for meetings.", 1999, 28, "", 3, "Headset"),

                new(20, "27-inch Monitor", "QHD productivity monitor for hybrid work.", 12999, 10, "", 4),
                new(21, "24-inch FHD Monitor", "Compact Full HD monitor for study and office desks.", 7999, 14, "", 4),
                new(22, "32-inch 4K Monitor", "Large UHD display with HDR support for creative work.", 24999, 8, "", 4),
                new(23, "34-inch Ultrawide Monitor", "Curved ultrawide display for multitasking and immersive setups.", 27999, 6, "", 4)
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

                new(11, "Clavier Mécanique AZERTY", "Clavier mécanique rétroéclairé pour bureau et jeu.", 109, 22, "", 3, "Keyboard"),
                new(12, "Souris Bluetooth Compacte", "Souris sans fil compacte pour ordinateur portable et tablette.", 39, 38, "", 3, "Mouse"),
                new(13, "Écouteurs Sans Fil Pro", "Écouteurs Bluetooth avec réduction du bruit et boîtier de charge.", 129, 24, "", 3, "Earbuds"),
                new(14, "Casque Audio Circum-Aural", "Casque sans fil confortable avec réduction active du bruit.", 199, 16, "", 3, "Headphones"),
                new(15, "Micro-Casque USB-C", "Micro-casque léger pour appels vidéo et travail hybride.", 79, 28, "", 3, "Headset"),
                new(16, "Clavier Bluetooth Compact", "Clavier sans fil fin pour bureau et tablette.", 69, 18, "", 3, "Keyboard"),
                new(17, "Souris Gaming Sans Fil", "Souris basse latence avec DPI réglable.", 59, 30, "", 3, "Mouse"),
                new(18, "Écouteurs Sport", "Écouteurs résistants à la transpiration avec maintien sécurisé.", 89, 26, "", 3, "Earbuds"),
                new(19, "Micro-Casque Gaming RGB", "Micro-casque gaming avec micro perche et son immersif.", 99, 20, "", 3, "Headset"),

                new(20, "Moniteur 27 pouces QHD", "Écran QHD polyvalent avec dalle IPS pour le travail quotidien.", 299, 9, "", 4),
                new(21, "Moniteur 24 pouces FHD", "Écran bureautique Full HD avec pied réglable.", 179, 10, "", 4),
                new(22, "Moniteur 32 pouces 4K", "Grand écran UHD avec HDR pour création et multitâche.", 449, 7, "", 4),
                new(23, "Moniteur Ultrawide 34 pouces", "Écran incurvé UWQHD pour le multitâche et les configurations immersives.", 549, 6, "", 4)
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

                new(11, "Low-Profile Mechanical Keyboard", "紧凑型低轴机械键盘，适合办公和游戏。", 329, 30, "", 3, "Keyboard"),
                new(12, "Silent Wireless Mouse", "静音无线鼠标，适合办公和学习。", 99, 48, "", 3, "Mouse"),
                new(13, "True Wireless Earbuds Pro", "降噪真无线耳机，适合通话和音乐。", 699, 24, "", 3, "Earbuds"),
                new(14, "ANC Headphones", "无线头戴式耳机，支持主动降噪。", 899, 18, "", 3, "Headphones"),
                new(15, "USB-C Gaming Headset", "带麦克风的游戏耳麦，适合语音通话和电竞。", 299, 28, "", 3, "Headset"),
                new(16, "Compact Bluetooth Keyboard", "便携蓝牙键盘，适合平板和桌面使用。", 199, 32, "", 3, "Keyboard"),
                new(17, "Gaming Mouse", "低延迟无线鼠标，支持可调 DPI。", 199, 35, "", 3, "Mouse"),
                new(18, "Mechanical Keyboard 87-Key", "紧凑型机械键盘，适合桌面办公和游戏。", 329, 22, "", 3, "Keyboard"),
                new(19, "Open-Ear Earbuds", "开放式蓝牙耳机，佩戴轻便舒适。", 499, 26, "", 3, "Earbuds"),

                new(20, "27英寸 2K显示器", "清晰 2K 显示器，适合办公和游戏。", 1299, 12, "", 4),
                new(21, "24英寸 全高清显示器", "紧凑全高清显示器，适合学习和日常办公。", 799, 18, "", 4),
                new(22, "32英寸 4K显示器", "大尺寸 UHD 显示屏，适合创作和多任务处理。", 2499, 8, "", 4),
                new(23, "34英寸 带鱼屏显示器", "曲面 UWQHD 宽屏显示器，适合多任务处理和沉浸式体验。", 2999, 6, "", 4)
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

                new(11, "Compact Bluetooth Keyboard", "省スペースで使える薄型 Bluetooth キーボード。", 8980, 24, "", 3, "Keyboard"),
                new(12, "Sony WH-1000XM5", "通勤や仕事に適したノイズキャンセリングヘッドホン。", 59400, 12, "", 3, "Headphones"),
                new(13, "Wireless Earbuds", "通話と音楽に使いやすい完全ワイヤレスイヤホン。", 12800, 26, "", 3, "Earbuds"),
                new(14, "USB-C Gaming Headset", "着脱式マイク付きの USB-C ゲーミングヘッドセット。", 9980, 18, "", 3, "Headset"),
                new(15, "Wireless Trackball Mouse", "デスク作業に適したエルゴノミックトラックボールマウス。", 7980, 18, "", 3, "Mouse"),
                new(16, "Portable Mechanical Keyboard", "持ち運びしやすいコンパクトなメカニカルキーボード。", 14800, 16, "", 3, "Keyboard"),
                new(17, "Silent Wireless Mouse", "クリック音を抑えた薄型ワイヤレスマウス。", 4980, 28, "", 3, "Mouse"),
                new(18, "Compact Mechanical Keyboard", "省スペースで使えるタクタイルスイッチ搭載キーボード。", 12800, 16, "", 3, "Keyboard"),
                new(19, "Work Headset", "オンライン会議向けの軽量ワイヤレスヘッドセット。", 11800, 22, "", 3, "Headset"),

                new(20, "27インチ QHD モニター", "作業効率を高める高解像度 QHD ディスプレイ。", 44800, 9, "", 4),
                new(21, "24インチ FHD モニター", "省スペースで使えるフル HD ディスプレイ。", 24800, 14, "", 4),
                new(22, "32インチ 4K モニター", "制作作業や動画視聴に適した大画面 4K ディスプレイ。", 69800, 7, "", 4),
                new(23, "34インチ ウルトラワイドモニター", "マルチタスクに便利な曲面 UWQHD ディスプレイ。", 79800, 6, "", 4)
            ]
        };

    public static Product[] Products =>
        SiteSeed.Sites
            .SelectMany(site =>
                ProductsBySite[site.Code].Select(product => new Product
                {
                    Id = GetProductId(site.Id, product.Id),
                    SiteId = site.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    StockQuantity = product.StockQuantity,
                    ImageUrl = product.ImageUrl,
                    SubcategoryName = product.SubcategoryName,
                    FeaturesJson = ProductPresentationSeed.GetFeaturesJson(
                        product.Name,
                        product.CategoryId),
                    WhatsInTheBoxJson = ProductPresentationSeed.GetWhatsInTheBoxJson(
                        product.Name,
                        product.CategoryId),
                    CategoryId = CategorySeed.GetCategoryId(site.Id, product.CategoryId)
                }))
            .ToArray();

    public static int GetProductId(int siteId, int baseProductId)
    {
        if (baseProductId <= LegacyProductsPerSite)
        {
            var siteIndex = siteId - 1;
            return (siteIndex * LegacyProductsPerSite) + baseProductId;
        }

        return (SiteSeed.Sites.Length * LegacyProductsPerSite)
            + ((baseProductId - FirstAdditionalProductId) * SiteSeed.Sites.Length)
            + siteId;
    }

    private sealed record ProductSeedEntry(
        int Id,
        string Name,
        string Description,
        decimal Price,
        int StockQuantity,
        string ImageUrl,
        int CategoryId,
        string SubcategoryName = "");
}
