using System.ComponentModel.DataAnnotations;

namespace Imtahan.Areas.Admin.ViewModels.Professions
{
    public class ProfessionUpdateVm
    {
        [MinLength(10)]
        public string Name { get; set; }
    }
}
