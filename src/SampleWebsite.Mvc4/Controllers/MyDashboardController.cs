using System.Web.Mvc;

namespace SampleWebsite.Mvc4.Controllers
{
    [Authorize]
	public class MyDashboardController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Message = "This is your dashboard";

			return View();
		}
        
	}
}
