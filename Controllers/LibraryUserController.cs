using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_management
{
    internal class LibraryUserController
    {
        public static void AddLibraryUser()
        {
            var name = AnsiConsole.Ask<string>("Nombre de usuario:");
            using var db = new LibraryManagementContext();
            db.Add(new LibraryUser { Name = name });
            db.SaveChanges();
        }
        public static void DeleteLibraryUser()
        {
            throw new NotImplementedException();
        }
        public static LibraryUser GetLibraryUserById(int Id)
        {
            using var db = new LibraryManagementContext();
            var libraryUser = db.LibraryUser.SingleOrDefault(u => u.Id == Id);
            return libraryUser;
        }
        public static List<LibraryUser> GetLibraryUsers()
        {
            using var db = new LibraryManagementContext();
            var libraryUsers = db.LibraryUser.ToList();
            return libraryUsers;
        }
    }
}
