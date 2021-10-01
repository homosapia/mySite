using WebTestTaskEasy.Objects;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using WebTestTaskEasy.Interface;

namespace WebTestTaskEasy.Objects
{
    public class Game
    {
        public const int MinInput = 10;
        public const int MaxInput = 99;

        private const int countPsychics = 2;

        private IReferee ceferee;

        private GameRound currentGameRound;

        private List<GameRound> gameRoundsHistory = new();

        private List<Psychic> psychics = new();

        public Game(IReferee referee)
        {
            ceferee = referee;
            InitPsychics();
        }


        public Game(IReferee referee, GameData gameData)
        {
            ceferee = referee;

            currentGameRound = gameData.CurrentGameRound;

            gameRoundsHistory = gameData.GameRoundsHistory.ToList();

            psychics = gameData.Psychics.ToList();
        }

        public GameData GetGameData()
        {
            GameData gameData = new();
            gameData.CurrentGameRound = currentGameRound;
            gameData.Psychics = psychics.ToList();
            gameData.GameRoundsHistory = gameRoundsHistory.ToList();
            return gameData;
        }

        public void NewRound()
        {
            currentGameRound = new();
        }

        private void InitPsychics()
        {
            for (int i = 0; i < countPsychics; i++)
            {
                Psychic psychic = new();
                psychics.Add(psychic);
            }
        }

        public List<int> GetPsychicTrusts()
        {
            return ceferee.CountPsychicTrust(gameRoundsHistory, psychics.Count);
        }

        public void FinishRound(int value)
        {
            currentGameRound.UserNumber = value;

            if (!gameRoundsHistory.Contains(currentGameRound))
                gameRoundsHistory.Add(currentGameRound);
        }

        public void AskPsychics()
        {
            currentGameRound.PredictionsPsychics.Clear();
            for (int i = 0; i < psychics.Count; i++)
            {
                currentGameRound.PredictionsPsychics.Add(psychics[i].GetNumber(MinInput, MaxInput));
            }
        }
    }
}
