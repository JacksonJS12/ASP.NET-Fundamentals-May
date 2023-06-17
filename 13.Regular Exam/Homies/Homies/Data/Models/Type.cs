using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Homies.Data.Models
{
    public class Type
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(15)]
        public string Name { get; set; } = null!;

        public List<Event> Events { get; set; } = new List<Event>();
    }
}

//•	Has Id – a unique integer, Primary Key
//•	Has Name – a string with min length 5 and max length 15 (required)
//•	Has Events – a collection of type Event
