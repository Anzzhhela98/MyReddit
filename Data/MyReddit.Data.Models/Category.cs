namespace MyReddit.Data.Models
{
    using System.Collections.Generic;

    using MyReddit.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public ICollection<Post> Posts { get; set; }
            = new HashSet<Post>();
    }
}
