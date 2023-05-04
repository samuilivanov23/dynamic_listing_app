using DynamicObjectListing.Command;
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
    public class SingleObjectListingViewModel : BaseViewModel
    {
        private readonly ObservableCollection<SingleObjectListingItemViewModel> _singleObjectListingItemViewModels;
        private readonly ObservableCollection<AttributesListingItemViewModel> _selectedAttributes;

        public IEnumerable<SingleObjectListingItemViewModel> SingleObjectListingItemViewModels => _singleObjectListingItemViewModels;
        public IEnumerable<AttributesListingItemViewModel> SelectedAttributes => _selectedAttributes;

        public SingleObjectListingViewModel(NavigationStore navigationStore, ObservableCollection<AttributesListingItemViewModel> selectedAttributes, IBaseModel objectToDisplayModel)
        {
            _selectedAttributes = selectedAttributes;
            _singleObjectListingItemViewModels = new ObservableCollection<SingleObjectListingItemViewModel>();

            for (int i = 0; i < 3; i++) 
            {
                _singleObjectListingItemViewModels.Add(new SingleObjectListingItemViewModel(objectToDisplayModel));
            }
            //_singleObjectListingItemViewModels.Add();
            //_singleObjectListingItemViewModels.Add();
            //_singleObjectListingItemViewModels.Add();

        }
    }
}
