using DynamicObjectListing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicObjectListing.InstantiationManager
{
    public interface ICreator<T> where T : IBaseModel
    {
        bool CanHandle(string type);
        T Create();
    }
}
