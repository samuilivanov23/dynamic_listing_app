using DynamicObjectListing.Command;
using DynamicObjectListing.Model;
using DynamicObjectListing.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DynamicObjectListing.ViewModel
{
    public class AttributesSelectionViewModel : BaseViewModel
    {
        //public ObjectsListingViewModel ObjectsListingViewModel { get; }
        public AttributesListingViewModel AttributesListingViewModel { get; }

        public AttributesSelectionViewModel(NavigationStore navigationStore, List<string> objectToDisplayAllAttributes, IBaseModel objectToDisplayModel)
        {
            //ObjectsListingViewModel = new ObjectsListingViewModel();
            AttributesListingViewModel = new AttributesListingViewModel(navigationStore, objectToDisplayAllAttributes, objectToDisplayModel);
        }
    }
}
