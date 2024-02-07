using BookManager.Domain.Entites;

namespace BookManager.Infrastructure.Persistence.Repositories
{
    public class BookManagerDbContext
    {
        public BookManagerDbContext()
        {
            Books = new List<Book> 
            {
                new Book("Entendendo Algoritmos: Um Guia Ilustrado Para Programadores e Outros Curiosos", "Aditya BhargavaAditya Bhargava", "978-8575225639", "2017"),
                new Book("Código limpo: habilidades práticas do Agile software", "Robert C. MartinRobert C. Martin", "978-8576082675", "2009"),
                new Book("O codificador limpo: um código de conduta para programadores profissionais", "Robert C. MartinRobert C. Martin", "978-8576086475", "2012")
            };

            Loans = new List<Loan>
            {
                new Loan(1,1),
                new Loan(2,2),
                new Loan(3,3),
            };

            Users = new List<User> 
            {
                new User("Anderson Costa", "andeerson@email.com.br"),
                new User("Mayara Costa", "mayara@email.com.br"),
                new User("Douglas Costa", "douglas@email.com.br")
            };
        }
        public List<Book>? Books { get; set; }
        public List<Loan>? Loans { get; set; }
        public List<User>? Users { get; set; }
    }
}
