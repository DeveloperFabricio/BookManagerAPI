using BookManager.Domain.Enums;

namespace BookManager.Domain.Entites
{
    public class Loan : BaseEntity
    {
        public Loan(int userId, int bookId)
        {
            UserId = userId;
            BookId = bookId;
            Status = LoanStatusEnum.Active;
            LoanDate = DateTime.Now;
            ReturnDate = DateTime.Now.AddDays(5);
        }

        public int UserId { get; set; }
        public int BookId { get; set; }
        public LoanStatusEnum? Status { get; set; }
        public DateTime? LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public void Cancel()
        {
            if (Status == LoanStatusEnum.Active) Status = LoanStatusEnum.Returned;
        }
    }
}
