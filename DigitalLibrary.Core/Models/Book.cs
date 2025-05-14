using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalLibrary.Core.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public string ISBN { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public ICollection<Review> Reviews { get; set; }
        public ICollection<BorrowedBook> BorrowedBooks { get; set; }
    }
}
