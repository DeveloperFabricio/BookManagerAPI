using BookManager.Application.InputModels;
using BookManager.Application.Services.Interfaces;
using BookManager.Domain.Entites;
using BookManager.Infrastructure.Persistence.Repositories;

namespace BookManager.Application.Services.Implemetations
{
    public class UserService : IUserService
    {
        private readonly BookManagerDbContext _dbContext;

        public UserService(BookManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(CreateInputUserModel modelInput)
        {
            var user = new User(modelInput.Name, modelInput.Email);

            _dbContext.Users!.Add(user);

            return user.Id;
        }

        public UserViewModel GetById(int id)
        {
            var user = _dbContext.Users!.SingleOrDefault(u => u.Id == id);

            if (user == null) return null!;

            return new UserViewModel(user.Name, user.Email);
        }
    }
}
