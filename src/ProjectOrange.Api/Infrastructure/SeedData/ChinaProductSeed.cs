namespace ProjectOrangeApi.Data.Seeds;

internal static class ChinaProductSeed
{
    internal static ProductSeedEntry[] Products =>
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
        new(23, "34英寸 带鱼屏显示器", "曲面 UWQHD 宽屏显示器，适合多任务处理和沉浸式体验。", 2999, 6, "", 4),

        new(24, "Huawei Pura 70", "影像旗舰手机，配备高亮度屏幕和快速充电。", 5499, 14, "", 1),
        new(25, "Xiaomi Redmi K70", "高性能手机，兼顾流畅游戏与日常使用。", 2499, 22, "", 1),
        new(26, "OnePlus Ace 3", "大电池性能手机，支持快速有线充电。", 2599, 19, "", 1),
        new(27, "iQOO Neo9", "面向游戏的智能手机，配备高刷新率屏幕。", 2299, 20, "", 1),
        new(28, "Meizu 21", "轻薄直屏手机，提供简洁流畅的使用体验。", 3199, 13, "", 1),
        new(29, "realme GT Neo6", "高性能 5G 手机，拥有明亮的 AMOLED 屏幕。", 2099, 21, "", 1),

        new(30, "Lenovo Yoga Pro 14s", "高性能轻薄笔记本，适合移动创作和办公。", 7999, 8, "", 2),
        new(31, "Huawei MateBook 14", "高分辨率触控屏笔记本，适合日常生产力任务。", 6499, 10, "", 2),
        new(32, "Xiaomi RedmiBook Pro 15", "金属机身大屏笔记本，兼顾学习与办公。", 5499, 12, "", 2),
        new(33, "Honor MagicBook Pro 16", "大屏高性能笔记本，适合多任务和娱乐。", 6999, 9, "", 2),
        new(34, "Acer Swift Edge 16", "轻量大屏 OLED 笔记本，便于携带。", 7299, 7, "", 2),
        new(35, "MSI Star 15", "面向设计与办公的便携高性能笔记本。", 6699, 8, "", 2),

        new(36, "27英寸 180Hz 电竞显示器", "快速 IPS 电竞屏，提供流畅清晰的动态画面。", 1599, 13, "", 4),
        new(37, "24英寸 USB-C 办公显示器", "支持 USB-C 连接的紧凑办公显示屏。", 1099, 16, "", 4),
        new(38, "32英寸 曲面 2K显示器", "宽阔曲面屏幕，适合办公、游戏和影音。", 1899, 10, "", 4),
        new(39, "28英寸 4K专业显示器", "色彩准确的 UHD 显示器，适合视觉创作。", 2799, 7, "", 4),
        new(40, "15.6英寸 便携显示器", "轻薄全高清便携屏，适合移动办公和扩展显示。", 999, 18, "", 4)
    ];
}
