using System;
using System.Collections.Generic;

namespace VidStreaming.Models
{
    public partial class User
    {
        public User()
        {
            Comment = new HashSet<Comment>();
            Video = new HashSet<Video>();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<Video> Video { get; set; }
    }
}
