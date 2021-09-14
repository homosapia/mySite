using System.Collections.Generic;
namespace My_Site
{
    public class PsychicVelue
    {
        public List<int> AllNumbersPsychic1 { set; get; }
        public List<int> AllNumbersPsychic2 { set; get; }

        public int confidence1 { get; set; }
        public int confidence2 { get; set; }

        public PsychicVelue()
        {
            AllNumbersPsychic1 = new List<int>();
            AllNumbersPsychic2 = new List<int>();
        }
    }
}