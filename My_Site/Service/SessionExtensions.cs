using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebTestTaskEasy.Interface;
using WebTestTaskEasy.Objects;
using WebTestTaskEasy.Service;

namespace WebTestTaskEasy.Scripts
{
    public static class SessionExtensions
    {
        private static IFactoryGame factoryGame = new FactoryGame();
        public static void SaveGame(this ISession session,  Game game)
        {
            session.SetString("GameData", JsonSerializer.Serialize<GameData>(factoryGame.GetGameData(game)));
        }

        public static Game LoadGame(this ISession session)
        {
            string stringData = session.GetString("GameData");
            GameData data  = JsonSerializer.Deserialize<GameData>(stringData);
            return factoryGame.GetGame(data);
        }
    }
}
