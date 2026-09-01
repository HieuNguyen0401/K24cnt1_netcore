using Microsoft.AspNetCore.Mvc;
using NnhLession04.Models;

namespace NnhLession04.Controllers
{
	public class NnhAccountController : Controller
	{
		private readonly List<NnhAccount> nnhAccounts = new List<NnhAccount>
		{
			new NnhAccount
			{
				Id = 1,
				Name = "Nguyen Van An",
				Email = "nguyenvanan@gmail.com",
				Phone = "0987654321",
				Avatar = "/Image/1.jpg",
				Address = "Ha Noi",
				Bio = "Sinh vien CNTT",
				Gender = 1,
				Birthday = new DateTime(2005, 5, 10)
			},

			new NnhAccount
			{
				Id = 2,
				Name = "Tran Thi Binh",
				Email = "tranthibinh@gmail.com",
				Phone = "0978123456",
				Avatar = "/Image/2.jpg",
				Address = "Hai Phong",
				Bio = "Yeu thich lap trinh",
				Gender = 0,
				Birthday = new DateTime(2005, 8, 20)
			},

			new NnhAccount
			{
				Id = 3,
				Name = "Le Van Cuong",
				Email = "levancuong@gmail.com",
				Phone = "0965432109",
				Avatar = "/Image/3.jpg",
				Address = "Thanh Hoa",
				Bio = "Sinh vien nam 2",
				Gender = 1,
				Birthday = new DateTime(2004, 12, 15)
			},

			new NnhAccount
			{
				Id = 4,
				Name = "Pham Thi Dung",
				Email = "phamthidung@gmail.com",
				Phone = "0912345678",
				Avatar = "/Image/4.jpg",
				Address = "Nam Dinh",
				Bio = "Thich doc sach",
				Gender = 0,
				Birthday = new DateTime(2006, 3, 25)
			}
		};

		// Trang danh sách
		public IActionResult NnhIndex()
		{
			ViewBag.NnhAccounts = nnhAccounts;

			return View();
		}

		// Trang Profile
		[Route("ho-so-cua-toi/{id?}", Name = "NnhProfile")]
		public IActionResult NnhProfile(int id = 1)
		{
			var account = nnhAccounts.FirstOrDefault(x => x.Id == id);

			if (account == null)
			{
				return NotFound();
			}

			ViewBag.NnhAccount = account;

			return View();
		}
	}
}