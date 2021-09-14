using My_Site.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Site.Scripts.Intermediate
{
    public class MethodsForController
    {
        private ListModel listModel;
        MethodsForListModel Methods;

        public MethodsForController(ListModel model)
        {
            listModel = model;
            Methods = new MethodsForListModel();
        }

        public void AddNumbersForPsychics()
        {
            Methods.onClic(listModel, true);
            Methods.WitchNamber(listModel);
        }

        public void AddValueChangeTrust(ListModel PostModel)
        {
            Methods.NamberUser(listModel, PostModel.UserNamber.namber);
            Methods.CheckingForMatch(listModel, PostModel.UserNamber.namber);
            Methods.onClic(listModel, false);
        }

        public bool СheckValue(ListModel PostModel)
        {
            return PostModel.UserNamber.namber.ToString().Length != 2 || PostModel.UserNamber.namber < 0;
        }
    }
}
