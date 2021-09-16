using Microsoft.AspNetCore.Http;
using My_Site.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace My_Site.Scripts
{
    public static class SessionExtensions
    {
        public static void SetSaveGame(this ISession session, Game value)
        {
            session.SetString("Game", JsonSerializer.Serialize<Game>(value));
        }

        public static Game GetSaveGame(this ISession session)
        {
            var value = session.GetString("Game");
            return value == null ? default : JsonSerializer.Deserialize<Game>(value);
        }
    }
}
