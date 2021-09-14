using System.Collections.Generic;
namespace My_Site
{
    public class Psychic
    {
        public List<int> AllNumbersPsychic { set; get; }

        public int Trust { get; set; }

        public Psychic()
        {
            AllNumbersPsychic = new List<int>();
        }
    }
}