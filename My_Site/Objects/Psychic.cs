using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace My_Site
{
    public class Psychic
    {
        public int NumberGeneration()
        {
            Random random = new Random();
            return random.Next(10,99);
        }
    }
}