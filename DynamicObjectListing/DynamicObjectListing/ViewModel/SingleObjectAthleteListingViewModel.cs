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
    public class SingleObjectAthleteListingViewModel : BaseViewModel
    {
        private readonly ObservableCollection<Athlete> _singleObjectAthleteListingItemViewModels;
        private readonly ObservableCollection<AttributesListingItemViewModel> _selectedAttributes;

        public IEnumerable<Athlete> SingleObjectAthleteListingItemViewModels => _singleObjectAthleteListingItemViewModels;
        public IEnumerable<AttributesListingItemViewModel> SelectedAttributes => _selectedAttributes;
        public ICommand? ReturnToObjectSelectionCommand { get; }
        public ICommand? ReturnToAttributesSelectionCommand { get; }

        public SingleObjectAthleteListingViewModel(NavigationStore navigationStore, ObservableCollection<AttributesListingItemViewModel> selectedAttributes, IBaseModel objectToDisplayModel)
        {
            _selectedAttributes = selectedAttributes;
            _singleObjectAthleteListingItemViewModels = new ObservableCollection<Athlete>(new DatabaseManager().GetAthletes());

            ReturnToObjectSelectionCommand = new ReturnToObjectSelectionCommand(navigationStore);
            ReturnToAttributesSelectionCommand = new ReturnToAttributesSelectionCommand(navigationStore, objectToDisplayModel);
        }
    }
}
