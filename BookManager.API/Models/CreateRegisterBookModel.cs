namespace BookManager.API.Models
{
    public class CreateRegisterBookModel
    {
        public int Id { get; set; } 
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? ISBN { get; set; }
        public string? YearOfPublication { get; set; }
    }
}
