using System.Collections.Generic;
namespace My_Site
{
    public class PsychicVelue
    {
        public List<int> witch_1_Namber { set; get; }
        public List<int> witch_2_Namber { set; get; }

        public int confidence_1 { get; set; }
        public int confidence_2 { get; set; }

        public PsychicVelue()
        {
            witch_1_Namber = new List<int>();
            witch_2_Namber = new List<int>();
        }
    }
}