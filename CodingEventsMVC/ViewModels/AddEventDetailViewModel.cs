﻿using System;
using CodingEventsMVC.Models;

namespace CodingEventsMVC.ViewModels
{
    //18.4
    public class AddEventDetailViewModel
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContactEmail { get; set; }
        public string CategoryName { get; set; }
        public string TagText { get; set; }



        public AddEventDetailViewModel(Event theEvent, List<EventTag> eventTags)
        {
            EventId = theEvent.Id;
            Name = theEvent.Name;
            Description = theEvent.Description;
            ContactEmail = theEvent.ContactEmail;
            CategoryName = theEvent.Category.Name;

            TagText = "";

            for (var i = 0; i < eventTags.Count; i++)
            {
                TagText += "#" + eventTags[i].Tag.Name;

                if (i < eventTags.Count - 1)
                {
                    TagText += ", ";
                }
            }
        }
    }
}

