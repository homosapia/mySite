using My_Site.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Site.Scripts.Intermediate
{
    public class MethodsForController : MethodsForListModel
    {
        private ObjectsModel Objects;

        public MethodsForController(ObjectsModel model)
        {
            Objects = model;
        }

        public void AddNumbersForPsychics()
        {
            ClicUser(Objects, true);
            WitchNamber(Objects);
        }

        public void AddValueChangeTrust(ObjectsModel PostModel)
        {
            ClicUser(Objects, false);
            NamberUser(Objects, PostModel.User.Namber);
            CheckingForMatch(Objects, PostModel.User.Namber);
        }

        public bool СheckValue(ObjectsModel PostModel)
        {
            return PostModel.User.Namber.ToString().Length != 2 || PostModel.User.Namber < 0;
        }
    }
}
