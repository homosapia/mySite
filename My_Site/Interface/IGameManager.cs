using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTestTaskEasy.Objects;

namespace WebTestTaskEasy.Interface
{
    public interface IGameManager
    {
        public Game NewGame();

        public Game GetGame();

        public void SetGame(Game game);

        public bool ThereIsGame();
    }
}
