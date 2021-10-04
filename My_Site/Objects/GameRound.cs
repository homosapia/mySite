using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTestTaskEasy.Objects
{
    public class GameRound 
    { 
        public int UserNumber { get; set; }

        public List<int> PsychicNumber { get; set; } = new();
    }
}
