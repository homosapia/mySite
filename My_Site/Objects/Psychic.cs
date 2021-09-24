using WebTestTaskEasy.Objects;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebTestTaskEasy
{
    public class Psychic
    {
        private const int Min = 10;
        private const int Max = 99;
        public int GetNumber()
        {
            Random random = new Random();
            return random.Next(Min, Max);
        }
    }
}