using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using My_Site.ViewsModel;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace My_Site.Co
{
    public class HomeController : Controller
    {
        public IActionResult Site()
        {
            ListModel model = new ListModel();

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                model.UserNamber.ArrayNamber.Add(random.Next(10, 99));
                model.PsychicNamber.witch_1_Namber.Add(random.Next(10, 99));
                model.PsychicNamber.witch_2_Namber.Add(random.Next(10, 99));
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Site(ListModel model)
        {
            model.UserNamber.onClik = true;

            Random random = new Random();
            int witch_1_Namber = random.Next(10, 99);
            int witch_2_Namber = random.Next(10, 99);
            model.PsychicNamber.witch_1_Namber.Add(witch_1_Namber);
            model.PsychicNamber.witch_2_Namber.Add(witch_2_Namber);

            model.UserNamber.ArrayNamber.Add(model.UserNamber.namber);

            if (witch_1_Namber == model.UserNamber.namber)
                model.PsychicNamber.confidence_1++;
            else
                model.PsychicNamber.confidence_1--;

            if (witch_2_Namber == model.UserNamber.namber)
                model.PsychicNamber.confidence_2++;
            else
                model.PsychicNamber.confidence_2--;

            Debug.WriteLine(model.UserNamber.namber);
            return View(model);
        }
    }
}