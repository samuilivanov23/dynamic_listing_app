using DynamicObjectListing.Command;
using DynamicObjectListing.Model.Databse;
using DynamicObjectListing.Model;
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
    public class SingleObjectSessionAnalysisListingViewModel : BaseViewModel
    {
        private readonly ObservableCollection<SessionAnalysis> _singleObjectSessionaAnalysisListingItemViewModels;
        private readonly ObservableCollection<AttributesListingItemViewModel> _selectedAttributes;

        public IEnumerable<SessionAnalysis> SingleObjectSessionaAnalysisListingItemViewModels => _singleObjectSessionaAnalysisListingItemViewModels;
        public IEnumerable<AttributesListingItemViewModel> SelectedAttributes => _selectedAttributes;
        public ICommand? ReturnToObjectSelectionCommand { get; }
        public ICommand? ReturnToAttributesSelectionCommand { get; }

        public SingleObjectSessionAnalysisListingViewModel(NavigationStore navigationStore, 
                                                           ObservableCollection<AttributesListingItemViewModel> selectedAttributes, 
                                                           IBaseModel objectToDisplayModel)
        {
            _selectedAttributes = selectedAttributes;
            _singleObjectSessionaAnalysisListingItemViewModels = new ObservableCollection<SessionAnalysis>(new DatabaseManager().GetSessionAnalyses());

            ReturnToObjectSelectionCommand = new ReturnToObjectSelectionCommand(navigationStore);
            ReturnToAttributesSelectionCommand = new ReturnToAttributesSelectionCommand(navigationStore, objectToDisplayModel);
        }
    }
}
