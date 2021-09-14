using Microsoft.AspNetCore.Http;
using My_Site.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace My_Site.Scripts
{
    public static class SessionExtensions
    {
        public static void SetObjects(this ISession session, ObjectsModel value)
        {
            session.SetString("Objects", JsonSerializer.Serialize<ObjectsModel>(value));
        }

        public static ObjectsModel GetObjects(this ISession session)
        {
            var value = session.GetString("Objects");
            return value == null ? default : JsonSerializer.Deserialize<ObjectsModel>(value);
        }
    }
}
