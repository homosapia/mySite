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
        private IGameManager gameManager;
        public HomeController(IGameManager manager)
        {
            gameManager = manager;
        }

        public IActionResult ActivationGame()
        {
            Game game;
            if (!gameManager.ThereIsGame())
                game = gameManager.GetGame();
            else
                game = gameManager.NewGame();

            gameManager.SetGame(game);
            return View("~/Views/Home/StartRound.cshtml", game);
        }

        [HttpPost]
        public IActionResult NewRound()
        {
            Game game = gameManager.GetGame();
            game.NewRound();
            game.AskPsychics();

            gameManager.SetGame(game);
            return RedirectToAction("EnterNumber");
        }

        public IActionResult EnterNumber()
        {
            return View(gameManager.GetGame());
        }

        [HttpPost]
        public IActionResult EndRound(int number)
        {
            if (IsUserNumberInvalid(number))
            {
                return RedirectToAction("EnterNumber");
            }

            Game game = gameManager.GetGame();
            game.FinishRound(number);

            gameManager.SetGame(game);
            return RedirectToAction("StartRound");
        }

        private bool IsUserNumberInvalid(int number)
        {
            return number < Game.MinInput || number > Game.MaxInput;
        }

        public IActionResult StartRound()
        {
            return View(gameManager.GetGame());
        }
    }
}