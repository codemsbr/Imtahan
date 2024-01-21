using Imtahan.Models;
using System.ComponentModel.DataAnnotations;

namespace Imtahan.Areas.Admin.ViewModels.Employee
{
    public class EmployeeUpdateVm
    {
        [MinLength(3), MaxLength(16)]
        public string Name { get; set; }
        public IFormFile ImgUrl { get; set; }
        public int ProfessionId { get; set; }
        public Profession? Profession { get; set; }
    }
}
