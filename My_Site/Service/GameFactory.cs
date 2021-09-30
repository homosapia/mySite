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

        public Game NewGame()
        {
            return new Game(referee);
        }

        public Game GetGame()
        {
            return new Game(referee, gameStorage.GetGameData());
        }

        public void SetGame(Game game)
        {
            gameStorage.
        }
    }
}
