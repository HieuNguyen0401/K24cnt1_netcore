using Microsoft.AspNetCore.Mvc;
using NnhLession08Models.Models;

namespace NnhLession08Models.Controllers
{
	public class NnhMemberController : Controller
	{
		//Mock Data
		private static List<Models.NnhMember> _members = new List<Models.NnhMember>
		{
			new NnhMember
			{
				NnhMemberId = Guid.NewGuid().ToString(),
				NnhUserName = "hieu",
				NnhPassword = "123456",
				NnhEmail = "hieu01@gmail.com",
				NnhFullname = "Nguyen Ngoc Hieu"
			},

			new NnhMember
			{
				NnhMemberId = Guid.NewGuid().ToString(),
				NnhUserName = "hieu02",
				NnhPassword = "123456",
				NnhEmail = "hieu02@gmail.com",
				NnhFullname = "Nguyen Van An"
			},

			new NnhMember
			{
				NnhMemberId = Guid.NewGuid().ToString(),
				NnhUserName = "hieu03",
				NnhPassword = "123456",
				NnhEmail = "hieu03@gmail.com",
				NnhFullname = "Tran Van Binh"
			},

			new NnhMember
			{
				NnhMemberId = Guid.NewGuid().ToString(),
				NnhUserName = "hieu04",
				NnhPassword = "123456",
				NnhEmail = "hieu04@gmail.com",
				NnhFullname = "Le Thi Hoa"
			},

			new NnhMember
			{
				NnhMemberId = Guid.NewGuid().ToString(),
				NnhUserName = "hieu05",
				NnhPassword = "123456",
				NnhEmail = "hieu05@gmail.com",
				NnhFullname = "Pham Minh Duc"
			}
		};

		public IActionResult Index()
		{
			return View(_members);
		}

		[HttpGet]
		public IActionResult NnhCreate()
		{
			var member = new NnhMember();
			return View(member);
		}

		[HttpPost]
		public IActionResult NnhCreate(NnhMember member)
		{
			if (ModelState.IsValid)
			{
				member.NnhMemberId = Guid.NewGuid().ToString();

				_members.Add(member);

				return RedirectToAction("Index");
			}

			return View(member);
		}

		public IActionResult NnhEdit(string id)
		{
			var member = _members.Where(m => m.NnhMemberId == id).FirstOrDefault();
			return View(member);
		}

		[HttpPost]
		public IActionResult NnhEdit(string id, NnhMember nnhMember)
		{
			// var member = _members.Where(x => x.NnhMemberId.Equals(id)).FirstOrDefault();
			for (int i = 0; i < _members.Count; i++)
			{
				if (_members[i].NnhMemberId == id)
				{
					_members[i].NnhUserName = nnhMember.NnhUserName;
					_members[i].NnhPassword = nnhMember.NnhPassword;
					_members[i].NnhFullname = nnhMember.NnhFullname;
					_members[i].NnhEmail = nnhMember.NnhEmail;

					return RedirectToAction("Index");
				}
			}

			return View();
		}

		public IActionResult NnhDetails(string id)
		{
			var member = _members.Where(m => m.NnhMemberId == id).FirstOrDefault();
			return View(member);
		}

		public IActionResult NnhDelete(string id)
		{
			var member = _members.Where(m => m.NnhMemberId == id).FirstOrDefault();
			return View(member);
		}

		[HttpGet]
		public IActionResult NnhDeleted()
		{
			var member = new NnhMember();
			return View(member);
		}

		[HttpPost]
		public IActionResult NnhDeleted(string id)
		{
			foreach (var item in _members)
			{
				if (item.NnhMemberId == id)
				{
					_members.Remove(item);
					return RedirectToAction("Index");
				}
			}

			return View("NnhDelete");
		}
	}
}