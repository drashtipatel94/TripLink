using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ServiceModel;

namespace BusinessInterface
{
    [ServiceContract]
    public interface IRiderDB
    {
        [OperationContract]
        int GetTestValue();
    }
}
