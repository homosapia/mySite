using WebTestTaskEasy.Objects;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace WebTestTaskEasy.Model
{
    public class Game
    {
        const int Min = 10;
        const int Max = 99;

        [JsonInclude]
        public List<GameRound> GameRounds = new();

        [JsonInclude]
        public List<int> PsychicTrusts = new();

        [JsonInclude]
        public List<Psychic> Psychics = new();

        public int UserInput { get; set; }

        public List<GameRound> GetGameRounds()
        {
            List<GameRound> rounds = GameRounds.ToList();
            if(rounds.Count>0)
                rounds.Remove(rounds.Last());
            return rounds;
        }
        public List<int> GetPsychicTrusts()
        {
            return PsychicTrusts.ToList();
        }

        public List<Psychic> GetPsychics()
        {
            return Psychics.ToList();
        }

        public void NewRound()
        {
            GameRound round = new GameRound();
            GameRounds.Add(round);
        }

        public GameRound GetCurrentRound()
        {
            return GameRounds.Last();
        }

        public void AddPsychics(int amount)
        {
            if (!Psychics.Any())
            {
                for (int i = 0; i < amount; i++)
                {
                    Psychic psychic = new();
                    Psychics.Add(psychic);
                    PsychicTrusts.Add(0);
                }
            }
        }

        public void CountTrustPsychic()
        {
            for(int i = 0; i < Psychics.Count; i++)
            {
                if (GetCurrentRound().PredictionsPsychics[i] == GetCurrentRound().NumberUser)
                    PsychicTrusts[i]++;
                else
                    PsychicTrusts[i]--;
            }
        }

        public void AskNumberPsychics()
        {
            GetCurrentRound().PredictionsPsychics = new List<int>();

            for (int i = 0; i < Psychics.Count; i++)
            {
                GetCurrentRound().PredictionsPsychics.Add(Psychics[i].GetNumber(Min, Max));
            }
        }

        public bool СheckInput(int value)
        {
            if (value >= Min && value <= Max)
                return true;
            return false;
        }

        public void AddUserInputToRound(int value)
        {
            GetCurrentRound().NumberUser = value;
        }

    }
}
