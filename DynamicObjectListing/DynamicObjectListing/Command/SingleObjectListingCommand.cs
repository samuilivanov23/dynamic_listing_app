using DynamicObjectListing.Model;
using DynamicObjectListing.Store;
using DynamicObjectListing.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicObjectListing.Command
{
    public class SingleObjectListingCommand : BaseCommand
    {
        private readonly NavigationStore _navigationStore;

        private readonly ObservableCollection<AttributesListingItemViewModel> _attributesListingItemViewModels;

        private readonly IBaseModel _objectToDisplayModel;
        public SingleObjectListingCommand(NavigationStore navigationStore, ObservableCollection<AttributesListingItemViewModel> attributesListingItemViewModels, IBaseModel objectToDisplayModel)
        {
            _navigationStore = navigationStore;
            _attributesListingItemViewModels = attributesListingItemViewModels;
            _objectToDisplayModel = objectToDisplayModel;
        }
        public override void Execute(object? parameter)
        {
            ObservableCollection<AttributesListingItemViewModel> selectedAttributes = new ObservableCollection<AttributesListingItemViewModel>(_attributesListingItemViewModels.Where(attr => attr.IsAttributeSelectedForDisplay == true).ToList());

            var _objectToDisplayModeTypeName = _objectToDisplayModel.GetType().Name;

            if (_objectToDisplayModeTypeName  == "Athlete")
            {
                //new instance of AthleteObjectListingViewModel
                //observableCollection of Athlete objects
                _navigationStore.CurrentViewModel = new SingleObjectAthleteListingViewModel(_navigationStore, selectedAttributes, (Athlete)_objectToDisplayModel);
            }
            else if (_objectToDisplayModeTypeName == "ActivitySession")
            {
                //new instance of ActivitySessionObjectListingViewModel
                //observableCollection of ActivitySession objects
                _navigationStore.CurrentViewModel = new SingleObjectActivitySessionListingViewModel(_navigationStore, selectedAttributes, (ActivitySession)_objectToDisplayModel);
            }
            else if (_objectToDisplayModeTypeName == "Segment")
            {
                //new instance of SegmentObjectListingViewModel
                //observableCollection of Segment objects
                _navigationStore.CurrentViewModel = new SingleObjectSegmentListingViewModel(_navigationStore, selectedAttributes, (Segment)_objectToDisplayModel);
            }
        }
    }
}
