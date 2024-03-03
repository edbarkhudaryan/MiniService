using System;
using System.ComponentModel.DataAnnotations;

namespace MiniServiceDesk.Models
{
	public class Users
	{
        [Key]
        public int ID { get; set; }
        [Required]
        public string UserName { get; set; }
        public string LastName { get; set; }
        public Users()
		{
		}
	}
}

