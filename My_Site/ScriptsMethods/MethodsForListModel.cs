using My_Site.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Site.Scripts
{
    public class MethodsForListModel
    {
        public ListModel onClic(ListModel model, bool onClic)
        {
            model.UserNamber.onClik = onClic;
            return model;
        }

        public void WitchNamber(ListModel model)
        {
            Random random = new Random();
            model.PsychicNamber.AllNumbersPsychic1.Add(random.Next(10, 99));
            model.PsychicNamber.AllNumbersPsychic2.Add(random.Next(10, 99));
        }

        public void NamberUser(ListModel model, int value)
        {
            model.UserNamber.ArrayNamber.Add(value);
        }

        public void CheckingForMatch(ListModel model, int value)
        {
            if (model.PsychicNamber.AllNumbersPsychic1[model.PsychicNamber.AllNumbersPsychic1.Count - 1] == value)
                model.PsychicNamber.confidence1++;
            else
                model.PsychicNamber.confidence1--;

            if (model.PsychicNamber.AllNumbersPsychic2[model.PsychicNamber.AllNumbersPsychic2.Count - 1] == value)
                model.PsychicNamber.confidence2++;
            else
                model.PsychicNamber.confidence2--;
        }
    }
}
