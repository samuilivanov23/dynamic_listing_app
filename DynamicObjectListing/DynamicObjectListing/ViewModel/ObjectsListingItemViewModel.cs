using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DynamicObjectListing.ViewModel
{
    public class ObjectsListingItemViewModel : BaseViewModel
    {
        public string ObjectType { get; }
        public bool IsObjectSelectedForDisplay { get; set; }

        public ObjectsListingItemViewModel(string objectType, bool isObjectSelectedForDisplay) 
        {
            ObjectType = objectType;
            IsObjectSelectedForDisplay = isObjectSelectedForDisplay;
        }
        public override string ToString()
        {
            return ObjectType;
        }
    }
}
