using Library.Extension;
using Library.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Service
{
    public class Server<Rep, Entity, DTO> : IServer<DTO>
         where DTO : class
         where Entity : class
         where Rep : RepositoryBase<Entity>
    {
        //Rep:RepositoryBase<Entity> ServiceBase in Rep hareket tipi RepositoryBase tipinde olduğu belirtildiği için ServiceBase sınıfını kullandığımız yerlerde Rep hareket tipi iin ProductRepository,CategoryRepository Supp yazılabilir.

        //ServiceBase sınıfı repositorybase sınıfına talepleri gönderen ve repositorybase sınıfından response'ları alan bir sınıftır.ServiceBase sınıfının hangi RepositoryBase sınıfı(ProductRepository mi,CategoryRepository mi?) ile iletişimde olduğunu bilmek gerekir.Ayrıca ServiceBase sınıfı client'a DTO nesnesi yollamalı ve clienttn gelen DTO nesnesini RepositoryBase sınıfına gönderirken Entity'ye dönüştürmesi gerekir.

        //ServiceBase'in hem repository tipi hem entity tipi hem de DTO tipi argümanlarına ihtiyacı vardır.

        private Rep repository;

        public Rep Repository
        {
            get
            {
                repository = repository ?? Activator.CreateInstance<Rep>();
                return repository;
            }
            set
            {
                repository = value;
            }
        }
        public bool Adding(DTO dto)
        {
            //Repository.Adding(dto);

            return Repository.Adding(dto.Changer<Entity>());
        }

        public List<DTO> GetAllBook(int ID)
        {
            BookRepository bookRepo = new BookRepository();
            return bookRepo.GetAllBook(ID).Select(x => x.Changer<DTO>()).ToList();
        }

        public List<DTO> Listing()
        {

            return Repository.Listing().Select(x => x.Changer<DTO>()).ToList();

        }

    }
}