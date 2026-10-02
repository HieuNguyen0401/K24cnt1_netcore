using Microsoft.AspNetCore.Mvc;

namespace NnhLesson13Layout.Controllers
{
	public class NnhProductsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Search(string keyword)
		{
			ViewData["keyword"] = keyword;
			return View();
		}

		public IActionResult Hots()
		{
			return View();
		}

		public IActionResult About()
		{
			return View();
		}
	}
}