using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WebTestTaskEasy.Interface;

namespace WebTestTaskEasy.Objects
{
    public class GameData
    {
        [JsonInclude]
        public GameRound CurrentGameRound = new();

        [JsonInclude]
        public List<GameRound> GameRoundsHistory = new();

        [JsonInclude]
        public List<Psychic> Psychics = new();

        public void SetGameData(Game game)
        {
            CurrentGameRound = game.GetСurrentRound();
            GameRoundsHistory = game.GetСompletedRounds();
            Psychics = game.GetPsychics();
        }
    }
}
