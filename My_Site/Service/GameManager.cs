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
    public class GameManager : IGameManager
    {
        private IReferee Referee;
        private IGameStorage GameStorage;

        public GameManager(IReferee referee, IGameStorage gameStorage)
        {
            GameStorage = gameStorage;
            Referee = referee;
        }

        public Game NewGame()
        {
            return new Game(Referee);
        }

        public Game GetGame()
        {
            return new Game(Referee, GameStorage.LoadGameData());
        }

        public void SetGame(Game game)
        {
            GameStorage.SaveGame(game);
        }

        public bool ThereIsGame()
        {
            return GameStorage.ThereIsGame();
        }
    }
}
