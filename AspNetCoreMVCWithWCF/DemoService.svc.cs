using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AspNetCoreMVCWithWCF
{
    public class DemoService : IDemoService
    {
        public string Hello()
        {
            return "First WCF service";
        }

        public string Hi(string name)
        {
            return "Hi " + name;
        }

        public int Sum(int a, int b)
        {
            return (a + b);
        }
    }
}
