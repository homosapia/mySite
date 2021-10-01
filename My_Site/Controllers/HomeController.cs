using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebTestTaskEasy.Scripts;
using WebTestTaskEasy.Objects;
using WebTestTaskEasy.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace WebTestTaskEasy.Co
{
    public class HomeController : Controller
    {
        readonly IGameManager GameManager;
        public HomeController(IGameManager Manager)
        {
            GameManager = Manager;
        }

        public IActionResult ActivationGame()
        {
            Game game;
            if (!GameManager.ThereIsGame())
                game = GameManager.GetGame();
            else
                game = GameManager.NewGame();

            GameManager.SetGame(game);
            return View("~/Views/Home/StartRound.cshtml", game);
        }

        [HttpPost]
        public IActionResult NewRound()
        {
            Game game = GameManager.GetGame();
            game.NewRound();
            game.AskPsychics();

            GameManager.SetGame(game);
            return RedirectToAction("EnterNumber");
        }

        public IActionResult EnterNumber()
        {
            return View(GameManager.GetGame());
        }

        [HttpPost]
        public IActionResult EndRound(int number)
        {
            if (IsUserNumberInvalid(number))
            {
                return RedirectToAction("EnterNumber");
            }

            Game game = GameManager.GetGame();
            game.FinishRound(number);

            GameManager.SetGame(game);
            return RedirectToAction("StartRound");
        }

        private bool IsUserNumberInvalid(int number)
        {
            return number < Game.MinInput || number > Game.MaxInput;
        }

        public IActionResult StartRound()
        {
            return View(GameManager.GetGame());
        }
    }
}