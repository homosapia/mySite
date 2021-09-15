using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System;
using System.Threading.Tasks;
using System.Linq;
using My_Site.Scripts;
using System.Text.Json;
using My_Site.Model;

namespace My_Site.Co
{
    public class HomeController : Controller
    {
        public IActionResult Site()
        {
            Game model = new();
            HttpContext.Session.SetObjects(model);
            return View("~/Views/Home/ClickUser.cshtml", model);
        }

        [HttpPost]
        public IActionResult OnClik()
        {
            Game model = HttpContext.Session.GetObjects();

            model.AskPsychic();

            HttpContext.Session.SetObjects(model);
            return View("~/Views/Home/InputNamber.cshtml", model);
        }

        [HttpPost]
        public IActionResult InputNamber(Game postGame)
        {
            Game model = HttpContext.Session.GetObjects();

            if (!model.RecordInput(postGame.UserInput))
                return View("~/Views/Home/InputNamber.cshtml", model);

            model.Ñomparison();

            HttpContext.Session.SetObjects(model);
            return View("~/Views/Home/ClickUser.cshtml", model);
        }
    }
}