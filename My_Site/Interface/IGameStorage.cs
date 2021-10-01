using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTestTaskEasy.Objects;

namespace WebTestTaskEasy.Interface
{
    public interface IGameStorage
    {
        public GameData LoadGameData();

        public void SaveGame(Game game);

        bool ThereIsGame();
    }
}
