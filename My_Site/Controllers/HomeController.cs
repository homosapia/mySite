using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebTestTaskEasy.Scripts;
using WebTestTaskEasy.Model;
using WebTestTaskEasy.Objects;

namespace WebTestTaskEasy.Co
{
    public class HomeController : Controller
    {
        public IActionResult GameActivation()
        {
            Game model = new();
            model.AddPsychics(2);
            HttpContext.Session.SaveGame(model);
            return View("~/Views/Home/StartRound.cshtml", model);
        }

        [HttpPost]
        public IActionResult NewRound()
        {
            Game model = HttpContext.Session.LoadGame();

            model.NewRound();
            model.AskNumberPsychics();

            HttpContext.Session.SaveGame(model);
            return RedirectToAction("EnterNumber");
        }

        public IActionResult EnterNumber()
        {
            Game model = HttpContext.Session.LoadGame();

            return View(model);
        }

        [HttpPost]
        public IActionResult EndRound(Game postGame)
        {
            Game model = HttpContext.Session.LoadGame();

            if (!postGame.—heckInput(postGame.UserInput))
            {
                ModelState.AddModelError(nameof(postGame.UserInput), "ÕÂ ‚ÂÌ˚Â ‰‡ÌÌ˚Â");
                return View("~/Views/Home/EnterNumber.cshtml", model);
            }

            model.AddUserInputToRound(postGame.UserInput);
            model.CountTrustPsychic();

            HttpContext.Session.SaveGame(model);
            return RedirectToAction("StartRound");
        }

        public IActionResult StartRound()
        {
            Game model = HttpContext.Session.LoadGame();

            return View(model);
        }
    }
}