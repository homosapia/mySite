using My_Site.Model;
using My_Site.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace My_Site.Service
{
    public class GameModel
    {
        [JsonInclude]
        public Game game { get; set; }
        
        [JsonInclude]
        public int InputUser { get; set; }

        public GameModel()
        {
            game = new Game();
        }

        public void WriteValuesToRound()
        {
            RoundGame round = new();
            Psychic psychic = new();

            round.Psychic1 = psychic.NumberGeneration();
            round.Psychic2 = psychic.NumberGeneration();

            game.roundGames.Add(round);
        }

        public void RememberInputUser(int value)
        {
            if (value.ToString().Length == 2 || value < 0)
            {
                game.roundGames[^1].User = value;
            }
        }
    }
}
