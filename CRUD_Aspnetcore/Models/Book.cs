using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_Aspnetcore.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Isn must be 3-10")]
        public string Isbn { get; set; }
        
        [Required]
        [MaxLength(200, ErrorMessage = "Title cannot be more 200")]
        public string Title { get; set; }
        
        
        public DateTime? DatePublished { get; set; }
        
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
        public virtual ICollection<BookCategory> BookCategories { get; set; }
    }
}