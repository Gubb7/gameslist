using gameslist_2._2.Models;

namespace gameslist_2._2
{
    public static class DataSource
    {
        public static IEnumerable<Game> Games { get; set; } = new List<Game>()
        {
            new (0, "TouhouFumoRacing", 0, "racing", new List<Genre>(){new(3), new(5), new(6)}),
            new (1, "Milk outside a bag of milk outside a bag of milk", 79, "VN", new List<Genre>(){new(8), new(9), new(12)}),
            new (2, "DOKA 2 KISHKI EDITION", 13, "shooter", new List<Genre>(){new(0), new(4), new(7), new(13)}),
            new (3, "東方実在相 ～ Dream Logical World", 0, "BulletHell", new List<Genre>(){new(14), new(15), new(16), new(17), new(18)}),
            new (4, "MisterFurry", 13, "Puzzle", new List < Genre >() { new(2), new(10), new(19)}),
            new (5, "Femboys & Fries", 17, "VN", new List < Genre >() { new(20), new(8), new(10), new(21)}),
            new (6, "World of Tanks", 0, "RPG", new List < Genre >() { new(22), new(3), new(0), new(23)}),
            new (7, "Ukrainian Ball in Search of Gas", 13, "racing", new List < Genre >() { new(9), new(10), new(11) }),
            new (8, "Peth of Exile 2", 0, "ActionRPG", new List < Genre >() { new(0), new(4), new(3), new(2) }),
            new (9, "沙雕之路", 0, "IndieRPG", new List < Genre >() { new(4), new(1), new(2), new(24) })
        };
    }
}
            