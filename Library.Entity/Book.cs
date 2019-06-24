using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entity
{
    public class Book
    {
        public Book()
        {
            this.writers = new HashSet<Writer>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public ICollection<Writer> writers { get; set; }
    }
}
