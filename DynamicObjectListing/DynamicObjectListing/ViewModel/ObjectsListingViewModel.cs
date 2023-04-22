using DynamicObjectListing.Command;
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

            _objectsListingItemViewModels.Add(new ObjectsListingItemViewModel("athletes", false));
            _objectsListingItemViewModels.Add(new ObjectsListingItemViewModel("activities", false));
            _objectsListingItemViewModels.Add(new ObjectsListingItemViewModel("segments", false));

            ContinueToObjectAttributesCommand = new NavigateCommand(navigationStore);
        }
    }
}