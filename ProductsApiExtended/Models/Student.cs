using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsApiExtended.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; } = string.Empty;
        public StudentAdress? Address { get; set; } 

        public Student()
        {
            this.Courses = new HashSet<Course>();
        }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
