using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }
        public string ISBN { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        // Book 1 <---> 1 Arthor
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

        // Book 1 <---> 1 Category
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
