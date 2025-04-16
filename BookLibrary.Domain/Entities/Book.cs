using System.ComponentModel.DataAnnotations;

namespace BookLibrary.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;  
        
        public  string FirstName { get; set; } = string.Empty;

        public  string LastName { get; set; } = string.Empty;

        public int TotalCopies { get; set; }

        public int TotalCopiesInUse { get; set; }

        [MaxLength(50)]
        public string Type { get; set; } = string.Empty;

        [MaxLength(80)]
        public string ISBN { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Category { get; set; } = string.Empty;

    }
}
