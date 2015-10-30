using System.Web.Mvc;

namespace SampleWebsite.Mvc4.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Message = "Welcome to ASP.NET MVC4!";

			return View();
		}

		public ActionResult About()
		{
			return View();
		}
	}
}
