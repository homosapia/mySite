using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTestTaskEasy.Interface;
using WebTestTaskEasy.Model;

namespace WebTestTaskEasy.Objects
{
    public class Referee : IReferee
    {
        private const int percent = 100;
        public List<int> CountPsychicTrust(List<GameRound> rounds, int PsychicsCount)
        {
            List<int> TrustsPsychic = new();
  
            for (int p = 0; p < PsychicsCount; p++)
            {
                int trusts = 0;
                for (int r = 0; r < rounds.Count; r++)
                {
                    if (rounds[r].PredictionsPsychics[p] == rounds[r].NumberUser)
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
