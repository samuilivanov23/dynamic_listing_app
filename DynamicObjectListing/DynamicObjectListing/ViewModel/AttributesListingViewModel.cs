using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DynamicObjectListing.ViewModel
{
    public class AttributesListingViewModel : BaseViewModel
    {
        private readonly ObservableCollection<AttributesListingItemViewModel> _attributesListingItemViewModels;
        public IEnumerable<AttributesListingItemViewModel> AttributesListingItemViewModels => _attributesListingItemViewModels;

        public AttributesListingViewModel()
        {
            _attributesListingItemViewModels = new ObservableCollection<AttributesListingItemViewModel>();

            _attributesListingItemViewModels.Add(new AttributesListingItemViewModel("FirstName", false));
            _attributesListingItemViewModels.Add(new AttributesListingItemViewModel("MiddleName", false));
            _attributesListingItemViewModels.Add(new AttributesListingItemViewModel("LastName", false));
            _attributesListingItemViewModels.Add(new AttributesListingItemViewModel("ActivitiesCount", false));
            _attributesListingItemViewModels.Add(new AttributesListingItemViewModel("Followers", false));
            _attributesListingItemViewModels.Add(new AttributesListingItemViewModel("Following", false));
        }

    }
}
