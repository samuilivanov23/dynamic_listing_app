using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicObjectListing.Model
{
    public abstract class AbstractEntity
    {
        /// <summary>
        /// Base Entity that is inherited by other entities which will be listed
        /// </summary>
        /// <returns></returns>
        public abstract override string ToString();
    }
}
