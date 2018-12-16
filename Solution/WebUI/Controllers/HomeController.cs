namespace WebUI.Controllers
{
    #region Using

    using System.Linq;
    using System.Web.Mvc;
    using Data.Entities;
    using Repository;
    using Service.Services;

    #endregion

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}