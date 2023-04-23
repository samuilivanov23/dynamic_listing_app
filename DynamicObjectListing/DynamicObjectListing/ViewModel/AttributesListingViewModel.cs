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

        public AttributesListingViewModel(List<string> objectToDisplayAllAttributes)
        {
            _attributesListingItemViewModels = new ObservableCollection<AttributesListingItemViewModel>();

            foreach (var attribute in objectToDisplayAllAttributes) 
            {
                _attributesListingItemViewModels.Add(new AttributesListingItemViewModel(attribute, false));
            }
        }
    }
}
