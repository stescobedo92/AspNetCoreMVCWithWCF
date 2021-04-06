using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AspNetCoreMVCWithWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDemoService" in both code and config file together.
    [ServiceContract]
    public interface IDemoService
    {
        [OperationContract]
        void DoWork();
    }
}
