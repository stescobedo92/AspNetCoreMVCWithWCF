using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AspNetCoreMVCWithWCF
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        Product finc();

        [OperationContract]
        List<Product> findAll();
    }
}
