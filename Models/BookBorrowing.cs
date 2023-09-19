using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace library_management
{
    internal class BookBorrowing
    {
        //Data annotations
        [Key]
        public int Id { get; set; }

        /*
         * Para cada FK, agregar la columna específica de la otra tabla
         * y un atributo adicional del mismo tipo. Adicionalmente, agregar la anotación FK
         */
        [Required]
        public int LibraryUserId { get; set; }
        [ForeignKey(nameof(LibraryUserId))]

        public LibraryUser LibraryUser { get; set; }
        [Required]
        public int BookId { get; set; }

        [ForeignKey(nameof(BookId))]
        public Book Book { get; set; }

        public int BorrowingDayCount { get; set; }
    }
}
