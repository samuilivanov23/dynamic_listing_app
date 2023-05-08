using DynamicObjectListing.Command;
using DynamicObjectListing.InstantiationManager;
using DynamicObjectListing.Store;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DynamicObjectListing.ViewModel
{
    public class ObjectsListingViewModel : BaseViewModel
    {
        private readonly ObservableCollection<ObjectsListingItemViewModel> _objectsListingItemViewModels;
        public IEnumerable<ObjectsListingItemViewModel> ObjectsListingItemViewModels => _objectsListingItemViewModels;
        public ICommand? ContinueToObjectAttributesCommand { get; }

        public ObjectsListingViewModel(NavigationStore navigationStore) 
        {
            _objectsListingItemViewModels = new ObservableCollection<ObjectsListingItemViewModel>();

            var currentlyAvailableObjectTypes = InstanceMapperToModels.GetAllCurrentlyAvailableObjectTypes();

            foreach(var availableObjectType in currentlyAvailableObjectTypes) 
            {
                _objectsListingItemViewModels.Add(new ObjectsListingItemViewModel(availableObjectType, false));
            }

            ContinueToObjectAttributesCommand = new NavigateCommand(navigationStore);
        }
    }
}