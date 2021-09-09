using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using My_Site.ViewsModel;

namespace My_Site.Co
{
    public class HomeController : Controller
    {
        public ActionResult Site()
        {
            ListModel model = new ListModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Site(ListModel model)
        {
            model.UserNamber.onClik = true;
            Debug.WriteLine(model.UserNamber.namber);
            return View(model);
        }
    }
}