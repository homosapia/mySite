using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Site.ViewsModel
{
    public class ListModel
    {
        public PsychicVelue PsychicNamber { get; set; }
        public UserNamber UserNamber { get; set; }
        
        public ListModel()
        {
            PsychicNamber = new PsychicVelue();
            UserNamber = new UserNamber();
        }
    }
}
