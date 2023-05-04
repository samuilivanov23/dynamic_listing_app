using DynamicObjectListing.Command;
using DynamicObjectListing.Components;
using DynamicObjectListing.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DynamicObjectListing.ViewModel
{
    public class ObjectsAttributesSelectionViewModel : BaseViewModel
    {   
        public ObjectsListingViewModel ObjectsListingViewModel { get; }
        //public AttributesListingViewModel AttributesListingViewModel { get; }

        //public ICommand? ContinueToObjectAttributesCommand { get; }

        public ObjectsAttributesSelectionViewModel(NavigationStore navigationStore)
        {
            ObjectsListingViewModel = new ObjectsListingViewModel(navigationStore);
            //AttributesListingViewModel = new AttributesListingViewModel();
            //ContinueToObjectAttributesCommand = new NavigateCommand(navigationStore);
        }
    }
}