using Imtahan.Areas.Admin.ViewModels.Employee;
using Imtahan.Areas.Admin.ViewModels.Professions;
using Imtahan.DbContexts;
using Imtahan.Helpers;
using Imtahan.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Imtahan.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployeeController : Controller
    {
        MyDbContext _db { get; set; }
        public EmployeeController(MyDbContext db)
        {
            _db= db;
        }
        public async Task<IActionResult> Index()
        {
            var items = await _db.Employees.Select(x => new EmployeeListItemVm
            {
                Id = x.Id,
                Name = x.Name,
                ImgUrl = x.ImgUrl,
                Profession = x.Profession,                
            }).ToListAsync();
            return View(items);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Profession = new SelectList(_db.Professions, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(EmployeeCreateVm create)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Profession = new SelectList(_db.Professions, "Id", "Name");
                return View(create);
            }

            if(create.ImgUrl != null)
            {
                if (!create.ImgUrl.IsValidType())
                {
                    ViewBag.Profession = new SelectList(_db.Professions, "Name", "Id");
                    ModelState.AddModelError("ImgUrl", "Wrong File Type");
                    return View(create);
                }
            }
 
            await _db.Employees.AddAsync(new Employee
            {
                Name = create.Name,
                ImgUrl = await create.ImgUrl.SaveAsync(PathConstant.ImgUrl),
                ProfessionId = create.ProfessionId,
            });
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Update(int? id)
        {
            if (id < 1 || id == null) return BadRequest();
            var item = await _db.Employees.FindAsync(id);
            if (item == null) return NotFound();
            EmployeeUpdateVm update = new EmployeeUpdateVm()
            {
                Name = item.Name,
                Profession = item.Profession
            };
            ViewBag.Profession = new SelectList(_db.Professions, "Id", "Name");
            return View(update);
        }

        [HttpPost]
        public async Task<IActionResult> Update(EmployeeUpdateVm create,int? id)
        {
            if (id < 1 || id == null) return BadRequest();
            var item = await _db.Employees.FindAsync(id);
            if (item == null) return NotFound();


            if (!ModelState.IsValid)
            {
                ViewBag.Profession = new SelectList(_db.Professions, "Id", "Name");
                return View(create);
            }

            if (create.ImgUrl != null)
            {
                if (!create.ImgUrl.IsValidType())
                {
                    ViewBag.Profession = new SelectList(_db.Professions, "Id", "Name");
                    ModelState.AddModelError("ImgUrl", "Wrong File Type");
                    return View(create);
                }
            }
            item.ProfessionId = create.ProfessionId;
            item.Name = create.Name;
            item.ImgUrl = await create.ImgUrl.SaveAsync(PathConstant.ImgUrl);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id < 1 || id == null) return BadRequest();
            var item = await _db.Employees.FindAsync(id);
            if (item == null) return NotFound();
            _db.Employees.Remove(item);
            return RedirectToAction(nameof(Index));
        }

    }
}
