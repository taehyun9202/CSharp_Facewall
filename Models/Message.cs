using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
namespace Wall.Models
{
    public class Message
    {
        [Key]
        public int MessageId { get;set; }
        [Required]
        public string Content { get;set; }
        public User Creator { get;set; }
        public int UserId { get;set; }
        public List<Comment> Reply { get;set; }

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}