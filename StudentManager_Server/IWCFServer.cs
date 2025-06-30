using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager_Server
{
    [ServiceContract]
    internal interface IWCFServer
    {
        [OperationContract] 
        string SayHello();

    }
}
