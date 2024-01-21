using Imtahan.Models;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Imtahan.Areas.Admin.ViewModels.Employee
{
    public class EmployeeCreateVm
    {
        [MinLength(3), MaxLength(16)]
        public string Name { get; set; }
        [MinLength(10), MaxLength(64)]
        public string Decription { get; set; }
        public string facebookUrl { get; set; }
        public string LinkUrl { get; set; }
        public string xUrl { get; set; }
        public IFormFile ImgUrl { get; set; }
        public int ProfessionId { get; set; }
        public Profession? Profession { get; set; }
    }
}
