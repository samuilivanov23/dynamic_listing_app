using DynamicObjectListing.Command;
using DynamicObjectListing.Model;
using DynamicObjectListing.Store;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DynamicObjectListing.ViewModel
{
    public class AttributesListingViewModel : BaseViewModel
    {
        private readonly ObservableCollection<AttributesListingItemViewModel> _attributesListingItemViewModels;
        public IEnumerable<AttributesListingItemViewModel> AttributesListingItemViewModels => _attributesListingItemViewModels;
        public ICommand? ContinueToSingleObjectListCommand { get; }

        public AttributesListingViewModel(NavigationStore navigationStore, List<string> objectToDisplayAllAttributes, IBaseModel objectToDisplayModel)
        {
            _attributesListingItemViewModels = new ObservableCollection<AttributesListingItemViewModel>();

            foreach (var attribute in objectToDisplayAllAttributes) 
            {
                _attributesListingItemViewModels.Add(new AttributesListingItemViewModel(attribute, false));
            }

            ContinueToSingleObjectListCommand = new SingleObjectListingCommand(navigationStore, _attributesListingItemViewModels, objectToDisplayModel);
        }
    }
}