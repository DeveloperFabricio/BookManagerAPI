namespace BookManager.Application.InputModels
{
    public class CreateRegisterBookInputModel
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? ISBN { get; set; }
        public string? YearOfPublication { get; set; }
    }
}
