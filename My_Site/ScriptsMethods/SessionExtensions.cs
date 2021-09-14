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
        public static void Set<ListModel>(this ISession session, ListModel value)
        {
            session.SetString("listModel", JsonSerializer.Serialize<ListModel>(value));
        }

        public static ListModel Get<ListModel>(this ISession session)
        {
            var value = session.GetString("listModel");
            return value == null ? default(ListModel) : JsonSerializer.Deserialize<ListModel>(value);
        }
    }
}
