using Imtahan.DbContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Imtahan.Areas.Admin.ViewComponents.Employee
{
    public class EmployeeViewComponent:ViewComponent
    {
        MyDbContext _db { get; set; }

        public EmployeeViewComponent(MyDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync(int count,int page)
        {

            return View();
        }
    }
}
