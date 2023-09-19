namespace library_management
{
    internal class LibraryUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookBorrowing> Borrowings { get; set; }
    }
}
