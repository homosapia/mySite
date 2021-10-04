using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTestTaskEasy.Interface;

namespace WebTestTaskEasy.Objects
{
    public class Referee : IReferee
    {
        public List<int> CountPsychicTrust(List<GameRound> rounds, int psychicsCount)
        {
            List<int> TrustsPsychic = new();
  
            for (int p = 0; p < psychicsCount; p++)
            {
                int trusts = 0;
                for (int r = 0; r < rounds.Count; r++)
                {
                    if (rounds[r].PsychicNumber[p] == rounds[r].UserNumber)
                        trusts++;
                    else
                        trusts--;
                }

                TrustsPsychic.Add(trusts);
            }
            
            return TrustsPsychic;
        }
    }
}
