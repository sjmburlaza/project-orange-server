using ProjectOrangeApi.DTOs;

namespace ProjectOrangeApi.Data.Seeds;

public static class CitySeed
{
    public static Dictionary<string, List<SelectOptionDto>> CitiesByRegion =>
        new()
        {
            ["metro-manila"] =
            [
                Option("Quezon City", "quezon-city"),
                Option("Makati", "makati"),
                Option("Manila", "manila"),
                Option("Taguig", "taguig"),
                Option("Pasig", "pasig")
            ],

            ["central-luzon"] =
            [
                Option("Angeles", "angeles"),
                Option("San Fernando", "san-fernando"),
                Option("Olongapo", "olongapo"),
                Option("Malolos", "malolos"),
                Option("Tarlac City", "tarlac-city")
            ],

            ["calabarzon"] =
            [
                Option("Calamba", "calamba"),
                Option("Dasmariñas", "dasmarinas"),
                Option("Antipolo", "antipolo"),
                Option("Batangas City", "batangas-city"),
                Option("Lucena", "lucena")
            ],

            ["ilocos-region"] =
            [
                Option("Laoag", "laoag"),
                Option("Vigan", "vigan"),
                Option("San Fernando City", "san-fernando-la-union"),
                Option("Dagupan", "dagupan"),
                Option("Urdaneta", "urdaneta")
            ],

            ["cagayan-valley"] =
            [
                Option("Tuguegarao", "tuguegarao"),
                Option("Cauayan", "cauayan"),
                Option("Santiago", "santiago"),
                Option("Ilagan", "ilagan"),
                Option("Bayombong", "bayombong")
            ],

            ["bicol-region"] =
            [
                Option("Legazpi", "legazpi"),
                Option("Naga", "naga"),
                Option("Sorsogon City", "sorsogon-city"),
                Option("Tabaco", "tabaco"),
                Option("Iriga", "iriga")
            ],

            ["western-visayas"] =
            [
                Option("Iloilo City", "iloilo-city"),
                Option("Bacolod", "bacolod"),
                Option("Roxas City", "roxas-city"),
                Option("Kalibo", "kalibo"),
                Option("San Jose de Buenavista", "san-jose-de-buenavista")
            ],

            ["central-visayas"] =
            [
                Option("Cebu City", "cebu-city"),
                Option("Mandaue", "mandaue"),
                Option("Lapu-Lapu", "lapu-lapu"),
                Option("Talisay", "talisay"),
                Option("Dumaguete", "dumaguete")
            ],

            ["eastern-visayas"] =
            [
                Option("Tacloban", "tacloban"),
                Option("Ormoc", "ormoc"),
                Option("Calbayog", "calbayog"),
                Option("Catbalogan", "catbalogan"),
                Option("Borongan", "borongan")
            ],

            ["zamboanga-peninsula"] =
            [
                Option("Zamboanga City", "zamboanga-city"),
                Option("Dipolog", "dipolog"),
                Option("Pagadian", "pagadian"),
                Option("Dapitan", "dapitan"),
                Option("Isabela City", "isabela-city")
            ],

            ["northern-mindanao"] =
            [
                Option("Cagayan de Oro", "cagayan-de-oro"),
                Option("Iligan", "iligan"),
                Option("Malaybalay", "malaybalay"),
                Option("Valencia", "valencia"),
                Option("Oroquieta", "oroquieta")
            ],

            ["davao-region"] =
            [
                Option("Davao City", "davao-city"),
                Option("Tagum", "tagum"),
                Option("Panabo", "panabo"),
                Option("Digos", "digos"),
                Option("Mati", "mati")
            ],

            ["soccsksargen"] =
            [
                Option("General Santos", "general-santos"),
                Option("Koronadal", "koronadal"),
                Option("Kidapawan", "kidapawan"),
                Option("Tacurong", "tacurong"),
                Option("Cotabato City", "cotabato-city")
            ],

            ["caraga"] =
            [
                Option("Butuan", "butuan"),
                Option("Surigao City", "surigao-city"),
                Option("Bislig", "bislig"),
                Option("Tandag", "tandag"),
                Option("Cabadbaran", "cabadbaran")
            ],

            ["barmm"] =
            [
                Option("Marawi", "marawi"),
                Option("Lamitan", "lamitan"),
                Option("Jolo", "jolo"),
                Option("Bongao", "bongao"),
                Option("Cotabato City", "cotabato-city-barmm")
            ],

            ["car"] =
            [
                Option("Baguio", "baguio"),
                Option("Tabuk", "tabuk"),
                Option("Bontoc", "bontoc"),
                Option("La Trinidad", "la-trinidad"),
                Option("Lagawe", "lagawe")
            ],

            ["mimaropa"] =
            [
                Option("Puerto Princesa", "puerto-princesa"),
                Option("Calapan", "calapan"),
                Option("Romblon", "romblon"),
                Option("Boac", "boac"),
                Option("San Jose", "san-jose-occidental-mindoro")
            ],

            ["negros-island-region"] =
            [
                Option("Bacolod", "bacolod-nir"),
                Option("Dumaguete", "dumaguete-nir"),
                Option("Bago", "bago"),
                Option("Kabankalan", "kabankalan"),
                Option("Canlaon", "canlaon")
            ],

            ["palawan"] =
            [
                Option("Puerto Princesa", "puerto-princesa-palawan"),
                Option("El Nido", "el-nido"),
                Option("Coron", "coron"),
                Option("Roxas", "roxas-palawan"),
                Option("Narra", "narra")
            ],

            ["aurora"] =
            [
                Option("Baler", "baler"),
                Option("Maria Aurora", "maria-aurora"),
                Option("Dingalan", "dingalan"),
                Option("Dipaculao", "dipaculao"),
                Option("Casiguran", "casiguran")
            ]
        };

    private static SelectOptionDto Option(string label, string value)
    {
        return new() { Label = label, Value = value };
    }
}