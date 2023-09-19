using Spectre.Console;

namespace library_management
{
    internal class UserInterface
    {
        public static void ShowBorrowingHistory(List<BookBorrowing> borrowings)
        {
            var table = new Table();
            table.AddColumn("Book Name");
            table.AddColumn("Borrowing Daycount");
            foreach (var borrowing in borrowings)
            {
                table.AddRow(BookController.GetBookById(borrowing.BookId).Title, borrowing.BorrowingDayCount.ToString());
            }

            AnsiConsole.Write(table);
        }
    }
}
