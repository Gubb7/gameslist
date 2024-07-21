using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameslist_2._2.Models
{
    public class Genre
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Genre(int genre)
        {
            Name = Convert.ToString((GameGenreEnum)genre);
            Description = Convert.ToString((DescriptionsEnum)genre);
        }
    }
}
