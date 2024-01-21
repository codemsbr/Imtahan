using Imtahan.Models;

namespace Imtahan.Areas.Admin.ViewModels.Professions
{
    public class ProfessionListItemVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}
