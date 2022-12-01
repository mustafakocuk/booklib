using System.ComponentModel.DataAnnotations;

namespace booklib.Models
{
    public class BookModel
    {
        public Guid Id { get; set; }

        public string BookName { get; set; }

        public string BookType { get; set; }

        public string BookSubject { get; set; }

        public string Author { get; set; }

        public int Stock { get; set; }

        public string? BookImageFileName { get; set; }

        public DateTime PublishingDate { get; set; }
    }

    public class BookCreateModel
    {
        public string BookName { get; set; }

        public string BookType { get; set; }

        public string BookSubject { get; set; }

        public string Author { get; set; }

        public int Stock { get; set; }

        public string BookImageFileName { get; set; }

        public DateTime PublishingDate { get; set; }
    }

    public class BookEditModel
    {
        public string BookName { get; set; }

        public string BookType { get; set; }

        public string BookSubject { get; set; }

        public string Author { get; set; }

        public int Stock { get; set; }

        public string BookImageFileName { get; set; }

        public DateTime PublishingDate { get; set; }
    }

}
