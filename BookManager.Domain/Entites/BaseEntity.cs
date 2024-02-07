namespace BookManager.Domain.Entites
{
    public class BaseEntity
    {
        protected BaseEntity(){}
        public int Id { get; private set; }
    }
}
