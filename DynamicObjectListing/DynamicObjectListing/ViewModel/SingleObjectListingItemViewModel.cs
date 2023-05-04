using DynamicObjectListing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicObjectListing.ViewModel
{
    public class SingleObjectListingItemViewModel : BaseViewModel
    {
        public IBaseModel baseModelToDisplay { get; set; }

        public SingleObjectListingItemViewModel(IBaseModel baseModelToDisplay)
        {
            this.baseModelToDisplay = baseModelToDisplay;
        }
        public override string ToString()
        {
            return this.baseModelToDisplay.ToString();
        }
    }
}
