using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIBOOK.Model
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string? City { get; set; }
        [Required]
        public int Percentage { get; set; }
    }
}
