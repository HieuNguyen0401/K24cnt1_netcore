using Microsoft.AspNetCore.Mvc;
using NnhLession07Models.Models.DataModels;

namespace NnhLession07Models.Controllers
{
	public class NnhMemberController : Controller
	{
		// CHỈ SỬA DÒNG NÀY: thêm static
		protected static List<Models.DataModels.NnhMember> _members = new List<Models.DataModels.NnhMember>
		{
			new Models.DataModels.NnhMember
			{
				NnhMemberId = Guid.NewGuid().ToString(),
				NnhUserName = "Nguyen Ngoc Hieu",
				NnhPassword = "123456",
				NnhFullname = "Nguyen Ngoc Hieu",
				NnhEmail = "Taodeptrai@gmail.com"
			},

			new Models.DataModels.NnhMember
			{
				NnhMemberId = Guid.NewGuid().ToString(),
				NnhUserName = "tranbinh",
				NnhPassword = "123456",
				NnhFullname = "Tran Van Binh",
				NnhEmail = "tranbinh@gmail.com"
			},

			new Models.DataModels.NnhMember
			{
				NnhMemberId = Guid.NewGuid().ToString(),
				NnhUserName = "lecuong",
				NnhPassword = "123456",
				NnhFullname = "Le Van Cuong",
				NnhEmail = "lecuong@gmail.com"
			},

			new Models.DataModels.NnhMember
			{
				NnhMemberId = Guid.NewGuid().ToString(),
				NnhUserName = "phamduc",
				NnhPassword = "123456",
				NnhFullname = "Pham Van Duc",
				NnhEmail = "phamduc@gmail.com"
			},

			new Models.DataModels.NnhMember
			{
				NnhMemberId = Guid.NewGuid().ToString(),
				NnhUserName = "hoangnam",
				NnhPassword = "123456",
				NnhFullname = "Hoang Van Nam",
				NnhEmail = "hoangnam@gmail.com"
			}
		};

		public IActionResult Index()
		{
			return View(_members);
		}

		public IActionResult GetMember()
		{
			var member = new Models.DataModels.NnhMember
			{
				NnhMemberId = Guid.NewGuid().ToString(),
				NnhUserName = "Ngoc Hieu",
				NnhPassword = "password123",
				NnhFullname = "Nguyen Ngoc Hieu",
				NnhEmail = "Taodeptrai@gmail.com"
			};

			return View(member);
		}

		public IActionResult GetMembers()
		{
			ViewBag.Members = _members;
			return View();
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(NnhMember member)
		{
			if (ModelState.IsValid)
			{
				member.NnhMemberId = Guid.NewGuid().ToString();
				_members.Add(member);

				return RedirectToAction(nameof(Index));
			}

			return View(member);
		}
	}
}