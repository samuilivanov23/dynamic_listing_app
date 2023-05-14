using DynamicObjectListing.Model;
using DynamicObjectListing.Store;
using DynamicObjectListing.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DynamicObjectListing.Command
{
    public class SingleObjectListingCommand : BaseCommand
    {
        private readonly NavigationStore _navigationStore;

        private readonly ObservableCollection<AttributesListingItemViewModel> _attributesListingItemViewModels;

        private readonly IBaseModel _objectToDisplayModel;
        public SingleObjectListingCommand(NavigationStore navigationStore, ObservableCollection<AttributesListingItemViewModel> attributesListingItemViewModels, IBaseModel objectToDisplayModel)
        {
            _navigationStore = navigationStore;
            _attributesListingItemViewModels = attributesListingItemViewModels;
            _objectToDisplayModel = objectToDisplayModel;
        }
        public override void Execute(object? parameter)
        {
            ObservableCollection<AttributesListingItemViewModel> selectedAttributes = new ObservableCollection<AttributesListingItemViewModel>(_attributesListingItemViewModels.Where(attr => attr.IsAttributeSelectedForDisplay == true).ToList());

            if (selectedAttributes.Count > 0)
            {
                var _objectToDisplayModeTypeName = _objectToDisplayModel.GetType().Name;

                if (_objectToDisplayModeTypeName == "Athlete")
                {
                    _navigationStore.CurrentViewModel = new SingleObjectAthleteListingViewModel(_navigationStore, selectedAttributes, (Athlete)_objectToDisplayModel);
                }
                else if (_objectToDisplayModeTypeName == "ActivitySession")
                {
                    _navigationStore.CurrentViewModel = new SingleObjectActivitySessionListingViewModel(_navigationStore, selectedAttributes, (ActivitySession)_objectToDisplayModel);
                }
                else if (_objectToDisplayModeTypeName == "Segment")
                {
                    _navigationStore.CurrentViewModel = new SingleObjectSegmentListingViewModel(_navigationStore, selectedAttributes, (Segment)_objectToDisplayModel);
                }
                else if (_objectToDisplayModeTypeName == "SessionAnalysis")
                {
                    _navigationStore.CurrentViewModel = new SingleObjectSessionAnalysisListingViewModel(_navigationStore, selectedAttributes, (SessionAnalysis)_objectToDisplayModel);
                }
            }
            else 
            {
                string messageBoxText = "Please at least one attribute to continue!";
                string caption = "No Attribute Selection Message";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result;

                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
            }
        }
    }
}
