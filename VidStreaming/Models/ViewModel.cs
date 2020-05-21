using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VidStreaming.Models
{
    public class ViewModel
    {
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<Video> Videos { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
    }
}
