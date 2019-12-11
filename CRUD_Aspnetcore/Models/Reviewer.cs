using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_Aspnetcore.Models
{
    public class Reviewer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(100, ErrorMessage = "First name cannot be more 100")]
        public string FirstName { get; set; }
        
        [Required]
        [MaxLength(200, ErrorMessage = "Last name cannot be more 200")]
        public string LastName { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}