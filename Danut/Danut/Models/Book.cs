namespace Danut.Models
{
    public class Book
    {
        public Book()
        {
        }

        public Book(int id, string name, int authorId, Author author)
        {
            Id = id;
            Name = name;
            AuthorId = authorId;
            Author = author;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }
    }
}
