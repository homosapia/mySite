using System.Collections.Generic;
namespace My_Site
{
    public class PsychicNamber
    {
        public List<int> witch_1_Namber { set; get; }
        public List<int> witch_2_Namber { set; get; }

        public PsychicNamber()
        {
            witch_1_Namber = new List<int>();
            witch_2_Namber = new List<int>();
        }
    }
}