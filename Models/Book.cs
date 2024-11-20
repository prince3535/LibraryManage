namespace LibraryManage.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string? Author { get; set; }
        public string? ISBN { get; set; }
        public string? Publisher {  get; set; }
        public int Year { get; set; }
    }
}
