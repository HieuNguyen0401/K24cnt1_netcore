using Microsoft.AspNetCore.Mvc;
using NnhLession04.Models;

namespace NnhLession06Lab.Views.ViewComponents
{
	public class HotProductViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var products = new List<NnhProduct>()
			{
				new NnhProduct
				{
					Id = 1,
					Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
					Price = 2590000,
					Image = "/images/noicom.jpg",
					Category = "Đồ gia dụng"
				},

				new NnhProduct
				{
					Id = 2,
					Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
					Price = 2590000,
					Image = "/images/noicom.jpg",
					Category = "Đồ gia dụng"
				},

				new NnhProduct
				{
					Id = 3,
					Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
					Price = 2590000,
					Image = "/images/noicom.jpg",
					Category = "Đồ gia dụng"
				}
			};

			return View(products);
		}
	}
}