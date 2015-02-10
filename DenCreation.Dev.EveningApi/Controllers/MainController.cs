using System.Web.Mvc;

namespace DenCreation.Dev.EveningApi.Controllers
{
    public class MainController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}