using Imtahan.Models;

namespace Imtahan.ViewModels.Home
{
    public class EmployeeListItemVm
    {
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public string Decription { get; set; }
        public string facebookUrl { get; set; }
        public string LinkUrl { get; set; }
        public string xUrl { get; set; }

        public Profession? Profession { get; set; }
    }
}
