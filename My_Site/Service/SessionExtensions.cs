using Microsoft.AspNetCore.Http;
using My_Site.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace My_Site.Scripts
{
    public static class SessionExtensions
    {
        public static void SetObjects(this ISession session, GameModel value)
        {
            session.SetString("Game", JsonSerializer.Serialize<GameModel>(value));
        }

        public static GameModel GetObjects(this ISession session)
        {
            var value = session.GetString("Game");
            return value == null ? default : JsonSerializer.Deserialize<GameModel>(value);
        }
    }
}
