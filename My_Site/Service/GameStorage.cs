using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTestTaskEasy.Interface;
using WebTestTaskEasy.Objects;
using WebTestTaskEasy.Scripts;

namespace WebTestTaskEasy.Service
{
    public class GameStorage : IGameStorage
    {
        private IHttpContextAccessor httpContextAccessor;

        public GameStorage(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public GameData LoadGameData()
        {
            return httpContextAccessor.HttpContext.Session.LoadData();
        }

        public void SaveGame(Game game)
        {
            httpContextAccessor.HttpContext.Session.SaveGame(game.GetGameData());
        }

        public bool SessionExists()
        {
            return httpContextAccessor.HttpContext.Session.SessionData();
        }
    }
}
