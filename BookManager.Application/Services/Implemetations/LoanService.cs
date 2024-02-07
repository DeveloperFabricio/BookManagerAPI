using BookManager.Application.InputModels;
using BookManager.Application.Services.Interfaces;
using BookManager.Domain.Entites;
using BookManager.Infrastructure.Persistence.Repositories;

namespace BookManager.Application.Services.Implemetations
{
    public class LoanService : ILoanService
    {
        private readonly BookManagerDbContext _dbContext;

        public LoanService(BookManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(CreateLoanInputModel modelInput)
        {
            var loan = new Loan(modelInput.BookId, modelInput.UserId);

            _dbContext.Loans!.Add(loan);

            return loan.Id;
        }

        public void Delete(int id)
        {
            var loan = _dbContext.Loans!.SingleOrDefault(loan => loan.Id == id);

            loan!.Cancel();
        }

        public LoanViewModel GetById(int id)
        {
            var loan = _dbContext?.Loans!.SingleOrDefault(loan => loan?.Id == id);

            if (loan == null) return null!;

            var loanViweModel = new LoanViewModel(loan.Id, loan.UserId, loan.BookId, loan.LoanDate, loan.ReturnDate);

            return loanViweModel;
        }
    }
}
