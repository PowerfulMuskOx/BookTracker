using System;
using System.Collections.Generic;

namespace BookTracker.Data
{
    public partial class Genre
    {
        public Genre()
        {
            Book = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}
