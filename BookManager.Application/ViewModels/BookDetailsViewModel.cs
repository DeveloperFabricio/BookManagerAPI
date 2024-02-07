namespace BookManager.Application.ViewModels
{
    public class BookDetailsViewModel
    {
        public BookDetailsViewModel(int id, string? title, string? author, string? iSBN, string? yearOfPublication)
        {
            Id = id;
            Title = title;
            Author = author;
            ISBN = iSBN;
            YearOfPublication = yearOfPublication;
        }

        public int Id { get; private set; }
        public string? Title { get; private set; }
        public string? Author { get; private set; }
        public string? ISBN { get; private set; }
        public string? YearOfPublication { get; private set; }
    }
}
