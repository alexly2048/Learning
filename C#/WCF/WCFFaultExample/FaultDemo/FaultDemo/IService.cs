using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace FaultDemo
{
    [ServiceContract(Namespace="http://www.wcfdemo.com")]
    interface IService
    {
        string SampleMethod(string msg);    
    }
}
