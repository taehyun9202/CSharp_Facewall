using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
namespace Wall.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get;set; }
        [Required]
        public string Content { get;set; }
        public string Image { get;set; }
        public User Creator { get;set; }
        public int UserId { get;set; }
        public Message Message { get;set; }
        public int MessageId { get;set; }
        public int Like { get;set; }
        public int ToId { get;set; }
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}