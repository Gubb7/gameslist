using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameslist_2._2.Models
{
    public class Game
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public List<string> Genres { get; set; }



        public Game(int id, string name, int price, string category, int[] genres)
        {
            ID = id;
            Name = name;
            Price = price;
            Category = category;
            Genres = new List<string>();
            foreach (int genre in genres)
            {
                Genres.Add(Convert.ToString((GameGenreEnum)genre));
            }
        }
    }
}