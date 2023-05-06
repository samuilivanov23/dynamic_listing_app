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
    public class SingleObjectActivitySessionListingViewModel : BaseViewModel
    {
        private readonly ObservableCollection<ActivitySession> _singleObjectActivitySessionListingItemViewModels;
        private readonly ObservableCollection<AttributesListingItemViewModel> _selectedAttributes;

        public IEnumerable<ActivitySession> SingleObjectActivitySessionListingItemViewModels => _singleObjectActivitySessionListingItemViewModels;
        public IEnumerable<AttributesListingItemViewModel> SelectedAttributes => _selectedAttributes;

        public SingleObjectActivitySessionListingViewModel(NavigationStore navigationStore, ObservableCollection<AttributesListingItemViewModel> selectedAttributes, IBaseModel objectToDisplayModel)
        {
            _selectedAttributes = selectedAttributes;
            _singleObjectActivitySessionListingItemViewModels = new ObservableCollection<ActivitySession>
            {
                new ActivitySession(1, 20.77, 350, 1200, 78, 103, 14),
                new ActivitySession(2, 21.77, 351, 1201, 79, 104, 15),
                new ActivitySession(3, 22.77, 352, 1202, 80, 105, 16),
                new ActivitySession(4, 23.77, 353, 1203, 81, 106, 17)
            };
        }
    }
}
