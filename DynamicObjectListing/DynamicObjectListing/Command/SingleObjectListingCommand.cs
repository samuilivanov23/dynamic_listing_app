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

            //_navigationStore.CurrentViewModel = new SingleObjectListingViewModel(_navigationStore, selectedAttributes, _objectToDisplayModel);
            _navigationStore.CurrentViewModel = new SingleObjectSelectionViewModel(_navigationStore, selectedAttributes, _objectToDisplayModel);
        }
    }
}
