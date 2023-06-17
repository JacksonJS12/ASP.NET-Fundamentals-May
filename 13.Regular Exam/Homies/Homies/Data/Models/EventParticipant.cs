using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Homies.Data.Models
{
    public class EventParticipant
    {
        public string HelperId { get; set; } = null!;


        public IdentityUser Helper { get; set; } = null!;


        public int EventId { get; set; }


        public Event Event { get; set; } = null!;

    }
}
//•	HelperId – a  string, Primary Key, foreign key (required)
//•	Helper – IdentityUser
//•	EventId – an integer, Primary Key, foreign key (required)
//•	Event – Event
