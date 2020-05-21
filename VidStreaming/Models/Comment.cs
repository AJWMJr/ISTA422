using System;
using System.Collections.Generic;

namespace VidStreaming.Models
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public int VideoId { get; set; }
        public int UserId { get; set; }
        public string Body { get; set; }

        public virtual User User { get; set; }
        public virtual Video Video { get; set; }
    }
}
