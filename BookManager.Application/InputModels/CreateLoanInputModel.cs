namespace BookManager.Application.InputModels
{
    public class CreateLoanInputModel
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime? LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
