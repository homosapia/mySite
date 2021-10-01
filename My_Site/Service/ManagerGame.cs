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
    public class ManagerGame : IManagerGame
    {
        private IReferee referee;
        private IGameStorage gameStorage;

        public ManagerGame(IReferee referee, IGameStorage gameStorage)
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
            return new Game(referee, gameStorage.LoadGameData());
        }

        public void SetGame(Game game)
        {
            gameStorage.SaveGame(game);
        }

        public bool ThereIsGame()
        {
            return gameStorage.ThereIsGame();
        }
    }
}
