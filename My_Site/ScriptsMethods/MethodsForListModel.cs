using My_Site.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Site.Scripts
{
    public class MethodsForListModel
    {


        public void ClicUser(ObjectsModel model, bool clic)
        {
            model.ClickUser = clic;
        }
        public void WitchNamber(ObjectsModel model)
        {
            Random random = new Random();

            foreach(var i in model.Psychics)
            {
                i.AllNumbersPsychic.Add(random.Next(10, 99));
            };
        }

        public void NamberUser(ObjectsModel model, int value)
        {
            model.User.ArrayNamber.Add(value);
        }

        public void CheckingForMatch(ObjectsModel model, int value)
        {
            for (int i = 0; i < model.Psychics.Count; i++)
            {
                if (model.Psychics[i].AllNumbersPsychic[^1] == value)
                    model.Psychics[i].Trust++;
                else
                    model.Psychics[i].Trust--;
            }
        }
    }
}
