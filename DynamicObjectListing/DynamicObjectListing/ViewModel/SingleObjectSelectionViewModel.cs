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
            if (objectToDisplayModel.GetType().Name == "Athlete")
            {
                //new instance of AthleteObjectListingViewModel
                //observableCollection of Athlete objects
                SingleObjectListingViewModel = new SingleObjectListingViewModel(navigationStore, selectedAttributes, objectToDisplayModel);
            }
            else if (objectToDisplayModel.GetType().Name == "ActivitySession")
            {
                //new instance of ActivitySessionObjectListingViewModel
                //observableCollection of ActivitySession objects
                SingleObjectListingViewModel = new SingleObjectListingViewModel(navigationStore, selectedAttributes, objectToDisplayModel);
            }
            else if (objectToDisplayModel.GetType().Name == "Segment")
            {
                //new instance of SegmentObjectListingViewModel
                //observableCollection of Segment objects
                SingleObjectListingViewModel = new SingleObjectListingViewModel(navigationStore, selectedAttributes, objectToDisplayModel);
            }
        }
    }
}