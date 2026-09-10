using Microsoft.AspNetCore.Mvc;
using NnhLession06Lab06.Models;

namespace NnhLession06Lab06.ViewComponents
{
	public class NnhHotProductViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var nnhProducts = new List<NnhProduct>
			{
				new NnhProduct
				{
					Id = 4,
					Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
					Price = 2890000,
					Image = "/images/rice-cooker.jpg"
				},

				new NnhProduct
				{
					Id = 5,
					Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
					Price = 2890000,
					Image = "/images/rice-cooker.jpg"
				},

				new NnhProduct
				{
					Id = 6,
					Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
					Price = 2890000,
					Image = "/images/rice-cooker.jpg"
				}
			};

			return View(nnhProducts);
		}
	}
}