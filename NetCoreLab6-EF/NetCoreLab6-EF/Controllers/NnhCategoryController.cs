using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreLab6_EF.Data;
using NetCoreLab6_EF.Models;

namespace NetCoreLab6_EF.Controllers
{
	public class NnhCategoryController : Controller
	{
		private readonly NnhAppDbContext _nnhContext;

		public NnhCategoryController(NnhAppDbContext context)
		{
			_nnhContext = context;
		}

		// GET: NnhCategory
		public async Task<IActionResult> NnhIndex()
		{
			return View(await _nnhContext.NnhCategories.ToListAsync());
		}

		// GET: NnhCategory/NnhCreate
		public IActionResult NnhCreate()
		{
			return View();
		}

		// POST: NnhCategory/NnhCreate
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> NnhCreate(
			[Bind("NnhId,NnhName,NnhStatus,NnhCreatedDate")]
			NnhCategory nnhCategory)
		{
			if (ModelState.IsValid)
			{
				nnhCategory.NnhCreatedDate = DateTime.Now;

				_nnhContext.NnhCategories.Add(nnhCategory);

				await _nnhContext.SaveChangesAsync();

				return RedirectToAction(nameof(NnhIndex));
			}

			return View(nnhCategory);
		}

		// GET: NnhCategory/NnhEdit/5
		public async Task<IActionResult> NnhEdit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var nnhCategory = await _nnhContext.NnhCategories.FindAsync(id);

			if (nnhCategory == null)
			{
				return NotFound();
			}

			return View(nnhCategory);
		}

		// POST: NnhCategory/NnhEdit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> NnhEdit(
			int id,
			[Bind("NnhId,NnhName,NnhStatus,NnhCreatedDate")]
			NnhCategory nnhCategory)
		{
			if (id != nnhCategory.NnhId)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					nnhCategory.NnhCreatedDate = DateTime.Now;

					_nnhContext.Update(nnhCategory);

					await _nnhContext.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!NnhCategoryExists(nnhCategory.NnhId))
					{
						return NotFound();
					}

					throw;
				}

				return RedirectToAction(nameof(NnhIndex));
			}

			return View(nnhCategory);
		}

		private bool NnhCategoryExists(int id)
		{
			return _nnhContext.NnhCategories.Any(e => e.NnhId == id);
		}
	}
}