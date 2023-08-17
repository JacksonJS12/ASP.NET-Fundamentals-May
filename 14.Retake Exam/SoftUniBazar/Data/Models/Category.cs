namespace SoftUniBazar.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Category
    {
        public Category()
        {
            this.Ads = new HashSet<Ad>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 3)]
        public string Name { get; set; } = null!;

        public ICollection<Ad> Ads { get; set; }
    }
}