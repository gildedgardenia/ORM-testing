﻿using System;
namespace CodingEventsMVC.Models
{
    //created in 14.2
    public class Event
    {
        //17
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ContactEmail { get; set; }

        //18
        public EventCategory Category { get; set; }
        public int CategoryId { get; set; }

        public Event()
        {
        }

        public Event(string name, string description, string contactEmail)
        {
            Name = name;
            Description = description;
            ContactEmail = contactEmail;
        }


        //removed EventType

        public override string? ToString()
        {
            return Name;
        }

        public override bool Equals(object? obj)
        {
            return obj is Event @event &&
                   Id == @event.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}

