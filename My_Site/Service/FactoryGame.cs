using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTestTaskEasy.Interface;
using WebTestTaskEasy.Objects;

namespace WebTestTaskEasy.Service
{
    public class FactoryGame : IFactoryGame
    {
        public Game GetGame(GameData gameData)
        {
            Game game = new(gameData);
            return game;
        }

        public GameData GetGameData(Game game)
        {
            GameData gameData = new();
            gameData.SetGameData(game);
            return gameData;
        }
    }
}
