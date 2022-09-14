namespace TestApiWithControllers.Models
{
    public class News
    {
        public int Id { get; set; }
        public int No { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public Uri Image { get; set; }
        public decimal Ammount { get; set; }
    }
}