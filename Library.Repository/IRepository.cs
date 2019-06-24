using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    public
        interface IRepository<T> where T : class
    {
        List<T> Listing();
        bool Adding(T entity);
    }
}
