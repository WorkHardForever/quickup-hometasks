using System.ComponentModel.DataAnnotations;

namespace AspWithEf.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Group Group { get; set; }
    }
}
