namespace ProjectOrangeApi.Data.Seeds;

public static class FulfillmentOptionSeed
{
    private static readonly FulfillmentSiteSeed Philippines = new()
    {
        PickupLabelPrefix = "Pick up at",
        DefaultRule = Rule(
            "Metro Manila Default",
            [],
            [
                Delivery("jnt-standard", "jnt", "J&T Express", "Standard Delivery", 120, "2–4 business days"),
                Delivery("lbc-express", "lbc", "LBC Express", "Express Delivery", 180, "1–2 business days")
            ],
            ["sm-megamall", "glorietta", "trinoma", "sm-mall-of-asia"]),
        AreaRules =
        [
            Rule(
                "Metro Manila Core",
                ["100", "101", "130", "150", "155", "160"],
                [
                    Delivery("jnt-standard", "jnt", "J&T Express", "Standard Delivery", 120, "2–4 business days"),
                    Delivery("lbc-express", "lbc", "LBC Express", "Express Delivery", 180, "1–2 business days"),
                    Delivery("grab-same-day", "grab", "GrabExpress", "Same Day Delivery", 240, "Same day, order before 2 PM")
                ],
                ["sm-megamall", "sm-mall-of-asia", "glorietta", "greenhills", "trinoma"]),
            Rule(
                "Quezon City and North Metro",
                ["110", "111", "112"],
                [
                    Delivery("jnt-standard", "jnt", "J&T Express", "Standard Delivery", 125, "2–4 business days"),
                    Delivery("lbc-express", "lbc", "LBC Express", "Express Delivery", 190, "1–2 business days"),
                    Delivery("ninja-van-economy", "ninjavan", "Ninja Van", "Economy Delivery", 95, "3–5 business days"),
                    Delivery("grab-same-day", "grab", "GrabExpress", "Same Day Delivery", 250, "Same day, order before 2 PM")
                ],
                ["trinoma", "sm-north-edsa", "vertis-north", "greenhills"]),
            Rule(
                "Makati, BGC, and South Metro",
                ["120", "121", "122", "123", "163", "170", "171", "174", "175", "177", "178"],
                [
                    Delivery("jnt-standard", "jnt", "J&T Express", "Standard Delivery", 115, "2–3 business days"),
                    Delivery("lbc-express", "lbc", "LBC Express", "Express Delivery", 175, "1–2 business days"),
                    Delivery("lalamove-same-day", "lalamove", "Lalamove", "Same Day Delivery", 230, "Same day, order before 2 PM")
                ],
                ["glorietta", "market-market", "alabang-town-center", "sm-southmall", "ayala-manila-bay"]),
            Rule(
                "Laguna",
                ["40"],
                [
                    Delivery("jnt-standard", "jnt", "J&T Express", "Standard Delivery", 145, "3–5 business days"),
                    Delivery("lbc-express", "lbc", "LBC Express", "Express Delivery", 230, "2–3 business days"),
                    Delivery("ninja-van-economy", "ninjavan", "Ninja Van", "Economy Delivery", 130, "4–6 business days")
                ],
                ["sm-santa-rosa", "solenad-nuvali", "sm-calamba"]),
            Rule(
                "Cavite and Batangas",
                ["41", "42"],
                [
                    Delivery("jnt-standard", "jnt", "J&T Express", "Standard Delivery", 155, "3–5 business days"),
                    Delivery("lbc-express", "lbc", "LBC Express", "Express Delivery", 240, "2–3 business days"),
                    Delivery("ap-cargo-provincial", "apcargo", "AP Cargo", "Provincial Cargo Delivery", 135, "4–7 business days")
                ],
                ["sm-dasmarinas", "ayala-serin", "sm-lipa"]),
            Rule(
                "Cebu",
                ["60"],
                [
                    Delivery("jnt-standard", "jnt", "J&T Express", "Standard Delivery", 170, "4–6 business days"),
                    Delivery("lbc-express", "lbc", "LBC Express", "Express Delivery", 260, "2–4 business days"),
                    Delivery("ninja-van-economy", "ninjavan", "Ninja Van", "Economy Delivery", 150, "5–7 business days")
                ],
                ["ayala-center-cebu", "sm-city-cebu"]),
            Rule(
                "Davao",
                ["80"],
                [
                    Delivery("jnt-standard", "jnt", "J&T Express", "Standard Delivery", 190, "5–7 business days"),
                    Delivery("lbc-express", "lbc", "LBC Express", "Express Delivery", 290, "3–5 business days"),
                    Delivery("ap-cargo-provincial", "apcargo", "AP Cargo", "Provincial Cargo Delivery", 165, "5–8 business days")
                ],
                ["abreeza-davao", "sm-lanang"])
        ],
        PickupLocations =
        [
            Pickup("sm-megamall", "SM Megamall Pickup Point", "Mandaluyong City", "Ready in 1–2 days"),
            Pickup("sm-mall-of-asia", "SM Mall of Asia Pickup Point", "Pasay City", "Ready in 1–2 days"),
            Pickup("glorietta", "Glorietta Pickup Lounge", "Makati City", "Ready tomorrow"),
            Pickup("greenhills", "Greenhills Pickup Point", "San Juan City", "Ready in 1–2 days"),
            Pickup("trinoma", "TriNoma Pickup Point", "Quezon City", "Ready tomorrow"),
            Pickup("sm-north-edsa", "SM North EDSA Pickup Point", "Quezon City", "Ready in 1–2 days"),
            Pickup("vertis-north", "Vertis North Pickup Lounge", "Quezon City", "Ready tomorrow"),
            Pickup("market-market", "Market! Market! Pickup Point", "Taguig City", "Ready tomorrow"),
            Pickup("alabang-town-center", "Alabang Town Center Pickup Point", "Muntinlupa City", "Ready in 1–2 days"),
            Pickup("sm-southmall", "SM Southmall Pickup Point", "Las Piñas City", "Ready in 1–2 days"),
            Pickup("ayala-manila-bay", "Ayala Malls Manila Bay Pickup Point", "Parañaque City", "Ready in 1–2 days"),
            Pickup("sm-santa-rosa", "SM City Santa Rosa Pickup Point", "Santa Rosa, Laguna", "Ready in 2–3 days"),
            Pickup("solenad-nuvali", "Solenad Nuvali Pickup Point", "Santa Rosa, Laguna", "Ready in 2–3 days"),
            Pickup("sm-calamba", "SM City Calamba Pickup Point", "Calamba, Laguna", "Ready in 2–3 days"),
            Pickup("sm-dasmarinas", "SM City Dasmariñas Pickup Point", "Dasmariñas, Cavite", "Ready in 2–3 days"),
            Pickup("ayala-serin", "Ayala Malls Serin Pickup Point", "Tagaytay, Cavite", "Ready in 2–3 days"),
            Pickup("sm-lipa", "SM City Lipa Pickup Point", "Lipa, Batangas", "Ready in 2–3 days"),
            Pickup("ayala-center-cebu", "Ayala Center Cebu Pickup Point", "Cebu City", "Ready in 3–4 days"),
            Pickup("sm-city-cebu", "SM City Cebu Pickup Point", "Cebu City", "Ready in 3–4 days"),
            Pickup("abreeza-davao", "Abreeza Davao Pickup Point", "Davao City", "Ready in 4–5 days"),
            Pickup("sm-lanang", "SM Lanang Pickup Point", "Davao City", "Ready in 4–5 days")
        ]
    };

    private static readonly FulfillmentSiteSeed France = new()
    {
        PickupLabelPrefix = "Retrait à",
        DefaultRule = Rule(
            "France Default",
            [],
            [
                Delivery("colissimo-standard", "colissimo", "Colissimo", "Livraison standard", 6.90m, "2–4 jours ouvrés"),
                Delivery("chronopost-express", "chronopost", "Chronopost", "Livraison express", 14.90m, "1–2 jours ouvrés")
            ],
            ["paris-saint-lazare", "paris-les-halles", "lyon-part-dieu"]),
        AreaRules =
        [
            Rule(
                "Île-de-France",
                ["75", "77", "78", "91", "92", "93", "94", "95"],
                [
                    Delivery("colissimo-standard", "colissimo", "Colissimo", "Livraison standard", 6.90m, "2–4 jours ouvrés"),
                    Delivery("chronopost-express", "chronopost", "Chronopost", "Livraison express", 14.90m, "1 jour ouvré"),
                    Delivery("coursier-paris-same-day", "coursier-paris", "Coursier Paris", "Livraison le jour même", 19.90m, "Le jour même, commande avant 13h")
                ],
                ["paris-saint-lazare", "paris-les-halles", "la-defense", "boulogne"]),
            Rule(
                "Auvergne-Rhône-Alpes",
                ["69", "38", "42", "73", "74"],
                [
                    Delivery("colissimo-standard", "colissimo", "Colissimo", "Livraison standard", 7.50m, "2–4 jours ouvrés"),
                    Delivery("chronopost-express", "chronopost", "Chronopost", "Livraison express", 15.90m, "1–2 jours ouvrés"),
                    Delivery("mondial-relay-economy", "mondialrelay", "Mondial Relay", "Livraison relais économique", 4.90m, "3–5 jours ouvrés")
                ],
                ["lyon-part-dieu", "lyon-bellecour", "grenoble-centre"]),
            Rule(
                "Provence-Alpes-Côte d'Azur",
                ["13", "06", "83", "84"],
                [
                    Delivery("colissimo-standard", "colissimo", "Colissimo", "Livraison standard", 7.90m, "3–5 jours ouvrés"),
                    Delivery("chronopost-express", "chronopost", "Chronopost", "Livraison express", 16.90m, "1–2 jours ouvrés"),
                    Delivery("mondial-relay-economy", "mondialrelay", "Mondial Relay", "Livraison relais économique", 5.50m, "4–6 jours ouvrés")
                ],
                ["marseille-terrasses", "nice-etoile", "toulon-mayol"])
        ],
        PickupLocations =
        [
            Pickup("paris-saint-lazare", "Orange Paris Saint-Lazare Pickup Point", "Paris 8e", "Prêt demain"),
            Pickup("paris-les-halles", "Orange Forum des Halles Pickup Point", "Paris 1er", "Prêt demain"),
            Pickup("la-defense", "Orange La Défense Pickup Point", "Puteaux", "Prêt sous 1–2 jours"),
            Pickup("boulogne", "Orange Boulogne Pickup Point", "Boulogne-Billancourt", "Prêt sous 1–2 jours"),
            Pickup("lyon-part-dieu", "Orange Lyon Part-Dieu Pickup Point", "Lyon 3e", "Prêt sous 1–2 jours"),
            Pickup("lyon-bellecour", "Orange Lyon Bellecour Pickup Point", "Lyon 2e", "Prêt sous 1–2 jours"),
            Pickup("grenoble-centre", "Orange Grenoble Centre Pickup Point", "Grenoble", "Prêt sous 2–3 jours"),
            Pickup("marseille-terrasses", "Orange Les Terrasses du Port Pickup Point", "Marseille", "Prêt sous 2–3 jours"),
            Pickup("nice-etoile", "Orange Nice Étoile Pickup Point", "Nice", "Prêt sous 2–3 jours"),
            Pickup("toulon-mayol", "Orange Toulon Mayol Pickup Point", "Toulon", "Prêt sous 2–3 jours")
        ]
    };

    private static readonly FulfillmentSiteSeed China = new()
    {
        PickupLabelPrefix = "到店自取",
        DefaultRule = Rule(
            "China Default",
            [],
            [
                Delivery("sf-standard", "sf", "SF Express", "标准配送", 30, "2–4 business days"),
                Delivery("jd-express", "jd", "JD Logistics", "快速配送", 45, "1–2 business days")
            ],
            ["shanghai-nanjing-road", "beijing-sanlitun", "shenzhen-futian"]),
        AreaRules =
        [
            Rule(
                "Beijing and North China",
                ["10", "30", "05"],
                [
                    Delivery("sf-standard", "sf", "SF Express", "标准配送", 28, "2–3 business days"),
                    Delivery("jd-express", "jd", "JD Logistics", "快速配送", 42, "1–2 business days"),
                    Delivery("flash-same-day", "flash", "Flash Delivery", "当日达", 58, "Same day, order before 2 PM")
                ],
                ["beijing-sanlitun", "beijing-chaoyang", "tianjin-heping"]),
            Rule(
                "Shanghai and East China",
                ["20", "21", "31", "32"],
                [
                    Delivery("sf-standard", "sf", "SF Express", "标准配送", 26, "2–3 business days"),
                    Delivery("jd-express", "jd", "JD Logistics", "快速配送", 40, "1–2 business days"),
                    Delivery("dada-same-day", "dada", "Dada Now", "当日达", 55, "Same day, order before 2 PM")
                ],
                ["shanghai-nanjing-road", "shanghai-pudong", "hangzhou-hubin", "nanjing-xinjiekou"]),
            Rule(
                "Guangdong and South China",
                ["51", "52", "53"],
                [
                    Delivery("sf-standard", "sf", "SF Express", "标准配送", 32, "2–4 business days"),
                    Delivery("jd-express", "jd", "JD Logistics", "快速配送", 48, "1–2 business days"),
                    Delivery("sf-cold-chain-priority", "sf-priority", "SF Priority", "优先配送", 62, "Next business day")
                ],
                ["shenzhen-futian", "guangzhou-tianhe", "foshan-lingnan"])
        ],
        PickupLocations =
        [
            Pickup("beijing-sanlitun", "Orange 北京三里屯取货点", "北京市朝阳区", "Ready tomorrow"),
            Pickup("beijing-chaoyang", "Orange 北京朝阳大悦城取货点", "北京市朝阳区", "Ready in 1–2 days"),
            Pickup("tianjin-heping", "Orange 天津和平取货点", "天津市和平区", "Ready in 2–3 days"),
            Pickup("shanghai-nanjing-road", "Orange 上海南京路取货点", "上海市黄浦区", "Ready tomorrow"),
            Pickup("shanghai-pudong", "Orange 上海浦东取货点", "上海市浦东新区", "Ready in 1–2 days"),
            Pickup("hangzhou-hubin", "Orange 杭州湖滨取货点", "杭州市上城区", "Ready in 2–3 days"),
            Pickup("nanjing-xinjiekou", "Orange 南京新街口取货点", "南京市秦淮区", "Ready in 2–3 days"),
            Pickup("shenzhen-futian", "Orange 深圳福田取货点", "深圳市福田区", "Ready tomorrow"),
            Pickup("guangzhou-tianhe", "Orange 广州天河取货点", "广州市天河区", "Ready in 1–2 days"),
            Pickup("foshan-lingnan", "Orange 佛山岭南天地取货点", "佛山市禅城区", "Ready in 2–3 days")
        ]
    };

    private static readonly FulfillmentSiteSeed Japan = new()
    {
        PickupLabelPrefix = "店舗受け取り",
        DefaultRule = Rule(
            "Japan Default",
            [],
            [
                Delivery("yamato-standard", "yamato", "Yamato Transport", "通常配送", 700, "2–4 business days"),
                Delivery("sagawa-express", "sagawa", "Sagawa Express", "お急ぎ配送", 1200, "1–2 business days")
            ],
            ["tokyo-shinjuku", "tokyo-ginza", "osaka-umeda"]),
        AreaRules =
        [
            Rule(
                "Tokyo and Kanto",
                ["10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21"],
                [
                    Delivery("yamato-standard", "yamato", "Yamato Transport", "通常配送", 700, "2–3 business days"),
                    Delivery("sagawa-express", "sagawa", "Sagawa Express", "お急ぎ配送", 1200, "1–2 business days"),
                    Delivery("tokyo-bike-same-day", "tokyo-bike", "Tokyo Courier", "当日配送", 1800, "Same day, order before noon")
                ],
                ["tokyo-shinjuku", "tokyo-ginza", "yokohama-minatomirai", "saitama-omiya"]),
            Rule(
                "Kansai",
                ["53", "54", "55", "56", "57", "60", "61", "65"],
                [
                    Delivery("yamato-standard", "yamato", "Yamato Transport", "通常配送", 760, "2–4 business days"),
                    Delivery("sagawa-express", "sagawa", "Sagawa Express", "お急ぎ配送", 1300, "1–2 business days"),
                    Delivery("japan-post-economy", "jppost", "Japan Post", "エコノミー配送", 580, "3–5 business days")
                ],
                ["osaka-umeda", "osaka-namba", "kyoto-kawaramachi", "kobe-sannomiya"]),
            Rule(
                "Chubu",
                ["45", "46", "47", "48", "49", "50"],
                [
                    Delivery("yamato-standard", "yamato", "Yamato Transport", "通常配送", 820, "2–4 business days"),
                    Delivery("sagawa-express", "sagawa", "Sagawa Express", "お急ぎ配送", 1400, "1–3 business days"),
                    Delivery("japan-post-economy", "jppost", "Japan Post", "エコノミー配送", 620, "3–5 business days")
                ],
                ["nagoya-sakae", "nagoya-station", "kanazawa-forus"])
        ],
        PickupLocations =
        [
            Pickup("tokyo-shinjuku", "Orange 新宿受け取りカウンター", "東京都新宿区", "Ready tomorrow"),
            Pickup("tokyo-ginza", "Orange 銀座受け取りカウンター", "東京都中央区", "Ready tomorrow"),
            Pickup("yokohama-minatomirai", "Orange 横浜みなとみらい受け取りカウンター", "神奈川県横浜市", "Ready in 1–2 days"),
            Pickup("saitama-omiya", "Orange 大宮受け取りカウンター", "埼玉県さいたま市", "Ready in 1–2 days"),
            Pickup("osaka-umeda", "Orange 大阪梅田受け取りカウンター", "大阪市北区", "Ready tomorrow"),
            Pickup("osaka-namba", "Orange なんば受け取りカウンター", "大阪市中央区", "Ready in 1–2 days"),
            Pickup("kyoto-kawaramachi", "Orange 京都河原町受け取りカウンター", "京都市", "Ready in 2–3 days"),
            Pickup("kobe-sannomiya", "Orange 神戸三宮受け取りカウンター", "兵庫県神戸市", "Ready in 2–3 days"),
            Pickup("nagoya-sakae", "Orange 名古屋栄受け取りカウンター", "愛知県名古屋市", "Ready in 1–2 days"),
            Pickup("nagoya-station", "Orange 名古屋駅受け取りカウンター", "愛知県名古屋市", "Ready in 1–2 days"),
            Pickup("kanazawa-forus", "Orange 金沢フォーラス受け取りカウンター", "石川県金沢市", "Ready in 2–3 days")
        ]
    };

    public static FulfillmentSiteSeed ForSite(string siteCode)
    {
        return siteCode.ToLowerInvariant() switch
        {
            "fr" => France,
            "cn" => China,
            "jp" => Japan,
            _ => Philippines
        };
    }

    private static FulfillmentAreaRule Rule(
        string name,
        List<string> postalCodePrefixes,
        List<FulfillmentDeliveryOption> deliveryOptions,
        List<string> pickupLocationIds)
    {
        return new()
        {
            Name = name,
            PostalCodePrefixes = postalCodePrefixes,
            DeliveryOptions = deliveryOptions,
            PickupLocationIds = pickupLocationIds
        };
    }

    private static FulfillmentDeliveryOption Delivery(
        string code,
        string courierCode,
        string courierName,
        string label,
        decimal price,
        string estimatedAvailability)
    {
        return new()
        {
            Code = code,
            CourierCode = courierCode,
            CourierName = courierName,
            Label = label,
            Price = price,
            EstimatedAvailability = estimatedAvailability
        };
    }

    private static FulfillmentPickupLocation Pickup(
        string id,
        string name,
        string address,
        string estimatedAvailability)
    {
        return new()
        {
            Id = id,
            Name = name,
            Address = address,
            EstimatedAvailability = estimatedAvailability
        };
    }
}

public class FulfillmentSiteSeed
{
    public string PickupLabelPrefix { get; set; } = "Pick up at";
    public FulfillmentAreaRule DefaultRule { get; set; } = new();
    public List<FulfillmentAreaRule> AreaRules { get; set; } = [];
    public List<FulfillmentPickupLocation> PickupLocations { get; set; } = [];
}

public class FulfillmentAreaRule
{
    public string Name { get; set; } = string.Empty;
    public List<string> PostalCodePrefixes { get; set; } = [];
    public List<FulfillmentDeliveryOption> DeliveryOptions { get; set; } = [];
    public List<string> PickupLocationIds { get; set; } = [];
}

public class FulfillmentDeliveryOption
{
    public string Code { get; set; } = string.Empty;
    public string CourierCode { get; set; } = string.Empty;
    public string CourierName { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string EstimatedAvailability { get; set; } = string.Empty;
}

public class FulfillmentPickupLocation
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string EstimatedAvailability { get; set; } = string.Empty;
}
