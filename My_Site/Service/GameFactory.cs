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
    public class GameFactory : IGameFactory
    {
        private IReferee referee;
        private IGameStorage gameStorage;

        public GameFactory(IReferee referee, IGameStorage gameStorage)
        {
            this.gameStorage = gameStorage;
            this.referee = referee;
        }

        public Game Create()
        {
            if (gameStorage.SessionActive())
                return new Game(referee, gameStorage.GetGameData());

            return new Game(referee);
        }
    }
}
