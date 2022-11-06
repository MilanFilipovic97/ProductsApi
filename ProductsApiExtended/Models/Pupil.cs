using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsApiExtended.Models
{
    public class Pupil
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        [ForeignKey("Grade")]
        public int GradeId { get; set; }
        public Grade Grade { get; set; } = null!;  
 

    }
}
