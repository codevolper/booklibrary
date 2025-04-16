using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Domain.Entities
{
    public class Author
    {
        public int Id { get; set; }
        
        public string FisrtName { get; set; }
        
        public string LastName { get; set; }
        
        // Navigation properties
        public virtual ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
