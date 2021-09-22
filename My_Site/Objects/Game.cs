using Psychics.Objects;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace Psychics.Model
{
    public class Game
    {
        const int Min = 10;
        const int Max = 99;

        [JsonInclude]
        public List<GameRound> GameRounds { get; private set; } = new();

        [JsonInclude]
        public List<int> PsychicTrusts { get; private set; } = new();

        [JsonInclude]
        public List<Psychic> Psychics { get; private set; } = new();

        public int UserInput { get; set; }

        public void NewRound()
        {
            GameRound round = new GameRound();
            GameRounds.Add(round);
        }

        public GameRound CurrentRound()
        {
            return GameRounds.Last();
        }

        public void AddPsychics(int amount)
        {

            for (int i = 0; i < amount; i++)
            {
                Psychic psychic = new();
                Psychics.Add(psychic);
                PsychicTrusts.Add(0);
            }
        }

        public void CountTrustPsychic()
        {
            for(int i = 0; i < Psychics.Count; i++)
            {
                if (CurrentRound().Psychics[i] == CurrentRound().User)
                    PsychicTrusts[i]++;
                else
                    PsychicTrusts[i]--;
            }
        }

        public void AskNumberPsychics()
        {
            CurrentRound().Psychics = new List<int>();

            for (int i = 0; i < Psychics.Count; i++)
            {
                CurrentRound().Psychics.Add(Psychics[i].NumberGeneration(Min, Max));
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
            CurrentRound().User = value;
        }

    }
}
