using Spectre.Console;

namespace library_management
{
    internal class BookService
    {
        public static Book GetBookOptionInput()
        {
            var books = BookController.GetBooks();
            var bookArray = books.Select(x => x.Title).ToArray();
            var option = AnsiConsole.Prompt(new SelectionPrompt<string>()
                .Title("Selecciona un libro")
                .AddChoices(bookArray));

            var id = books.Single(x => x.Title == option).Id;
            var book = BookController.GetBookById(id);
            return book;
        }
    }
}
