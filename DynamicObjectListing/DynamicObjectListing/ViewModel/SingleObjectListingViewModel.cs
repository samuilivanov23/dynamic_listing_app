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
        private readonly ObservableCollection<IBaseModel> _singleObjectListingItemViewModels;
        private readonly ObservableCollection<AttributesListingItemViewModel> _selectedAttributes;

        public IEnumerable<IBaseModel> SingleObjectListingItemViewModels => _singleObjectListingItemViewModels;
        public IEnumerable<AttributesListingItemViewModel> SelectedAttributes => _selectedAttributes;

        public SingleObjectListingViewModel(NavigationStore navigationStore, ObservableCollection<AttributesListingItemViewModel> selectedAttributes, IBaseModel objectToDisplayModel)
        {
            _selectedAttributes = selectedAttributes;
            _singleObjectListingItemViewModels = new ObservableCollection<IBaseModel>();
            Console.WriteLine(objectToDisplayModel.GetType());

            if (objectToDisplayModel.GetType().Name == "Athlete")
            {
                Console.WriteLine(objectToDisplayModel.GetType());
            }

            if (objectToDisplayModel.GetType().Name == "ActivitySession")
            {
                Console.WriteLine(objectToDisplayModel.GetType());
            }

            if (objectToDisplayModel.GetType().Name == "Segment")
            {
                Console.WriteLine(objectToDisplayModel.GetType());
                _singleObjectListingItemViewModels.Add(new Segment(1, 12.4, 20, "start1", "end1"));
                _singleObjectListingItemViewModels.Add(new Segment(2, 13.4, 21, "start2", "end2"));
                _singleObjectListingItemViewModels.Add(new Segment(3, 14.4, 22, "start3", "end3"));
                _singleObjectListingItemViewModels.Add(new Segment(4, 15.4, 23, "start4", "end4"));
            }

            for (int i = 0; i < 3; i++) 
            {
                //_singleObjectListingItemViewModels.Add();
            }
            //_singleObjectListingItemViewModels.Add();
            //_singleObjectListingItemViewModels.Add();
            //_singleObjectListingItemViewModels.Add();
        }
    }
}
