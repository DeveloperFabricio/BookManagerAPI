using BookManager.Application.InputModels;
using BookManager.Application.Services.Implemetations;

namespace BookManager.Application.Services.Interfaces
{
    public interface IUserService
    {
        UserViewModel GetById(int id);
        int Create(CreateInputUserModel modelInput);
    }
}
