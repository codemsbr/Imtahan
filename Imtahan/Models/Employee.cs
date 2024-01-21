using System.ComponentModel.DataAnnotations;

namespace Imtahan.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [MinLength(3), MaxLength(16)]
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public int ProfessionId { get; set; }
        public Profession? Profession { get; set; }

    }
}
