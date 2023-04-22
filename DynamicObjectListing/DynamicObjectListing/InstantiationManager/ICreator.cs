using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicObjectListing.InstantiationManager
{
    public interface ICreator<T>
    {
        bool CanHandle(string type);
        T Create();
    }
}
