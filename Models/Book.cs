using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_management
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public List<BookBorrowing> Borrowings { get; set; }

    }
}
