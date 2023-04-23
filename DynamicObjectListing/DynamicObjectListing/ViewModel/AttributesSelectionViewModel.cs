using DynamicObjectListing.Command;
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

        public ICommand? DisplayFullObjectDataCommand { get; }

        public AttributesSelectionViewModel(NavigationStore navigationStore, List<string> objectToDisplayAllAttributes)
        {
            //ObjectsListingViewModel = new ObjectsListingViewModel();
            AttributesListingViewModel = new AttributesListingViewModel(objectToDisplayAllAttributes);
            //DisplayFullObjectDataCommand = new NavigateCommand(navigationStore, objectToDisplayAllAttributes);
        }
    }
}
