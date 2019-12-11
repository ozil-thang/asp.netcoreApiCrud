using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_Aspnetcore.Models
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        [StringLength(200, MinimumLength = 19, ErrorMessage = "Headline must be 10-200")]
        public string Headline { get; set; }
        
        [Required]
        [StringLength(2000, MinimumLength = 50, ErrorMessage = "ReviewText must be 50-2000")]
        public string ReviewText { get; set; }
        public int Rating { get; set; }

        public virtual Reviewer Reviewer { get; set; }
        public virtual Book Book { get; set; }
    }
}