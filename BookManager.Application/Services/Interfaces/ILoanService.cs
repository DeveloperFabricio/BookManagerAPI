using BookManager.Application.InputModels;
using BookManager.Application.Services.Implemetations;

namespace BookManager.Application.Services.Interfaces
{
    public interface ILoanService
    {
        LoanViewModel GetById(int id);
        int Create(CreateLoanInputModel modelInput);
        void Delete(int id);
    }
}
