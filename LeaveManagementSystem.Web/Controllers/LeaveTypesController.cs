
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LeaveManagementSystem.Web.Data;
using LeaveManagementSystem.Web.Models.LeaveTypes;
using AutoMapper;

public class LeaveTypesController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;
    private const string NameExistsValidadeMessage = "A leave type with this name already exists.";

    public LeaveTypesController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    // GET: LEAVETYPES
    public async Task<IActionResult> Index()    
    {
        //var data = SELECT * FROM LeaveTypes
        var data = await _context.LeaveTypes.ToListAsync();
        //convert the datamodel into a view model
        var viewData = _mapper.Map<List<LeaveTypeReadOnlyVM>>(data);
        //return the view model to the view
        return View(viewData);
    }

    // GET: LEAVETYPES/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var leaveType = await _context.LeaveTypes
            .FirstOrDefaultAsync(m => m.Id == id);

        if (leaveType == null)
        {
            return NotFound();
        }

        var viewData = _mapper.Map<LeaveTypeReadOnlyVM>(leaveType);

        return View(viewData);
    }

    // GET: LEAVETYPES/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: LEAVETYPES/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(LeaveTypeCreateVM leaveTypeCreate)
    {
        // Adding custom validation model error.
        if (await CheckIfLeaveTypeNameExists(leaveTypeCreate.Name))
        {
            ModelState.AddModelError(nameof(leaveTypeCreate.Name), NameExistsValidadeMessage);
        }

        if (ModelState.IsValid)
        {
            var leaveType = _mapper.Map<LeaveType>(leaveTypeCreate);
            _context.Add(leaveType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(leaveTypeCreate);
    }

        // GET: LEAVETYPES/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var leaveType = await _context.LeaveTypes.FindAsync(id);
        if (leaveType == null)
        {
            return NotFound();
        }
        var viewData = _mapper.Map<LeaveTypeEditVM>(leaveType);
        return View(viewData);
    }

    // POST: LEAVETYPES/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, LeaveTypeEditVM leaveTypeEdit)
    {
        if (id != leaveTypeEdit.Id)
        {
            return NotFound();
        }

        // Adding custom validation model error.
        if (await CheckIfLeaveTypeNameExistsForEdit(leaveTypeEdit))
        {
            ModelState.AddModelError(nameof(leaveTypeEdit.Name), NameExistsValidadeMessage);
        }


        if (ModelState.IsValid)
        {
            try
            {
                var leaveType = _mapper.Map<LeaveType>(leaveTypeEdit);
                _context.Update(leaveType);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LeaveTypeExists(leaveTypeEdit.Id))
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
        return View(leaveTypeEdit);
    }

    // GET: LEAVETYPES/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var leaveType = await _context.LeaveTypes
            .FirstOrDefaultAsync(m => m.Id == id);
        if (leaveType == null)
        {
            return NotFound();
        }

        var viewData = _mapper.Map<LeaveTypeReadOnlyVM>(leaveType);
        return View(viewData);
    }

    // POST: LEAVETYPES/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var leaveType = await _context.LeaveTypes.FindAsync(id);
        if (leaveType != null)
        {
            _context.LeaveTypes.Remove(leaveType);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool LeaveTypeExists(int? id)
    {
        return _context.LeaveTypes.Any(e => e.Id == id);
    }

    private async Task<bool> CheckIfLeaveTypeNameExists(string name)
    {
        var lowerCaseName = name.ToLower();
        return await _context.LeaveTypes.AnyAsync(q => q.Name.ToLower().Equals(lowerCaseName));
    }

    private async Task<bool> CheckIfLeaveTypeNameExistsForEdit(LeaveTypeEditVM leaveTypeEdit)
    {
        var lowerCaseName = leaveTypeEdit.Name.ToLower();
        return await _context.LeaveTypes.AnyAsync(q => q.Name.ToLower().Equals(lowerCaseName) && q.Id != leaveTypeEdit.Id);
    }
}
