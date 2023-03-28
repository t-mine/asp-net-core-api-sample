using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.Shared.Models
{
    [Table("book")]
    public class Book
    {
        [Column("book_id")]
        public int BookId { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("author")]
        public string Author { get; set; }

        public Book(int bookId, string title, string author)
        {
            BookId = bookId;
            Title = title;
            Author = author;
        }
    }
}
