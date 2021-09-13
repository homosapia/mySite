using System.Collections.Generic;

namespace My_Site
{
    public class UserNamber
    {

        public int namber { set; get; }

        public bool onClik { set; get; }

        public List<int> ArrayNamber { set; get; }
        
        public UserNamber()
        {
            ArrayNamber = new List<int>();
        }
    }
}
