using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTestTaskEasy.Objects;

namespace WebTestTaskEasy.Interface
{
    public interface IReferee
    {
        public List<int> CountPsychicTrust(List<GameRound> rounds, int psychicsCount);
    }
}
