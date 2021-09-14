using System.Collections.Generic;

namespace My_Site
{
    public class User
    {

        public int Namber { set; get; }

        public List<int> ArrayNamber { set; get; }
        
        public User()
        {
            ArrayNamber = new List<int>();
        }
    }
}
