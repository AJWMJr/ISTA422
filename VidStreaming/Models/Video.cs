using System;
using System.Collections.Generic;

namespace VidStreaming.Models
{
    public partial class Video
    {
        public Video()
        {
            Comment = new HashSet<Comment>();
        }

        public int VideoId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Source { get; set; }
        public string Description { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
    }
}
