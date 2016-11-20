using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspWithEf.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Student> Students { get; set; }
    }
}
