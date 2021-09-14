using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Site.ViewsModel
{
    public class ObjectsModel
    {
        public bool ClickUser { get; set; }
        public List<Psychic> Psychics { get; set; }
        public User User { get; set; }

        public ObjectsModel()
        {
            Psychics = new List<Psychic>
            {
                new Psychic(),
                new Psychic()
            };

            User = new User();
        }
    }
}
