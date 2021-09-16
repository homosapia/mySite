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
            HttpContext.Session.SetSaveGame(model);
            return View("~/Views/Home/ClickUser.cshtml", model);
        }

        [HttpPost]
        public IActionResult UserGuess()
        {
            Game model = HttpContext.Session.GetSaveGame();

            model.AskPsychic();

            HttpContext.Session.SetSaveGame(model);
            return RedirectToAction("InputNumber");
        }

        public IActionResult InputNumber()
        {
            Game model = HttpContext.Session.GetSaveGame();

            return View(model);
        }

        [HttpPost]
        public IActionResult UserReplied(Game postGame)
        {
            Game model = HttpContext.Session.GetSaveGame();

            if(!model.RecordInput(postGame.UserInput))
                return View("~/Views/Home/InputNumber.cshtml", model);

            model.Ñomparison();

            HttpContext.Session.SetSaveGame(model);
            return RedirectToAction("ClickUser");
        }

        public IActionResult ClickUser()
        {
            Game model = HttpContext.Session.GetSaveGame();

            return View(model);
        }
    }
}