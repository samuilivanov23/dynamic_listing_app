using DynamicObjectListing.Model;
using DynamicObjectListing.Model.Databse;
using DynamicObjectListing.Store;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicObjectListing.ViewModel
{
    public class SingleObjectSegmentListingViewModel : BaseViewModel
    {
        private readonly ObservableCollection<Segment> _singleObjectSegmentListingItemViewModels;
        private readonly ObservableCollection<AttributesListingItemViewModel> _selectedAttributes;

        public IEnumerable<Segment> SingleObjectSegmentListingItemViewModels => _singleObjectSegmentListingItemViewModels;
        public IEnumerable<AttributesListingItemViewModel> SelectedAttributes => _selectedAttributes;

        public SingleObjectSegmentListingViewModel(NavigationStore navigationStore, ObservableCollection<AttributesListingItemViewModel> selectedAttributes, IBaseModel objectToDisplayModel)
        {
            _selectedAttributes = selectedAttributes;
            _singleObjectSegmentListingItemViewModels = new ObservableCollection<Segment>(new DatabaseManager().GetSegments());
        }
    }
}
