using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_management
{
    internal class LibraryManagementContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<LibraryUser> LibraryUser { get; set; }
        public DbSet<BookBorrowing> BookBorrowings { get; set; }

        //Instalar desde el gestor de paquetes de NuGet Microsoft.EntityFrameworkCore.Sqlite --> Motor de BD
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Instalar Microsoft.EntityFrameworkCore.Tools
            optionsBuilder.UseSqlite($"Data Source = library_management.db");
        }

        /*
         * Crear migraciones
         * Herramientas -> Gestor de paquetes NuGet -> Consola de administrador de paquetes -> add-migration nombre-migración
         * Se crea carpeta Migrations automáticamente en el proyecto
         * Migraciones --> Control de verisones BD --> ayuda a mantener la BD y a modificarla a través del tiempo
         * Luego, en la misma consola --> update-database
         * Esto creará la base de datos --> aparece nuevo archivo "nombre-bd.db"
         
         */
    }
}
