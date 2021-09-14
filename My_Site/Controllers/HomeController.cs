using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using My_Site.ViewsModel;
using System;
using System.Threading.Tasks;
using System.Linq;
using My_Site.Scripts;
using System.Text.Json;
using My_Site.Scripts.Intermediate;

namespace My_Site.Co
{
    public class HomeController : Controller
    {
        public IActionResult Site()
        {
            ObjectsModel model = new();
            HttpContext.Session.SetObjects(model);
            
            return View(model);
        }

        [HttpPost]
        public IActionResult Site(ObjectsModel Postmodel)
        {
            ObjectsModel model = HttpContext.Session.GetObjects();

            MethodsForController methods = new(model);

            if (methods.ÑheckValue(Postmodel))
                return View(model);

            methods.AddValueChangeTrust(Postmodel);

            HttpContext.Session.SetObjects(model);
            return View(model);
        }

        [HttpPost]
        public IActionResult OnClik()
        {
            ObjectsModel model = HttpContext.Session.GetObjects();
            MethodsForController methods = new(model);

            methods.AddNumbersForPsychics();

            HttpContext.Session.SetObjects(model);
            return View("~/Views/Home/Site.cshtml", model);
        }
    }
}