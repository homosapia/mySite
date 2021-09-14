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
            ListModel model = new ListModel();
            
            HttpContext.Session.Set<ListModel>(model);
            
            return View(model);
        }

        [HttpPost]
        public IActionResult Site(ListModel model)
        {
            ListModel listModel = HttpContext.Session.Get<ListModel>();
            MethodsForController methods = new MethodsForController(listModel);

            if (methods.ÑheckValue(model))
                return View(listModel);


            methods.AddValueChangeTrust(model);

            HttpContext.Session.Set(listModel);
            return View(listModel);
        }

        [HttpPost]
        public IActionResult onClik(ListModel model)
        {
            ListModel listModel = HttpContext.Session.Get<ListModel>();
            MethodsForController methods = new MethodsForController(listModel);

            methods.AddNumbersForPsychics();

            HttpContext.Session.Set<ListModel>(listModel);
            return View("~/Views/Home/Site.cshtml", listModel);
        }
    }
}