using System;
using System.ComponentModel.DataAnnotations;

namespace CodingEventsMVC.Models
{
	public class Tag
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Name is required")]
		[StringLength(50, MinimumLength = 3, ErrorMessage = "Tag must be between 3-50 characters.")]
		public string Name { get; set; } = string.Empty;


		//public List<EventTag> EventTags { get; set; }  //collection navigation
		public virtual ICollection<Event> Events { get; set; }
		//public List<EventTag> EventTags { get; set; }


		public Tag(string name)
		{
			Name = name;
		}

		public Tag()
		{
			this.Events = new HashSet<Event>();
		}
	}
}

/* TODO: B --
 * 
 * able to create a Tag, but it will not pass through the AddEvent method in the controller
 * 
 * is there a reason we didn't creat a viewmodel for tag?   
 */