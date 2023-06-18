using System.ComponentModel.DataAnnotations;

namespace Homies.Models
{
    public class EventViewModel
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Title { get; set; }
        public string Start { get; set; }
        public string Type { get; set; }
        public string Organiser { get; set; }

    }
}
//•	Has Id – a unique integer, Primary Key
//•	Has Name – a string with min length 5 and max length 20 (required)
//•	Has Description – a string with min length 15 and max length 150 (required)
//•	Has OrganiserId – an string (required)
//•	Has Organiser – an IdentityUser (required)
//•	Has CreatedOn – a DateTime with format "yyyy-MM-dd H:mm" (required) (the DateTime format is recommended, if you are having troubles with this one, you are free to use another one)
//•	Has Start – a DateTime with format "yyyy-MM-dd H:mm" (required) (the DateTime format is recommended, if you are having troubles with this one, you are free to use another one)
//•	Has End – a DateTime with format "yyyy-MM-dd H:mm" (required) (the DateTime format is recommended, if you are having troubles with this one, you are free to use another one)
//•	Has TypeId – an integer, foreign key (required)
//•	Has Type – a Type (required)
//•	Has EventsParticipants – a collection of type EventParticipant
