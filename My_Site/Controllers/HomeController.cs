using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System;
using System.Threading.Tasks;
using System.Linq;
using My_Site.Scripts;
using System.Text.Json;
using My_Site.Service;

namespace My_Site.Co
{
    public class HomeController : Controller
    {
        public IActionResult Site()
        {
            GameModel model = new();
            HttpContext.Session.SetObjects(model);
            return View("~/Views/Home/ClickUser.cshtml", model);
        }

        [HttpPost]
        public IActionResult InputNamber(GameModel postModel)
        {
            GameModel model = HttpContext.Session.GetObjects();

            model.RememberInputUser(postModel.InputUser);
            model.game.Ñomparison(postModel.InputUser);

            HttpContext.Session.SetObjects(model);
            return View("~/Views/Home/ClickUser.cshtml", model);
        }

        [HttpPost]
        public IActionResult OnClik()
        {
            GameModel model = HttpContext.Session.GetObjects();

            model.WriteValuesToRound();

            HttpContext.Session.SetObjects(model);
            return View("~/Views/Home/InputNamber.cshtml", model);
        }
    }
}