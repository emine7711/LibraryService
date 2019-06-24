using Library.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    public class RepositoryBase<TT> : IRepository<TT> where TT : class
    {

       
        IObjectContextAdapter _context;
        IObjectSet<TT> _objectSet;
        public RepositoryBase()
        {
            _context = new LibraryContext();
            _objectSet = _context.ObjectContext.CreateObjectSet<TT>();
        }



        public bool Adding(TT entity)
        {
           
            try
            {
                _objectSet.AddObject(entity);
                _context.ObjectContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }



        public List<TT> Listing()
        {

            List<TT> liste = _objectSet.ToList();
            return liste;
        }

    }
}
