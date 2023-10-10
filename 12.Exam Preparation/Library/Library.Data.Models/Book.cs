using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static Library.Common.EntityValidationConstants.Book;
    public class Book
    {
        public Book()
        {
            this.UserBooks = new HashSet<IdentityUserBook>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(AuthorLength)]
        public string Author { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionLength)]
        public string Description { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public decimal Rating { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        public virtual ICollection<IdentityUserBook> UserBooks { get; set; }

    }
}
//  •	Has Id – a unique integer, Primary Key 
//  •	Has Title – a string with min length 10 and max length 50 (required) 
//    •	Has Author – a string with min length 5 and max length 50 (required) 
//    •	Has Description – a string with min length 5 and max length 5000 (required) 
//    •	Has ImageUrl – a string (required) 
//    •	Has Rating – a decimal with min value 0.00 and max value 10.00 (required) 
//    •	Has CategoryId – an integer, foreign key (required) 
//    •	Has Category – a Category (required) 
//    •	Has UsersBooks – a collection of type IdentityUserBook 
