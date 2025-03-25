namespace LibraryManagementSystem.Models
{
    public class Book
    {
        public int Id { get; set; } // Unique ID
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; } = true; // Default available
    }
}
