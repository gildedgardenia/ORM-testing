using System;
namespace CodingEventsMVC.Models
{
    public class EventCategory
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public List<Event> events { get; set; } = new List<Event>();



        public EventCategory()
        {
        }

        public EventCategory (string name)
        {
            Name = name;
        }
    }
}

