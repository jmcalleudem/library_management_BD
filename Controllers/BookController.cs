using Spectre.Console;

namespace library_management
{
    internal class BookController
    {
        public static void AddBook()
        {
            var title = AnsiConsole.Ask<string>("Título del libro:");
            var author = AnsiConsole.Ask<string>("Autor del libro:");
            var release_date_aux = AnsiConsole.Ask<string>("Fecha de lanzamiento:");
            var release_date = DateOnly.Parse(release_date_aux);

            using var db = new LibraryManagementContext(); //Conexión a la BD --> contexto
            //No necesitamos el Id porque entity framework lo asigna y autoincrementa --> revisar migración
            db.Add(new Book { Title = title, Author = author, ReleaseDate = release_date });

            //Surgirá un error típico porque EF no encuentra la BD en su carpeta por defecto
            //Cambiar directorio de trabajo (flechita hacia abajo del botón run -> Propiedades de depuración)
            //Agregar el full path del proyecto --> clic derecho en el proyecto, copiar ruta completa
            //Esto crea la carpeta Properties --> launchsettings.json
            db.SaveChanges();
        }
        public static void DeleteBook()
        {
            throw new NotImplementedException();
        }
        public static Book GetBookById(int Id)
        {
            using var db = new LibraryManagementContext();
            var book = db.Books.SingleOrDefault(b => b.Id == Id);
            return book;
        }
        public static List<Book> GetBooks()
        {
            using var db = new LibraryManagementContext();
            var books = db.Books.ToList();
            return books;
        }
    }
}
