namespace BookManager.Domain.Exceptions
{
    public class OverdueBookException : Exception
    {
        public OverdueBookException() : base($"Devolução do livro em atraso atraso!") { }
    }
}
