using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CRUD_Aspnetcore.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50, ErrorMessage = "Name cannot be more 50")]
        public string Name { get; set; }
        
        public virtual ICollection<BookCategory> BookCategories { get; set; }
    }
}