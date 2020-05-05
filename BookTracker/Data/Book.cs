using System;
using System.Collections.Generic;

namespace BookTracker.Data
{
    public partial class Book
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public int Authorid { get; set; }
        public string Genre { get; set; }

        public virtual Genre GenreNavigation { get; set; }
    }
}
