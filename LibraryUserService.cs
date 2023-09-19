using Spectre.Console;

namespace library_management
{
    internal class LibraryUserService
    {
        public static LibraryUser GetLibraryUserOptionInput()
        {
            var libraryUsers = LibraryUserController.GetLibraryUsers();
            var libraryUserArray = libraryUsers.Select(x => x.Name).ToArray();
            var option = AnsiConsole.Prompt(new SelectionPrompt<string>()
                .Title("Selecciona un usuario")
                .AddChoices(libraryUserArray));

            var id = libraryUsers.Single(x => x.Name == option).Id;
            var libraryUser = LibraryUserController.GetLibraryUserById(id);
            return libraryUser;
        }
    }
}
