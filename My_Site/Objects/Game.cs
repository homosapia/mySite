using WebTestTaskEasy.Objects;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using WebTestTaskEasy.Interface;

namespace WebTestTaskEasy.Objects
{
    public class Game
    {
        private const int PsychicsCount = 2;

        public IReferee _referee;

        private GameRound CurrentGameRound = new();

        private List<GameRound> GameRoundsHistory = new();

        private List<Psychic> Psychics = new();

        public Game(IReferee referee)
        {
            _referee = referee;
            for (int i = 0; i < PsychicsCount; i++)
            {
                Psychic psychic = new();
                Psychics.Add(psychic);
            }
        }

        public Game(GameData gameData)
        {
            CurrentGameRound = gameData.CurrentGameRound;

            GameRoundsHistory = gameData.GameRoundsHistory.ToList();

            Psychics = gameData.Psychics.ToList();
        }

        public GameRound GetСurrentRound()
        {
            return CurrentGameRound;
        } 
        public List<GameRound> GetСompletedRounds()
        {
            return GameRoundsHistory.ToList();
        }
        public List<int> GetPsychicTrusts()
        {
            return _referee.CountPsychicTrust(GameRoundsHistory, Psychics.Count);
        }
        public List<Psychic> GetPsychics()
        {
            return Psychics.ToList();
        }

        public void FinishRound(int value)
        {
            AddUserInputToRound(value);
            GameRoundsHistory.Add(CurrentGameRound);
            IReferee referee = new Referee();

        }

        private void AddUserInputToRound(int value)
        {
            CurrentGameRound.NumberUser = value;
        }

        public void PredictionsPsychics()
        {
            CurrentGameRound.PredictionsPsychics.Clear();
            for (int i = 0; i < Psychics.Count; i++)
            {
                CurrentGameRound.PredictionsPsychics.Add(Psychics[i].GetNumber());
            }
        }
    }
}
