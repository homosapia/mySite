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
        public static bool SessionActive = false;
        public static void SaveGame(this ISession session,  GameData data)
        {
            session.SetString("GameData", JsonSerializer.Serialize<GameData>(data));
            SessionActive = true;
        }

        public static GameData LoadGame(this ISession session)
        {
            string stringData = session.GetString("GameData");
            return JsonSerializer.Deserialize<GameData>(stringData);
        }
    }
}
