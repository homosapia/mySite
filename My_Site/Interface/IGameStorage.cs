using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTestTaskEasy.Objects;

namespace WebTestTaskEasy.Interface
{
    public interface IGameStorage
    {
        public GameData GetGameData();

        public void SetGame(Game game);

        bool SessionActive();
    }
}
