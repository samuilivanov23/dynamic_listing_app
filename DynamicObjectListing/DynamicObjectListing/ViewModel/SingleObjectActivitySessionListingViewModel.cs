using DynamicObjectListing.Command;
using DynamicObjectListing.Model;
using DynamicObjectListing.Model.Databse;
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
    public class SingleObjectActivitySessionListingViewModel : BaseViewModel
    {
        private readonly ObservableCollection<ActivitySession> _singleObjectActivitySessionListingItemViewModels;
        private readonly ObservableCollection<AttributesListingItemViewModel> _selectedAttributes;

        public IEnumerable<ActivitySession> SingleObjectActivitySessionListingItemViewModels => _singleObjectActivitySessionListingItemViewModels;
        public IEnumerable<AttributesListingItemViewModel> SelectedAttributes => _selectedAttributes;
        public ICommand? ReturnToObjectSelectionCommand { get; }
        public ICommand? ReturnToAttributesSelectionCommand { get; }

        public SingleObjectActivitySessionListingViewModel(NavigationStore navigationStore, ObservableCollection<AttributesListingItemViewModel> selectedAttributes, IBaseModel objectToDisplayModel)
        {
            _selectedAttributes = selectedAttributes;
            _singleObjectActivitySessionListingItemViewModels = new ObservableCollection<ActivitySession>(new DatabaseManager().GetActivitySessions());

            ReturnToObjectSelectionCommand = new ReturnToObjectSelectionCommand(navigationStore);
            ReturnToAttributesSelectionCommand = new ReturnToAttributesSelectionCommand(navigationStore, objectToDisplayModel);
        }
    }
}
