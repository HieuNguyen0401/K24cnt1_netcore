
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NnhStudentManager.Models;
using NnhStudentManager.Data;

public class NnhSubjectsController : Controller
{
    private readonly NnhStudentManagerContext _context;

    public NnhSubjectsController(NnhStudentManagerContext context)
    {
        _context = context;
    }

    // GET: NNHSUBJECTS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.NnhSubjects.ToListAsync());
    }

    // GET: NNHSUBJECTS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nnhsubject = await _context.NnhSubjects
            .FirstOrDefaultAsync(m => m.Id == id);
        if (nnhsubject == null)
        {
            return NotFound();
        }

        return View(nnhsubject);
    }

    // GET: NNHSUBJECTS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: NNHSUBJECTS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,NnhSubjectName,NnhMarks")] NnhSubject nnhsubject)
    {
        if (ModelState.IsValid)
        {
            _context.Add(nnhsubject);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(nnhsubject);
    }

    // GET: NNHSUBJECTS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nnhsubject = await _context.NnhSubjects.FindAsync(id);
        if (nnhsubject == null)
        {
            return NotFound();
        }
        return View(nnhsubject);
    }

    // POST: NNHSUBJECTS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,NnhSubjectName,NnhMarks")] NnhSubject nnhsubject)
    {
        if (id != nnhsubject.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(nnhsubject);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NnhSubjectExists(nnhsubject.Id))
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
        return View(nnhsubject);
    }

    // GET: NNHSUBJECTS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nnhsubject = await _context.NnhSubjects
            .FirstOrDefaultAsync(m => m.Id == id);
        if (nnhsubject == null)
        {
            return NotFound();
        }

        return View(nnhsubject);
    }

    // POST: NNHSUBJECTS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var nnhsubject = await _context.NnhSubjects.FindAsync(id);
        if (nnhsubject != null)
        {
            _context.NnhSubjects.Remove(nnhsubject);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool NnhSubjectExists(int? id)
    {
        return _context.NnhSubjects.Any(e => e.Id == id);
    }
}
