using Imtahan.Areas.Admin.ViewModels.Professions;
using Imtahan.DbContexts;
using Imtahan.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Imtahan.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class ProfessionController : Controller
    {
        MyDbContext _db { get; }

        public ProfessionController(MyDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var items = await _db.Professions.Select(x => new ProfessionListItemVm
            {
                Id = x.Id,
                Name = x.Name,
            }).ToListAsync();
            return View(items);
        }


        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProfessionCreateVm profession)
        {
            if (!ModelState.IsValid)
            {
                return View(profession);
            }

            await _db.Professions.AddAsync(new Profession
            {
                Name = profession.Name,
            });
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null || id < 1) return BadRequest();
            var item = await _db.Professions.FindAsync(id);
            if (item == null) return NotFound();
            ProfessionUpdateVm update = new ProfessionUpdateVm
            {
                Name = item.Name,
            };
            return View(update);
        }
        [HttpPost]
        public async Task<IActionResult> Update(int? id, ProfessionUpdateVm update)
        {
            if (id == null || id < 1) return BadRequest();
            var item = await _db.Professions.FindAsync(id);
            if (item == null) return NotFound();
            if (!ModelState.IsValid)
            {
                return View(update);
            }
            item.Name = update.Name;            
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || id < 1) return BadRequest();
            var item = await _db.Professions.FindAsync(id);
            if (item == null) return NotFound();
            _db.Professions.Remove(item); 
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }


    }
}
