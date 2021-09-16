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

        public int UserInput { get; set; }

        public Game()
        {
            roundGames = new List<RoundGame>();
        }

        public void Сomparison()
        {
            if (roundGames[^1].Psychic1 == roundGames[^1].User)
                Trust1++;
            else
                Trust1--;

            if (roundGames[^1].Psychic2 == roundGames[^1].User)
                Trust2++;
            else
                Trust2--;
        }

        public void AskPsychic()
        {
            Psychic psychic = new();
            RoundGame round = new();

            round.Psychic1 = psychic.NumberGeneration();
            round.Psychic2 = psychic.NumberGeneration();

            roundGames.Add(round);
        }

        public bool RecordInput(int value)
        {
            if (value.ToString().Length == 2 && value > 0)
            {
                roundGames[^1].User = value;
                return true;
            }

            return false;
        }
    }
}
