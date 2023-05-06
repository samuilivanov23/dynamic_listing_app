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
    public class SingleObjectAthleteListingViewModel : BaseViewModel
    {
        private readonly ObservableCollection<Athlete> _singleObjectAthleteListingItemViewModels;
        private readonly ObservableCollection<AttributesListingItemViewModel> _selectedAttributes;

        public IEnumerable<Athlete> SingleObjectAthleteListingItemViewModels => _singleObjectAthleteListingItemViewModels;
        public IEnumerable<AttributesListingItemViewModel> SelectedAttributes => _selectedAttributes;

        public SingleObjectAthleteListingViewModel(NavigationStore navigationStore, ObservableCollection<AttributesListingItemViewModel> selectedAttributes, IBaseModel objectToDisplayModel)
        {
            _selectedAttributes = selectedAttributes;
            _singleObjectAthleteListingItemViewModels = new ObservableCollection<Athlete>
            {
                new Athlete(1, "FirstName1", "MiddleName1", "LastName1", 36, 9, 17),
                new Athlete(2, "FirstName2", "MiddleName2", "LastName2", 37, 10, 18),
                new Athlete(3, "FirstName3", "MiddleName3", "LastName3", 38, 11, 19),
                new Athlete(4, "FirstName4", "MiddleName4", "LastName4", 39, 12, 20)
            };
        }
    }
}
