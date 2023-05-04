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
    public class SingleObjectSegmentListingViewModel : BaseViewModel
    {
        private readonly ObservableCollection<Segment> _singleObjectSegmentListingItemViewModels;
        private readonly ObservableCollection<AttributesListingItemViewModel> _selectedAttributes;

        public IEnumerable<Segment> SingleObjectSegmentListingItemViewModels => _singleObjectSegmentListingItemViewModels;
        public IEnumerable<AttributesListingItemViewModel> SelectedAttributes => _selectedAttributes;

        public SingleObjectSegmentListingViewModel(NavigationStore navigationStore, ObservableCollection<AttributesListingItemViewModel> selectedAttributes, IBaseModel objectToDisplayModel)
        {
            _selectedAttributes = selectedAttributes;
            _singleObjectSegmentListingItemViewModels = new ObservableCollection<Segment>
            {
                new Segment(1, 12.4, 20, "start1", "end1"),
                new Segment(2, 13.4, 21, "start2", "end2"),
                new Segment(3, 14.4, 22, "start3", "end3"),
                new Segment(4, 15.4, 23, "start4", "end4")
            };
        }
    }
}
