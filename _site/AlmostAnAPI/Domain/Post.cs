using System.Collections.Generic;

namespace AlmostAnAPI.Domain
{
    public class Post
    {
        public string Text { get; set; }
        public IList<Video> Videos { get; set; }
        public IList<Image> Images { get; set; }
    }
}