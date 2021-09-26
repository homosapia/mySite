using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebTestTaskEasy.Interface;
using WebTestTaskEasy.Objects;

namespace WebTestTaskEasy.Scripts
{
    public static class SessionExtensions
    {
        public static void SaveGame(this ISession session,  Game game)
        {
            session.SetString("GameData", JsonSerializer.Serialize<GameData>(game.GetGameData()));
        }

        public static Game LoadGame(this ISession session)
        {
            string stringData = session.GetString("GameData");
            return new Game(JsonSerializer.Deserialize<GameData>(stringData));
        }
    }
}
