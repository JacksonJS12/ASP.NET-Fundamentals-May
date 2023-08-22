namespace Library.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.Category;
    public class Category
    {
        public Category()
        {
            this.Books = new HashSet<Book>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public virtual ICollection<Book> Books { get; set; }
    }
}
//•	    Has Id – a unique integer, Primary Key 
//•	    Has Name – a string with min length 5 and max length 50 (required) 
//    •	Has Books – a collection of type Books 
