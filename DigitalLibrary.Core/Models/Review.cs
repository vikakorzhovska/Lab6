using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalLibrary.Core.Models
{
    public class Review
    {
        public int Id { get; set; }

        public string ReviewerName { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; } 

        public DateTime CreatedAt { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
