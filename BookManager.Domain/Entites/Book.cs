namespace BookManager.Domain.Entites
{
    public class Book : BaseEntity
    {
        public Book(string? title, string? author, string? iSBN, string? yearOfPublication)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            YearOfPublication = yearOfPublication;
            Books = new List<Book>();
            Loans = new List<Loan>();
        }

        public string? Title { get; private set; }
        public string? Author { get; private set; }
        public string? ISBN { get; private set; }
        public string? YearOfPublication { get; private set; }
        public List<Book> Books { get; private set; }
        public List<Loan> Loans { get; private set; }

        public void Update(string title)
        {
            Title = title;
        }
    }
}
