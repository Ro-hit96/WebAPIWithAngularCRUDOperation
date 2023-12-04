using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIBOOK.Model
{
    [Table("Book")]
    public class Book
    {
        [Key]//this is pk colom in Db
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Author { get; set; }
        public int Price { get; set; }
    }
}
