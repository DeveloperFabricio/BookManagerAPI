namespace BookManager.Application.Services.Implemetations
{
    public class BookViewModel
    {
        public BookViewModel(string? title, string? author)
        {
            Title = title;
            Author = author;
        }

        public string? Title { get; private set; }
        public string? Author { get; private set; }
    }
}
