using DynamicObjectListing.Model;
using DynamicObjectListing.Store;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicObjectListing.ViewModel
{
    public class SingleObjectSelectionViewModel : BaseViewModel
    {
        public SingleObjectListingViewModel SingleObjectListingViewModel { get; }

        public SingleObjectSelectionViewModel(NavigationStore navigationStore, ObservableCollection<AttributesListingItemViewModel> selectedAttributes, IBaseModel objectToDisplayModel)
        {
            SingleObjectListingViewModel = new SingleObjectListingViewModel(navigationStore, selectedAttributes, objectToDisplayModel);
        }
    }
}