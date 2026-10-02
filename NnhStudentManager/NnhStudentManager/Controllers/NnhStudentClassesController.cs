
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NnhStudentManager.Models;
using NnhStudentManager.Data;

public class NnhStudentClassesController : Controller
{
    private readonly NnhStudentManagerContext _context;

    public NnhStudentClassesController(NnhStudentManagerContext context)
    {
        _context = context;
    }

    // GET: NNHSTUDENTCLASSS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.NnhStudentClasses.ToListAsync());
    }

    // GET: NNHSTUDENTCLASSS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nnhstudentclass = await _context.NnhStudentClasses
            .FirstOrDefaultAsync(m => m.Id == id);
        if (nnhstudentclass == null)
        {
            return NotFound();
        }

        return View(nnhstudentclass);
    }

    // GET: NNHSTUDENTCLASSS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: NNHSTUDENTCLASSS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,NnhClassName,NnhStudents")] NnhStudentClass nnhstudentclass)
    {
        if (ModelState.IsValid)
        {
            _context.Add(nnhstudentclass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(nnhstudentclass);
    }

    // GET: NNHSTUDENTCLASSS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nnhstudentclass = await _context.NnhStudentClasses.FindAsync(id);
        if (nnhstudentclass == null)
        {
            return NotFound();
        }
        return View(nnhstudentclass);
    }

    // POST: NNHSTUDENTCLASSS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,NnhClassName,NnhStudents")] NnhStudentClass nnhstudentclass)
    {
        if (id != nnhstudentclass.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(nnhstudentclass);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NnhStudentClassExists(nnhstudentclass.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(nnhstudentclass);
    }

    // GET: NNHSTUDENTCLASSS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nnhstudentclass = await _context.NnhStudentClasses
            .FirstOrDefaultAsync(m => m.Id == id);
        if (nnhstudentclass == null)
        {
            return NotFound();
        }

        return View(nnhstudentclass);
    }

    // POST: NNHSTUDENTCLASSS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var nnhstudentclass = await _context.NnhStudentClasses.FindAsync(id);
        if (nnhstudentclass != null)
        {
            _context.NnhStudentClasses.Remove(nnhstudentclass);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool NnhStudentClassExists(int? id)
    {
        return _context.NnhStudentClasses.Any(e => e.Id == id);
    }
}
