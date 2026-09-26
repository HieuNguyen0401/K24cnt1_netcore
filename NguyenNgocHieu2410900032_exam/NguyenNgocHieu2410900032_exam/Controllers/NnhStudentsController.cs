
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NguyenNgocHieu2410900032_exam.Models;

public class NnhStudentsController : Controller
{
    private readonly NnhStudent2410900032DbContext _context;

    public NnhStudentsController(NnhStudent2410900032DbContext context)
    {
        _context = context;
    }

    // GET: NNHSTUDENTS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.NnhStudents.ToListAsync());
    }

    // GET: NNHSTUDENTS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nnhstudent = await _context.NnhStudents
            .FirstOrDefaultAsync(m => m.Id == id);
        if (nnhstudent == null)
        {
            return NotFound();
        }

        return View(nnhstudent);
    }

    // GET: NNHSTUDENTS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: NNHSTUDENTS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,NnhName,NnhGender,NnhBirthDay,NnhEmail,NnhPhone,NnhActive")] NnhStudent nnhstudent)
    {
        if (ModelState.IsValid)
        {
            _context.Add(nnhstudent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(nnhstudent);
    }

    // GET: NNHSTUDENTS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nnhstudent = await _context.NnhStudents.FindAsync(id);
        if (nnhstudent == null)
        {
            return NotFound();
        }
        return View(nnhstudent);
    }

    // POST: NNHSTUDENTS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,NnhName,NnhGender,NnhBirthDay,NnhEmail,NnhPhone,NnhActive")] NnhStudent nnhstudent)
    {
        if (id != nnhstudent.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(nnhstudent);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NnhStudentExists(nnhstudent.Id))
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
        return View(nnhstudent);
    }

    // GET: NNHSTUDENTS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nnhstudent = await _context.NnhStudents
            .FirstOrDefaultAsync(m => m.Id == id);
        if (nnhstudent == null)
        {
            return NotFound();
        }

        return View(nnhstudent);
    }

    // POST: NNHSTUDENTS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var nnhstudent = await _context.NnhStudents.FindAsync(id);
        if (nnhstudent != null)
        {
            _context.NnhStudents.Remove(nnhstudent);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool NnhStudentExists(int? id)
    {
        return _context.NnhStudents.Any(e => e.Id == id);
    }
}
