using WebTestTaskEasy.Objects;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using WebTestTaskEasy.Interface;

namespace WebTestTaskEasy.Objects
{
    public class Game
    {
        public const int Min = 10;
        public const int Max = 99;

        private const int CauntPsychics = 2;

        private IReferee referee;

        private GameRound CurrentGameRound;

        private List<GameRound> GameRoundsHistory = new();

        private List<Psychic> Psychics = new();

        public Game(IReferee _referee)
        {
            referee = _referee;
            InitPsychics();
        }


        public Game(IReferee referee, GameData gameData)
        {
            this.referee = referee;

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

        public void СreateNewRound()
        {
            CurrentGameRound = new();
        }

        private void InitPsychics()
        {
            for (int i = 0; i < CauntPsychics; i++)
            {
                Psychic psychic = new();
                Psychics.Add(psychic);
            }
        }

        public List<int> GetPsychicTrusts()
        {
            return referee.CountPsychicTrust(GameRoundsHistory, Psychics.Count);
        }

        public void FinishRound(int value)
        {
            CurrentGameRound.UserNumber = value;

            if (!GameRoundsHistory.Contains(CurrentGameRound))
                GameRoundsHistory.Add(CurrentGameRound);
        }

        public void AskPsychics()
        {
            CurrentGameRound.PredictionsPsychics.Clear();
            for (int i = 0; i < Psychics.Count; i++)
            {
                CurrentGameRound.PredictionsPsychics.Add(Psychics[i].GetNumber(Min, Max));
            }
        }
    }
}
