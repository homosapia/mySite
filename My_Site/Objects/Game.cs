using My_Site.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace My_Site.Model
{
    public class Game
    {
        [JsonInclude]
        public List<RoundGame> roundGames { get; private set; }

        [JsonInclude]
        public int Trust1 { get; private set; }

        [JsonInclude]
        public int Trust2 { get; private set; }

        public Game()
        {
            roundGames = new List<RoundGame>();
        }

        public void Сomparison(int value)
        {
            if (value.ToString().Length == 2 || value < 0)
            {
                if (roundGames[^1].Psychic1 == value)
                    Trust1++;
                else
                    Trust1--;

                if (roundGames[^1].Psychic2 == value)
                    Trust2++;
                else
                    Trust2--;
            }
        }
    }
}
