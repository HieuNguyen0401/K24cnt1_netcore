using Microsoft.AspNetCore.Mvc;
using NnhProductLesson2.Models;

namespace NnhProductLesson2.Controllers
{
	public class NnhProductController : Controller
	{
		public IActionResult Index()
		{
			ViewBag.Name = "Ngọc Hiếu ";
			ViewData["address"] = "Fit NTU";
			TempData["uni"] = "Đại học ntu";
			return View();
		}

		public IActionResult GetProduct()
		{
			NnhProduct nnhProduct = new NnhProduct()
			{
				ProductId = "P001",
				ProductName = "Laptop dell",
				YearRelease = 2020,
				Price = 15000000
			};

			ViewData["productVD"] = nnhProduct;
			ViewBag.productVB = nnhProduct;

			return View();
		}
	}
}