using Library.DTO;
using Library.Entity;
using Library.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Library.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Book" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Book.svc or Book.svc.cs at the Solution Explorer and start debugging.
    public class BookService :Server<BookRepository,Book,BookDTO>
    {
      
    }
}
