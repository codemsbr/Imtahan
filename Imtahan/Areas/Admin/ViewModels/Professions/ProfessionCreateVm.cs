using System.ComponentModel.DataAnnotations;

namespace Imtahan.Areas.Admin.ViewModels.Professions
{
    public class ProfessionCreateVm
    {
        [MinLength(10)]
        public string Name { get; set; }
    }
}
