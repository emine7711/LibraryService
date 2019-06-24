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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WriterService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WriterService.svc or WriterService.svc.cs at the Solution Explorer and start debugging.
    public class WriterService :Server<WriterRepository,Writer,WriterDTO>
    {
     
    }
}
