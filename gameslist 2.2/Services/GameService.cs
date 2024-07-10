using gameslist_2._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameslist_2._2.Services
{
    public class GameService
    {
        public Game GetGameByID(int id)
        {
            return DataSource.Games.First(x => x.ID == id);
        }
        
        public List<Game> GetListInPriceRange(int priceMin, int priceMax) 
        {
            return (List<Game>)DataSource.Games.Where(x => (x.Price > priceMin) &&
                                                           (x.Price < priceMax));
        }

        public List<string> GetGenresByGame(Game game)
        {
            return game.Genres;
        }

        public List<string> GetUniqueCategories(IEnumerable<Game> games)
        {
            List<string> Categories = new List<string>();
            foreach(Game game in games)
            {
                if (!Categories.Contains(game.Category))
                {
                    Categories.Add(game.Category);
                }
            }
            return Categories;
        }

        public List<Game> FilterGames(string FilterCategory, string FilterGenre)
        {
            return (List<Game>)DataSource.Games.Where(x => (x.Category == FilterCategory) &&
                                                           (x.Genres.Contains(FilterGenre)));
        }
    }
}
