using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_management
{
    internal class BookBorrowingController
    {
        public static void AddBorrowing()
        {
            using var db = new LibraryManagementContext();
            LibraryUser libraryUser = LibraryUserService.GetLibraryUserOptionInput();
            Book book = BookService.GetBookOptionInput();

            var borrowingDayCount = AnsiConsole.Ask<int>("Días de préstamo:");
            db.Add(new BookBorrowing { BookId = book.Id, LibraryUserId = libraryUser.Id, BorrowingDayCount = borrowingDayCount });
            db.SaveChanges();
        }
        public static List<BookBorrowing> ViewBorrowingHistory()
        {
            using var db = new LibraryManagementContext();
            LibraryUser libraryUser = LibraryUserService.GetLibraryUserOptionInput();
            List<BookBorrowing> borrowings = db.BookBorrowings.Where(x => x.LibraryUserId == libraryUser.Id).ToList();

            return borrowings;
        }
    }
}
