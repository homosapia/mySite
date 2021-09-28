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

        public GameData GetGameData()
        {
            return httpContextAccessor.HttpContext.Session.LoadGame();
        }

        public void SetGame(Game game)
        {
            httpContextAccessor.HttpContext.Session.SaveGame(game.GetGameData());
        }

        public bool SessionActive()
        {
            return Scripts.SessionExtensions.SessionActive;
        }
    }
}
