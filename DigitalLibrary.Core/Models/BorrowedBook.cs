using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalLibrary.Core.Models
{
    public class BorrowedBook
    {
        public int Id { get; set; }

        public string BorrowerName { get; set; }
        public DateTime BorrowedAt { get; set; }
        public DateTime? ReturnedAt { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
