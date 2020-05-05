using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTracker.Data
{
    public class BookService
    {
        private static readonly BookTrackerContext _context;

        public static async Task<List<Book>> GetBooks()
        {
            return await _context.Book.ToListAsync();
        }
    }
}
