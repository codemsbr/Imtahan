using Imtahan.Models;
using System.ComponentModel.DataAnnotations;

namespace Imtahan.Areas.Admin.ViewModels.Employee
{
    public class EmployeeListItemVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string facebookUrl { get; set; }
        public string LinkUrl { get; set; }
        public string xUrl { get; set; }
        public string Decription { get; set; }
        public string ImgUrl { get; set; }
        public Profession? Profession { get; set; }

    }
}
