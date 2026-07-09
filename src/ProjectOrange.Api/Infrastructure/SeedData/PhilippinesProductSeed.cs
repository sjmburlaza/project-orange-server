namespace ProjectOrangeApi.Data.Seeds;

internal static class PhilippinesProductSeed
{
    internal static ProductSeedEntry[] Products =>
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
        new(23, "34-inch Ultrawide Monitor", "Curved ultrawide display for multitasking and immersive setups.", 27999, 6, "", 4),

        new(24, "Samsung Galaxy A55 5G", "Midrange 5G phone with a bright AMOLED display and dependable battery.", 24999, 18, "", 1),
        new(25, "OPPO Reno12 5G", "Slim 5G smartphone with portrait cameras and fast charging.", 28999, 14, "", 1),
        new(26, "vivo V40", "Camera-focused smartphone with a vivid display and long battery life.", 26999, 16, "", 1),
        new(27, "realme GT 6", "Performance smartphone with fast charging and a smooth AMOLED screen.", 34999, 11, "", 1),
        new(28, "HONOR 200", "Portrait-focused 5G phone with a high-resolution OLED display.", 29999, 13, "", 1),
        new(29, "Nothing Phone (2a)", "Distinctive Android smartphone with a clean interface and Glyph design.", 22999, 17, "", 1),

        new(30, "Lenovo IdeaPad Slim 5", "Versatile laptop for school, office work, and daily entertainment.", 45999, 10, "", 2),
        new(31, "HP Pavilion Plus 14", "Compact productivity laptop with a sharp display and premium finish.", 57999, 7, "", 2),
        new(32, "ASUS Vivobook S 15", "Thin laptop with a spacious OLED display for mobile productivity.", 64999, 8, "", 2),
        new(33, "Acer Nitro V 15", "Gaming laptop with dedicated graphics and efficient cooling.", 52999, 6, "", 2),
        new(34, "MSI Modern 14", "Lightweight everyday laptop for business and study.", 34999, 12, "", 2),
        new(35, "Huawei MateBook D 16", "Large-screen productivity laptop with a full-size keyboard.", 48999, 9, "", 2),

        new(36, "27-inch 180Hz Gaming Monitor", "Fast IPS gaming display with fluid motion and low input lag.", 15999, 9, "", 4),
        new(37, "24-inch USB-C Office Monitor", "Compact office display with convenient USB-C connectivity.", 10999, 12, "", 4),
        new(38, "32-inch Curved QHD Monitor", "Curved QHD screen for immersive work and entertainment.", 18999, 7, "", 4),
        new(39, "28-inch 4K Creator Monitor", "Color-accurate UHD monitor for photo, video, and design work.", 22999, 5, "", 4),
        new(40, "15.6-inch Portable Monitor", "Slim portable Full HD display for travel and flexible workspaces.", 8999, 15, "", 4)
    ];
}
