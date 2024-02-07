namespace BookManager.Domain.Entites
{
    public class User : BaseEntity
    {
        public User(string? name, string? email)
        {
            Name = name;
            Email = email;
            Users = new List<User>();
            Loans = new List<Loan>();
        }

        public string? Name { get; set; }
        public string? Email { get; set; }
        public List<User>? Users { get; set; } 
        public List<Loan>? Loans { get; set; }
    }
}
