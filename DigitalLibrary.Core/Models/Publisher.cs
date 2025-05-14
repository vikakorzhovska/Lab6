using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalLibrary.Core.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
