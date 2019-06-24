using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Library.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServer" in both code and config file together.
    [ServiceContract]
    public interface IServer<DTO> where DTO : class
    {

        //Bu katmanın olmasının sebebi,Client'ların direk olarak entity ve facade lara ulaşmaması içindir
        //Service katmanına client tarafından gelen nesneler DTO nesneleridir.(Entity nesneleri gelmez)
        
        [OperationContract]
        List<DTO> Listing();
        [OperationContract]
        bool Adding(DTO dto);
        [OperationContract]
        [WebGet(RequestFormat =WebMessageFormat.Json, ResponseFormat =WebMessageFormat.Json)]
        List<DTO> GetBooksOfWriter(int ID);
    


    }
}
