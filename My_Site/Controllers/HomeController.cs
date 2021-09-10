using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using My_Site.ViewsModel;
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Text.Json;

namespace My_Site.Co
{
    public class HomeController : Controller
    {
        public IActionResult Site()
        {
            ListModel model = new ListModel();

            HttpContext.Session.SetString("Model", JsonSerializer.Serialize<ListModel>(model));
            return View(model);
        }

        [HttpPost]
        public IActionResult Site(ListModel model)
        {
            var value = HttpContext.Session.GetString("Model");
            ListModel listModel = value == null ? default(ListModel) : JsonSerializer.Deserialize<ListModel>(value);

            if(model.UserNamber.namber.ToString().Length != 2 || model.UserNamber.namber < 0)
            {
                return View(listModel);
            }

            listModel.UserNamber.ArrayNamber.Add(model.UserNamber.namber);

            if (listModel.PsychicNamber.witch_1_Namber[listModel.PsychicNamber.witch_1_Namber.Count - 1] == model.UserNamber.namber)
                listModel.PsychicNamber.confidence_1++;
            else
                listModel.PsychicNamber.confidence_1--;

            if (listModel.PsychicNamber.witch_2_Namber[listModel.PsychicNamber.witch_2_Namber.Count - 1] == model.UserNamber.namber)
                listModel.PsychicNamber.confidence_2++;
            else
                listModel.PsychicNamber.confidence_2--;

            listModel.UserNamber.onClik = false;

            HttpContext.Session.SetString("Model", JsonSerializer.Serialize<ListModel>(listModel));
            return View(listModel);
        }

        [HttpPost]
        public IActionResult onClik(ListModel model)
        {
            var value = HttpContext.Session.GetString("Model");
            ListModel listModel = value == null ? default(ListModel) : JsonSerializer.Deserialize<ListModel>(value);
            
            listModel.UserNamber.onClik = true;

            Random random = new Random();
            int witch_1_Namber = random.Next(10, 99);
            int witch_2_Namber = random.Next(10, 99);
            listModel.PsychicNamber.witch_1_Namber.Add(witch_1_Namber);
            listModel.PsychicNamber.witch_2_Namber.Add(witch_2_Namber);


            HttpContext.Session.SetString("Model", JsonSerializer.Serialize<ListModel>(listModel));
            return View("~/Views/Home/Site.cshtml", listModel);
        }
    }
}