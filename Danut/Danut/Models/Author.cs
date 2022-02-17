namespace Danut.Models
{
    public class Author
    {
        public Author()
        {
        }

        public Author(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }

    }
}