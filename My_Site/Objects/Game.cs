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

        public GameData GetGameData()
        {
            GameData gameData = new();
            gameData.CurrentGameRound = CurrentGameRound;
            gameData.Psychics = Psychics.ToList();
            gameData.GameRoundsHistory = GameRoundsHistory.ToList();
            return gameData;
        }

        public List<int> GetPsychicTrusts()
        {
            return _referee.CountPsychicTrust(GameRoundsHistory, Psychics.Count);
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
