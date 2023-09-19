using Spectre.Console;

namespace library_management
{
    internal class MenuManager
    {
        enum BorrowingMenuOptions
        {
            BorrowBook,
            ViewBorrowingHistory,
            Quit
        }
        enum BookMenuOptions
        {
            AddBook,
            DeleteBook,
            Quit
        }
        enum LibraryUserMenuOptions
        {
            AddLibraryUser,
            DeleteLibraryUser,
            Quit
        }
        enum MainMenuOptions
        {
            ManageBooks,
            ManageLibraryUsers,
            ManageBookBorrowings
        }

        public static void MainMenuManagement()
        {
            //Menú principal
            var option = AnsiConsole.Prompt(
                new SelectionPrompt<MainMenuOptions>()
                .Title("Qué quieres hacer?")
                .AddChoices(
                    MainMenuOptions.ManageBooks,
                    MainMenuOptions.ManageLibraryUsers,
                    MainMenuOptions.ManageBookBorrowings
                    ));
            switch (option)
            {
                case MainMenuOptions.ManageBooks:
                    BookMenuManagement();
                    break;

                case MainMenuOptions.ManageLibraryUsers:
                    LibraryUserMenuManagement();
                    break;

                case MainMenuOptions.ManageBookBorrowings:
                    BorrowingMenuManagement();
                    break;
            }
            AnsiConsole.Clear();
        }
        public static void BookMenuManagement()
        {
            var option = AnsiConsole.Prompt(
            new SelectionPrompt<BookMenuOptions>()
            .Title("Qué quieres hacer?")
            .AddChoices(
                BookMenuOptions.AddBook,
                BookMenuOptions.DeleteBook,
                BookMenuOptions.Quit));

                        switch (option)
                        {
                            case BookMenuOptions.AddBook:
                                BookController.AddBook();
                                break;
                            case BookMenuOptions.DeleteBook:
                                BookController.DeleteBook();
                                break;
                            case BookMenuOptions.Quit:
                                break;
            }
        }
        public static void LibraryUserMenuManagement()
        {
            var option = AnsiConsole.Prompt(
            new SelectionPrompt<LibraryUserMenuOptions>()
            .Title("Qué quieres hacer?")
            .AddChoices(
                LibraryUserMenuOptions.AddLibraryUser,
                LibraryUserMenuOptions.DeleteLibraryUser,
                LibraryUserMenuOptions.Quit));

            switch (option)
            {
                case LibraryUserMenuOptions.AddLibraryUser:
                    LibraryUserController.AddLibraryUser();
                    break;
                case LibraryUserMenuOptions.DeleteLibraryUser:
                    LibraryUserController.DeleteLibraryUser();
                    break;
                case LibraryUserMenuOptions.Quit:
                    break;
            }
        }
        public static void BorrowingMenuManagement()
        {
            var option = AnsiConsole.Prompt(
            new SelectionPrompt<BorrowingMenuOptions>()
            .Title("Qué quieres hacer?")
            .AddChoices(
                BorrowingMenuOptions.BorrowBook,
                BorrowingMenuOptions.ViewBorrowingHistory,
                BorrowingMenuOptions.Quit));

            switch (option)
            {
                case BorrowingMenuOptions.BorrowBook:
                    BookBorrowingController.AddBorrowing();
                    break;
                case BorrowingMenuOptions.ViewBorrowingHistory:
                    var borrowings = BookBorrowingController.ViewBorrowingHistory();
                    UserInterface.ShowBorrowingHistory(borrowings);
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadLine();
                    break;
                case BorrowingMenuOptions.Quit:
                    break;
            }
        }
    }
}
