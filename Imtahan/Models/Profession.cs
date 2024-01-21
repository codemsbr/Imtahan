using System.ComponentModel.DataAnnotations;

namespace Imtahan.Models
{
    public class Profession
    {
        public int Id { get; set; }
        [MinLength(10)]
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}
