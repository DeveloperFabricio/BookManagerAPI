using BookManager.Application.InputModels;
using BookManager.Application.Services.Implemetations;
using BookManager.Application.ViewModels;

namespace BookManager.Application.Services.Interfaces
{
    public interface IBookService
    {
        List<BookViewModel> GetAll(string query);
        BookDetailsViewModel GetById(int id);
        int Create(CreateRegisterBookInputModel modelInput);
        void Update(UpdateBookInputModel modelInput);
        void Delete(int id);
    }
}
