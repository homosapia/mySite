using Psychics.Objects;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Psychics
{
    public class Psychic
    {
        public int NumberGeneration(int min, int max)
        {
            Random random = new Random();
            return random.Next(min,max);
        }
    }
}