using Microsoft.AspNetCore.Mvc;
using NnhLession03.Models;

namespace NnhLession03.Controllers
{
	public class NnhProductController : Controller
	{
		// Tạo mock data
		private readonly List<NnhProduct> _product = new List<NnhProduct>
		{
			new NnhProduct
			{
				NnhProductId = "SP001",
				NnhProductName = "Laptop Dell Inspiron 15",
				NnhPrice = 18500000,
				NnhYearRelease = "2024"
			},
			new NnhProduct
			{
				NnhProductId = "SP002",
				NnhProductName = "Laptop ASUS Vivobook 15",
				NnhPrice = 16900000,
				NnhYearRelease = "2024"
			},
			new NnhProduct
			{
				NnhProductId = "SP003",
				NnhProductName = "Điện thoại Samsung Galaxy S24",
				NnhPrice = 21900000,
				NnhYearRelease = "2024"
			},
			new NnhProduct
			{
				NnhProductId = "SP004",
				NnhProductName = "Điện thoại iPhone 15",
				NnhPrice = 19900000,
				NnhYearRelease = "2023"
			},
			new NnhProduct
			{
				NnhProductId = "SP005",
				NnhProductName = "Tai nghe Sony WH-1000XM5",
				NnhPrice = 7990000,
				NnhYearRelease = "2022"
			},
			new NnhProduct
			{
				NnhProductId = "SP006",
				NnhProductName = "Apple Watch Series 9",
				NnhPrice = 9990000,
				NnhYearRelease = "2023"
			},
			new NnhProduct
			{
				NnhProductId = "SP007",
				NnhProductName = "Máy tính bảng iPad Air",
				NnhPrice = 15900000,
				NnhYearRelease = "2024"
			},
			new NnhProduct
			{
				NnhProductId = "SP008",
				NnhProductName = "Màn hình LG UltraGear 27 inch",
				NnhPrice = 7290000,
				NnhYearRelease = "2023"
			},
			new NnhProduct
			{
				NnhProductId = "SP009",
				NnhProductName = "Bàn phím cơ Logitech G Pro",
				NnhPrice = 2990000,
				NnhYearRelease = "2023"
			},
			new NnhProduct
			{
				NnhProductId = "SP010",
				NnhProductName = "Chuột không dây Logitech MX Master 3S",
				NnhPrice = 2490000,
				NnhYearRelease = "2022"
			}
		};

		public IActionResult Index()
		{
			return Json(_product);
		}

		public IActionResult NnhGetAllProduct()
		{
			ViewData["Products"] = _product;
			return View();
		}
		public IActionResult NnhGetListProduct()
		{
			return View(_product);
		}
	}
}