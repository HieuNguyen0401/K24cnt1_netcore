using Microsoft.AspNetCore.Mvc;
using NnhLession04.Models;

namespace NnhLession04.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			List<NnhProduct> products = new List<NnhProduct>()
			{
				new NnhProduct
				{
					Id = 1,
					Name = "Noi com dien cao tan Nagakawa NAG0102",
					Price = 2590000,
					Image = "/images/noicom.jpg",
					Category = "Do gia dung"
				},

				new NnhProduct
				{
					Id = 2,
					Name = "Noi com dien cao tan Nagakawa NAG0102",
					Price = 2590000,
					Image = "/images/noicom.jpg",
					Category = "Do gia dung"
				},

				new NnhProduct
				{
					Id = 3,
					Name = "Noi com dien cao tan Nagakawa NAG0102",
					Price = 2590000,
					Image = "/images/noicom.jpg",
					Category = "Do gia dung"
				},

				new NnhProduct
				{
					Id = 4,
					Name = "Noi com dien cao tan Nagakawa NAG0102",
					Price = 2590000,
					Image = "/images/noicom.jpg",
					Category = "Do gia dung"
				},

				new NnhProduct
				{
					Id = 5,
					Name = "Noi com dien cao tan Nagakawa NAG0102",
					Price = 2590000,
					Image = "/images/noicom.jpg",
					Category = "Do gia dung"
				},

				new NnhProduct
				{
					Id = 6,
					Name = "Noi com dien cao tan Nagakawa NAG0102",
					Price = 2590000,
					Image = "/images/noicom.jpg",
					Category = "Do gia dung"
				}
			};

			return View(products);
		}
	}
}