using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc
{
    public interface IDataService
    {
        List<string> GetData();
    }
}
