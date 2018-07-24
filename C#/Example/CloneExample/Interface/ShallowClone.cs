using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneExample.Interface
{
    public interface ShallowClone<T>
    {
        T ShallowClone();
    }
}
