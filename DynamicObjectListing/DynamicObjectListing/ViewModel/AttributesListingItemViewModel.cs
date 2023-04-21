using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicObjectListing.ViewModel
{
    public class AttributesListingItemViewModel : BaseViewModel
    {
        public string AttributeName { get; }
        public bool IsAttributeSelectedForDisplay { get; set;  }

        public AttributesListingItemViewModel(string attributeName, bool isAttributeSelectedForDisplay) 
        {
            AttributeName = attributeName;
            IsAttributeSelectedForDisplay = isAttributeSelectedForDisplay;
        }
        public override string ToString()
        {
            return AttributeName;
        }
    }
}
