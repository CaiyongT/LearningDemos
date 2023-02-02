using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NateChat_Server_Service.Data
{
    
    [ServiceContract]
    public interface IGroupService
    {
        [OperationContract]
        void DoWork();
    }
}
