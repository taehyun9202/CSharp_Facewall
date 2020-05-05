using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
namespace Wall.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get;set; }
        [Required]
        public string ItemName { get;set; }
        [Required]
        public string Image { get;set; }
        public string Description { get;set; }
        public User Uploader { get;set; }
        public int UserId { get;set; }
        public List<Comment> Reply { get;set; }

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}