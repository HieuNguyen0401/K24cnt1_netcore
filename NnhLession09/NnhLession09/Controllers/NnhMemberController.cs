using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NnhLession09.Models.DataModels;

namespace NnhLession09.Controllers
{
	public class NnhMemberController : Controller
	{
		private static List<NnhMember> _members = new List<NnhMember>();

		// GET: NnhMemberController
		public ActionResult Index()
		{
			return View(_members);
		}

		// GET: NnhMemberController/Details/5
		public ActionResult Details(int id)
		{
			var member = _members.FirstOrDefault(x => x.NnhMemberId == id);

			if (member == null)
			{
				return NotFound();
			}

			return View(member);
		}

		// GET: NnhMemberController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: NnhMemberController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(NnhMember member)
		{
			try
			{
				member.NnhMemberId = _members.Count + 1;
				_members.Add(member);

				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View(member);
			}
		}

		// GET: NnhMemberController/Edit/5
		public ActionResult Edit(int id)
		{
			var member = _members.FirstOrDefault(x => x.NnhMemberId == id);

			if (member == null)
			{
				return NotFound();
			}

			return View(member);
		}

		// POST: NnhMemberController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, NnhMember member)
		{
			try
			{
				var oldMember = _members.FirstOrDefault(x => x.NnhMemberId == id);

				if (oldMember == null)
				{
					return NotFound();
				}

				oldMember.NnhUserName = member.NnhUserName;
				oldMember.NnhPassword = member.NnhPassword;
				oldMember.NnhEmail = member.NnhEmail;
				oldMember.NnhPhoneNumber = member.NnhPhoneNumber;
				oldMember.NnhFullName = member.NnhFullName;
				oldMember.NnhBirthday = member.NnhBirthday;

				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View(member);
			}
		}

		// GET: NnhMemberController/Delete/5
		public ActionResult Delete(int id)
		{
			var member = _members.FirstOrDefault(x => x.NnhMemberId == id);

			if (member == null)
			{
				return NotFound();
			}

			return View(member);
		}

		// POST: NnhMemberController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				var member = _members.FirstOrDefault(x => x.NnhMemberId == id);

				if (member == null)
				{
					return NotFound();
				}

				_members.Remove(member);

				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}