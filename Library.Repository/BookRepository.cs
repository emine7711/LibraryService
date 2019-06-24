using Library.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    public class BookRepository : RepositoryBase<Book>
    {
        public List<Book> GetBooksOfWriter(int writerID)
        {
            try
            {
                LibraryContext db = new LibraryContext();
                //List<Book> booksOfWriter = db.Books.Where(x => x.writers == db.Writers.Where(y => y.ID == writerID)).ToList();

                List<Writer> writers = db.Writers.Where(x => x.ID == writerID).ToList();
                List<Book> booksOfWriter = db.Books.Where(x => x.writers == writers).ToList();

                

                return booksOfWriter;
                

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
