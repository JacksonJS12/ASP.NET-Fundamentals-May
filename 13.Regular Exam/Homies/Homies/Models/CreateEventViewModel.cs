using System.ComponentModel.DataAnnotations;

namespace Homies.Models
{
    public class CreateEventViewModel
    {
        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string Name { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 15)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Start")]
        [DataType(DataType.DateTime)]
        public string Start { get; set; }

        [Required]
        [Display(Name = "End")]
        [DataType(DataType.DateTime)]
        public string End { get; set; }

        [Required]
        [Display(Name = "Type of Event")]
        public int TypeId { get; set; }

    }
}