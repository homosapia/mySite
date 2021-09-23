using WebTestTaskEasy.Objects;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebTestTaskEasy
{
    public class Psychic
    {
        public int GetNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min,max);
        }
    }
}