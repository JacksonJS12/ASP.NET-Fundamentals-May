using System.ComponentModel.DataAnnotations;
using static Forum.App.Common.EntityValidation.Post;

namespace Forum.App.Data.Models
{
    public class Post
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLentgth)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(ContentMaxLentgth)]
        public string Content { get; set; } = null!;
    }
}
