using WebTestTaskEasy.Objects;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebTestTaskEasy.Objects
{
    public class Psychic
    {
        public int GetNumber(int Min, int Max)
        {
            Random random = new Random();
            return random.Next(Min, Max);
        }
    }
}