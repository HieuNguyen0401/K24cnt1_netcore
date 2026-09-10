using Microsoft.AspNetCore.Mvc;
using NnhLession06Lab06.Models;

namespace NnhLession06Lab06.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			var nnhProducts = new List<NnhProduct>
			{
				new NnhProduct
				{
					Id = 1,
					Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
					Price = 2890000,
					Image = "/images/rice-cooker.jpg"
				},

				new NnhProduct
				{
					Id = 2,
					Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
					Price = 2890000,
					Image = "/images/rice-cooker.jpg"
				},

				new NnhProduct
				{
					Id = 3,
					Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
					Price = 2890000,
					Image = "/images/rice-cooker.jpg"
				}
			};

			return View(nnhProducts);
		}
	}
}