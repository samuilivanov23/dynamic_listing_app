using DynamicObjectListing.InstantiationManager;
using DynamicObjectListing.Store;
using DynamicObjectListing.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicObjectListing.Command
{
    public class NavigateCommand : BaseCommand
    {
        private readonly NavigationStore _navigationStore;

        public NavigateCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            var objectToDisplay = (ObjectsListingItemViewModel)parameter;
            var objectToDisplayModel = InstanceMapperToModels.MapInstanceToModel(objectToDisplay.ObjectType);
            var objectToDisplayAllAttributes = objectToDisplayModel.GetType().GetProperties().Select(property => property.Name).ToList();

            _navigationStore.CurrentViewModel = new AttributesSelectionViewModel(_navigationStore, objectToDisplayAllAttributes, objectToDisplayModel);
        }
    }
}