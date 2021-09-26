using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTestTaskEasy.Objects;

namespace WebTestTaskEasy.Interface
{
    public interface IFactoryGame
    {
        public Game GetGame(GameData gameData);
        public GameData GetGameData(Game game);
    }
}
