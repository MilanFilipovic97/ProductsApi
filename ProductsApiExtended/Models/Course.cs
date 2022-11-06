using System.ComponentModel.DataAnnotations;

namespace ProductsApiExtended.Models
{
    public class Course
    {
        public Course()
        {
            this.Students = new HashSet<Student>();
        }
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public virtual ICollection<Student> Students { get; set; }


    }
}
