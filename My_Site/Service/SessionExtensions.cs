using Microsoft.AspNetCore.Http;
using Psychics.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Psychics.Scripts
{
    public static class SessionExtensions
    {
        public static void SaveGame(this ISession session, Game value)
        {
            session.SetString("Game", JsonSerializer.Serialize<Game>(value));
        }

        public static Game LoadGame(this ISession session)
        {
            var value = session.GetString("Game");
            return value == null ? default : JsonSerializer.Deserialize<Game>(value);
        }
    }
}
