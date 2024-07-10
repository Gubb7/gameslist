using gameslist_2._2.Models;

namespace gameslist_2._2
{
    public static class DataSource
    {
        public static IEnumerable<Game> Games { get; set; } = new List<Game>()
        {
            new (0, "TouhouFumoRacing", 0, "racing", new int[] { 3, 5, 6 }),
            new (1, "Milk outside a bag of milk outside a bag of milk", 79, "VN", new int[] { 8, 9, 12 }),
            new (2, "DOKA 2 KISHKI EDITION", 13, "shooter", new int[] { 0, 4, 7, 13 }),
            new (3, "東方実在相 ～ Dream Logical World", 0, "BulletHell", new int[] { 14, 15, 16, 17, 18 }),
            new (4, "MisterFurry", 13, "Puzzle", new int[] { 2, 10, 19, 20 }),
            new (5, "Femboys & Fries", 17, "VN", new int[] { 20, 8, 10, 21}),
            new (6, "World of Tanks", 0, "RPG", new int[] { 22, 3, 0, 23 }),
            new (7, "Ukrainian Ball in Search of Gas", 13, "racing", new int[] { 9, 10, 11 }),
            new (8, "Peth of Exile 2", 0, "ActionRPG", new int[] {0, 4, 3, 2 }),
            new (9, "沙雕之路", 0, "IndieRPG", new int[] { 4, 1, 2, 24 })
        };
    }
}
            