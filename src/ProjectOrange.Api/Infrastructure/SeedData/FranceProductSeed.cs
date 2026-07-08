namespace ProjectOrangeApi.Data.Seeds;

internal static class FranceProductSeed
{
    internal static ProductSeedEntry[] Products =>
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
        new(23, "Moniteur Ultrawide 34 pouces", "Écran incurvé UWQHD pour le multitâche et les configurations immersives.", 549, 6, "", 4),

        new(24, "Google Pixel 8a", "Smartphone compact avec fonctions photo assistées par IA.", 549, 15, "", 1),
        new(25, "Samsung Galaxy S24", "Smartphone premium avec écran lumineux et fonctions Galaxy AI.", 899, 11, "", 1),
        new(26, "Honor 200 Pro", "Smartphone 5G orienté portrait avec écran OLED.", 699, 12, "", 1),
        new(27, "Motorola Edge 50 Pro", "Smartphone fin avec charge rapide et écran incurvé.", 699, 13, "", 1),
        new(28, "OnePlus Nord 4", "Smartphone fluide avec châssis métallique et grande autonomie.", 499, 17, "", 1),
        new(29, "Sony Xperia 10 VI", "Smartphone léger avec écran OLED et autonomie prolongée.", 399, 14, "", 1),

        new(30, "Dell Inspiron 14 Plus", "PC portable polyvalent pour la bureautique et la création.", 1099, 8, "", 2),
        new(31, "Acer Swift Go 14", "Ultrabook OLED compact pour le travail en déplacement.", 899, 10, "", 2),
        new(32, "Framework Laptop 13", "Ordinateur portable modulaire conçu pour être réparé et amélioré.", 1349, 6, "", 2),
        new(33, "MSI Prestige 14 AI", "Portable professionnel léger avec processeur basse consommation.", 1299, 7, "", 2),
        new(34, "LG Gram 16", "Grand ordinateur portable particulièrement léger pour sa taille.", 1599, 5, "", 2),
        new(35, "ASUS TUF Gaming A15", "PC portable gaming robuste avec écran à fréquence élevée.", 1199, 8, "", 2),

        new(36, "Moniteur Gaming 27 pouces 180 Hz", "Écran IPS rapide pour des jeux fluides et réactifs.", 329, 9, "", 4),
        new(37, "Moniteur USB-C 24 pouces", "Écran de bureau compact avec connexion USB-C pratique.", 249, 11, "", 4),
        new(38, "Moniteur Incurvé 32 pouces QHD", "Grand écran incurvé pour le travail et le divertissement.", 399, 7, "", 4),
        new(39, "Moniteur Créatif 28 pouces 4K", "Écran UHD aux couleurs précises pour la création visuelle.", 499, 6, "", 4),
        new(40, "Moniteur Portable 15,6 pouces", "Second écran Full HD fin pour les déplacements.", 189, 14, "", 4)
    ];
}
