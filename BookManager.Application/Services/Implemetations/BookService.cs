using BookManager.Application.InputModels;
using BookManager.Application.Services.Interfaces;
using BookManager.Application.ViewModels;
using BookManager.Domain.Entites;
using BookManager.Infrastructure.Persistence.Repositories;

namespace BookManager.Application.Services.Implemetations
{
    public class BookService : IBookService
    {
        private readonly BookManagerDbContext _dbContext;

        public BookService(BookManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(CreateRegisterBookInputModel modelInput)
        {
            var book = new Book(modelInput.Title, modelInput.Author, modelInput.ISBN, modelInput.YearOfPublication);

            _dbContext.Books!.Add(book);

            return book.Id;
        }

        public void Delete(int id)
        {
            var book = _dbContext.Books!.SingleOrDefault(book => book.Id == id);

            _dbContext?.Books!.Remove(book!);
        }

        public List<BookViewModel> GetAll(string query)
        {
            var books = _dbContext.Books;

            var booksViewModel = books!.Select(b => new BookViewModel(b.Title, b.Author)).ToList();

            return booksViewModel;
        }

        public BookDetailsViewModel GetById(int id)
        {
            var book = _dbContext?.Books!.SingleOrDefault(b => b.Id == id);

            if (book == null) return null!;

            var bookDetailViemModel = new BookDetailsViewModel(book.Id, book.Title, book.Author, book.ISBN, book.YearOfPublication);

            return bookDetailViemModel;
        }

        public void Update(UpdateBookInputModel modelInput)
        {
            var book = _dbContext.Books!.SingleOrDefault(b => b.Id == modelInput.Id);

            book!.Update(book.Title!);
        }
    }
}
